using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DTO;
using System.IO;

namespace QuanLyQuanCafe.FormChildren
{
    public partial class fcAccountList : Form
    {
        private Account loginAccount;
        BindingSource accountList = new BindingSource();

        public Account LoginAccount
        {
            get
            {
                return loginAccount;
            }
            set
            {
                loginAccount = value;
            }
        }
        public fcAccountList(Account acc)
        {
            InitializeComponent();
            load();
            this.LoginAccount = acc;
        }

        void load()
        {
            dtgvAccount.DataSource = accountList;
            LoadAccount();
            AddAccountBinding();
        }

        void AddAccountBinding()
        {
            lbUser.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            lbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            lbAccountType.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
            lbActive.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Active", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = UserAccount.Instance.GetListAccount();
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = lbUser.Text;
            string displayName = lbDisplayName.Text;
            int type = Convert.ToInt32(lbAccountType.Text);
            byte[] img = ImageToByteArray(UserAccount.Instance.GetImageByName(userName));
            AccountDetails f = new AccountDetails(type);
            f.IsEdit = true;
            f.LoadAccount(userName, displayName, type);
            f.ShowDialog();
            if (f.UserName != null && f.IsChannged(userName, displayName, type, img) == true)
            {
                EditAccount(f.UserName, f.DisplayName, f.AccountType);
                UserAccount.Instance.UpdateImage(f.UserName, f.AccountImage);
            }
        }

        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        void EditAccount(string userName, string displayName, int type)
        {

            if (UserAccount.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }
            LoadAccount();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            int type = Convert.ToInt32(lbAccountType.Text);
            AccountDetails f = new AccountDetails(type);
            f.IsEdit = false;
            f.ShowDialog();
            if (f.IsAdd())
            {
                AddAccount(f.UserName,f.DisplayName, f.AccountType);
                UserAccount.Instance.UpdateImage(f.UserName, f.AccountImage);
            }           
        }

        void AddAccount(string userName, string displayName, int type)
        {
            if (UserAccount.Instance.InsertAccount(userName, displayName, type) == true)
            {
                MessageBox.Show("Thêm tài khoản thành công");

            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
            LoadAccount();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = lbUser.Text;
            DeleteAccount(userName);
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Không thể xóa tài khoản đang được đăng nhập");
                return;
            }
            if (UserAccount.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");

            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
            LoadAccount();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string userName = lbUser.Text;
            ResetPassword(userName);
        }

        void ResetPassword(string userName)
        {
            if (UserAccount.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");

            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
            LoadAccount();
        }

        private void lbTypeAccount_Click(object sender, EventArgs e)
        {

        }

        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvAccount.CurrentCell.RowIndex;
            string b = dtgvAccount.Rows[r].Cells[0].Value.ToString();
            picAccount.Image = UserAccount.Instance.GetImageByName(b);
        }

        private void btnActiveAccount_Click(object sender, EventArgs e)
        {
            string name = lbUser.Text;
            int active = Convert.ToInt32(lbActive.Text);
            if (active == 0)
            {
                active = 1;
            }    
            else
            {
                active = 0;
            }    
            ChangeActive(name, active);
        }

        void ChangeActive(string name, int active)
        {
            if (loginAccount.UserName.Equals(name))
            {
                MessageBox.Show("Không thể đổi trạng thái tài khoản đang được đăng nhập");
                return;
            }
            if (UserAccount.Instance.ChangeActive(name,active))
            {
                MessageBox.Show("Đổi trạng thái thành công");

            }
            else
            {
                MessageBox.Show("Đổi trạng thái thất bại");
            }
            LoadAccount();
        }
    }
}
