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
        public fSwitchTable(Table table)
        {
            t = table;
            InitializeComponent();           
            LoadComboboxTable(cbSwitchTable);
            Loadlabel(lbCurTable);
        }
        void Loadlabel(Label lb)
        {
            lb.Text ="Bàn "+ t.ID.ToString();
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
            this.Close();
        }

        private void fSwitchTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            BillDAO.Instance.DeleteBillByTableID(t.ID);
        }
    }
}
