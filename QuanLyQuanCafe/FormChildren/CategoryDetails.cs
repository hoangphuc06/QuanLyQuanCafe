using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.FormChildren
{
    public partial class CategoryDetails : Form
    {
        public CategoryDetails()
        {
            InitializeComponent();
        }
        int id;
        string nName;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string CategoryName
        {
            get { return nName; }
            set { nName = value; }
        }

        public bool IsAdd()
        {
            if (string.IsNullOrEmpty(txbCategoryName.Text))
            {
                return false;
            }
            else return true;
        }

        public bool IsChannged(string fname)
        {
            if (nName == fname)
                return false;
            else
            {
                return true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsAdd())
            {
                nName = txbCategoryName.Text;
            }
            this.Close();
        }
        public void LoadCategory(int fid, string fname)
        {
            txbID.Text = fid.ToString();
            txbCategoryName.Text = fname;
        }

        private void CategoryDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
