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
    public partial class TableDetails : Form
    {
        public TableDetails()
        {
            InitializeComponent();
        }
        int id;
        string nName;
        string status;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string TableName
        {
            get { return nName; }
            set { nName = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public bool IsAdd()
        {
            if (string.IsNullOrEmpty(txbTablename.Text))
            {
                return false;
            }
            else return true;
        }

        public bool IsChannged(string fname, string fstatus)
        {
            if (nName == fname && status == fstatus)
                return false;
            else
            {
                return true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(IsAdd())
            {
                nName = txbTablename.Text;
            }
            this.Close();
        }
        public void Loadtable(int fid, string fname, string fstatus)
        {
            txbID.Text = fid.ToString();
            txbTablename.Text = fname;
            txbStatus.Text = fstatus;
        }
    }

}
