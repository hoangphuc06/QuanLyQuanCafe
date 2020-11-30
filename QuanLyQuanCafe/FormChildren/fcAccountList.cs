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
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nudAccountType.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = UserAccount.Instance.GetListAccount();
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)nudAccountType.Value;
            EditAccount(userName, displayName, type);
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
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)nudAccountType.Value;
            AddAccount(userName, displayName, type);
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
            string userName = txbUserName.Text;
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
            string userName = txbUserName.Text;
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
    }
}
