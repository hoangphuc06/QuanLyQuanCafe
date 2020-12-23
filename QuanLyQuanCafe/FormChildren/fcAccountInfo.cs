using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            pictureBox1.Image = UserAccount.Instance.GetImageByName(acc.UserName);
        }
        void ChangeAccount()
        {
            txbUser.Text = LoginAccount.UserName;
            txbDisplayName.Text = UserAccount.Instance.GetDisplayNameByID(loginAccount.UserName);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateInfo();
        }
        void UpdateInfo()
        {
            string displayName = txbDisplayName.Text;
            string name = txbUser.Text;
            byte[] image = ImageToByteArray(pictureBox1.Image);
            if (UserAccount.Instance.UpdateAccount(name, displayName))
            {
                UserAccount.Instance.UpdateImage(name,image);
                MessageBox.Show("Cập nhật tài khoản thành công");
                
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }
        }

        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }

        private void txbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }
    }
}
