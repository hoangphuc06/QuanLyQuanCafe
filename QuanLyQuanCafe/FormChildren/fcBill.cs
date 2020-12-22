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

namespace QuanLyQuanCafe.FormChildren
{
    public partial class fcBill : Form
    {
        public fcBill()
        {
            InitializeComponent();
            LoadDataTimePickerBill();
        }

        void LoadDataTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }


        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);

        }

        private void dtgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvBill.Rows[e.RowIndex];

                int id = (int)row.Cells[0].Value;
                string idTable =row.Cells[1].Value.ToString();
                string ngthu = row.Cells[2].Value.ToString();
                string ngvao = row.Cells[3].Value.ToString();
                string ngra = row.Cells[4].Value.ToString();
                string discount = row.Cells[5].Value.ToString();
                double total = (double)row.Cells[6].Value;

                BillDetails f = new BillDetails(id,idTable,ngthu,ngvao,ngra,discount,total);
                f.ShowDialog();
            }    
        }
    }
}
