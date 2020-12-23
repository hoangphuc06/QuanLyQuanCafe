using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUser.Text;
            string password = txbPassword.Text;
            if (Login(username, password))
            {
                Account loginAccount = UserAccount.Instance.GetAccountByUserNamae(username);
                fTableManager f = new fTableManager(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
                txbPassword.Text = null;
            }
            else
            {
                MessageBox.Show("Sai tài khoản mật khẩu");
            }
        }

        bool Login(string Username, string Password)
        {
            return UserAccount.Instance.Login(Username, Password);
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkboxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxPassword.Checked == true)
            {
                txbPassword.UseSystemPasswordChar = false;
            }    
            else
            {
                txbPassword.UseSystemPasswordChar = true;
            }    
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        
    }
}
