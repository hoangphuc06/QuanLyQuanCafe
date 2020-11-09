using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fAccountProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get
            {
                return loginAccount;
            }
            set
            {
                loginAccount = value;
                ChangeAccount(LoginAccount);
            }
        }
        public fAccountProfile(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            txbUser.Text = acc.UserName;
            txbDisplayName.Text = acc.DisplayName;
        }

        void UpdateAccountInfo()
        {
            string displayName = txbDisplayName.Text;
            string password = txbPassWord.Text;
            string newpass = txbNewPassWord.Text;
            string repass = txbRePassWord.Text;
            string username = txbUser.Text;
            if (!newpass.Equals(repass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới !");
            }    
            else
            {
                if(UserAccount.Instance.UpdateAccount(username,displayName,password,newpass))
                {
                    MessageBox.Show("Cập nhật thành công !");
                    if (updateAccount!=null)
                    {
                        updateAccount(this, new AccountEvent (UserAccount.Instance.GetAccountByUserNamae(username)));
                    }    
                }    
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu !");
                }    
            }
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        private void fAccountProfile_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }
    }
    public class AccountEvent : EventArgs
    {
        private Account acc;

        public Account Acc { get => acc; set => acc = value; }
        public AccountEvent (Account acc)
        {
            this.Acc = acc;
        }
    }
}
