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
using QuanLyQuanCafe.FormChildren;
using QuanLyQuanCafe.Properties;

namespace QuanLyQuanCafe.FormChildren
{
    
    public partial class fcAccountInfo : Form
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
                ChangeAccount();
            }
        }
        public fcAccountInfo(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }
        void ChangeAccount()
        {
            txbUser.Text = LoginAccount.UserName;
            txbDisplayName.Text = LoginAccount.DisplayName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateInfo();
        }
        void UpdateInfo()
        {
            string displayName = txbDisplayName.Text;
            string name = txbUser.Text;
            if (UserAccount.Instance.UpdateAccount(name, displayName))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }
        }

        private void txbUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
