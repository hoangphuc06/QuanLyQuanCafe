using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.FormChildren;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.FormChildren
{
    public partial class fcChangePassword : Form
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
            }
        }
        public fcChangePassword(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePassword();
        }

        void UpdatePassword()
        {
            string password = txbPassWord.Text;
            string newpass = txbNewPassWord.Text;
            string repass = txbRePassWord.Text;
            string username = LoginAccount.UserName;
            if (!newpass.Equals(repass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới !");
            }
            else
            {
                if (UserAccount.Instance.UpdatePassword(username, password, newpass))
                {
                    MessageBox.Show("Cập nhật thành công !");

                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu !");
                }
            }
        }
    }
}
