using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe
{
    public partial class fSwitchTable : Form
    {
        Table t;
        public fSwitchTable(Table tmp)
        {
            InitializeComponent();
            this.t = tmp;
            LoadComboboxTable(cbSwitchTable);
            lbCurTable.Text = t.Name;
        }

        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int id1 = t.ID;
            int id2 = (cbSwitchTable.SelectedItem as Table).ID;
            TableDAO.Instance.SwitchTable(id1, id2);
            BillDAO.Instance.DeleteBillByTableID(id1);
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
