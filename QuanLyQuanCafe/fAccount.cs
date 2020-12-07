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
using QuanLyQuanCafe.FormChildren;

namespace QuanLyQuanCafe
{
    public partial class fAccount : Form
    {
        private Account loginAccount;
        private Form activeForm;

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
        public fAccount(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            fcAccountInfo fc = new fcAccountInfo(LoginAccount);
            OpenChildFrom(fc);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            panelRight.Top = btnInfo.Top;
            panelRight.Height = btnInfo.Height;
            fcAccountInfo fc = new fcAccountInfo(LoginAccount);
            OpenChildFrom(fc);
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            panelRight.Top = btnPassword.Top;
            panelRight.Height = btnPassword.Height;
            fcChangePassword fc = new fcChangePassword(LoginAccount);
            OpenChildFrom(fc);
        }

        private void OpenChildFrom(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pannelDesktop.Controls.Add(childForm);
            this.pannelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
