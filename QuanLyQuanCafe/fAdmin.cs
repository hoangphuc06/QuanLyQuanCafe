using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.FormChildren;

namespace QuanLyQuanCafe
{
    public partial class fAdmin : Form
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
        public fAdmin(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            fcAccountList fc = new fcAccountList(LoginAccount);
            OpenChildFrom(fc);
            DoubleBuffered = true;
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
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            panelRight.Top = btnAccount.Top;
            panelRight.Height = btnAccount.Height;
            fcAccountList fc = new fcAccountList(LoginAccount);
            OpenChildFrom(fc);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            panelRight.Top = btnBill.Top;
            panelRight.Height = btnBill.Height;
            fcBill fc = new fcBill();
            OpenChildFrom(fc);
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            panelRight.Top = btnTable.Top;
            panelRight.Height = btnTable.Height;
            fcTable fc = new fcTable();
            OpenChildFrom(fc);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            panelRight.Top = btnCategory.Top;
            panelRight.Height = btnCategory.Height;
            fcCategory fc = new fcCategory();
            OpenChildFrom(fc);
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            panelRight.Top = btnFood.Top;
            panelRight.Height = btnFood.Height;
            fcFood fc = new fcFood();
            OpenChildFrom(fc);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            panelRight.Top = btnChart.Top;
            panelRight.Height = btnChart.Height;
            fcChart fc = new fcChart();
            OpenChildFrom(fc);
        }
    }
}
