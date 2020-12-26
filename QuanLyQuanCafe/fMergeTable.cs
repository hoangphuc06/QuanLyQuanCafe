using QuanLyQuanCafe.DAO;
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
    public partial class fMergeTable : Form
    {
        public fMergeTable()
        {
            InitializeComponent();

            LoadComboboxTable(cbSwitchTable1);
            LoadComboboxTable(cbSwitchTable2);
            LoadComboboxTable(cbSwitchTable3);
        }
        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList(1);
            cb.DisplayMember = "Name";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int id1 = (cbSwitchTable1.SelectedItem as Table).ID;
            int id2 = (cbSwitchTable2.SelectedItem as Table).ID;
            int id3 = (cbSwitchTable3.SelectedItem as Table).ID;
            string query1 = "select count from dbo.BillInfo as a,dbo.Bill as b Where a.ID_BillInfo=b.ID_Bill and status=0 and b.ID_TableFood= " + id1;
            string query2 = "select count from dbo.BillInfo as a,dbo.Bill as b Where a.ID_BillInfo=b.ID_Bill and status=0 and b.ID_TableFood= " + id2;

            object a = DataProvider.Instance.ExecuteScalar(query1);
            object b = DataProvider.Instance.ExecuteScalar(query2);
            if (b == null || a == null)
            {
                MessageBox.Show("Bàn đang trống !");
            }
            else
            {
                TableDAO.Instance.MergeTable(id1, id2, id3);
                this.Close();
            }
        }

        private void cbSwitchTable1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbSwitchTable2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbSwitchTable3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
