using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;
using iTextSharp.text.pdf;

namespace QuanLyQuanCafe
{
    public partial class fCheckOut : Form
    {
        float TotalPrice = 0;
        float ExcessPrice = 0;
        float SumPrice = 0;
        float PayPrice = 0;
        Table t;
        private PrintDialog printDialog;
        private PrintDocument printDocument;
        private PrintPreviewDialog p = new PrintPreviewDialog();
        DataGridView dtgvBill;
        public fCheckOut(Table table)
        {
            t = table;
            InitializeComponent();
            LoadtotalPrice();
            PayPrice = TotalPrice;
            lbNameFood.Text = table.Name;
            load();
            ShowBill(table.ID);

            this.printDialog = new PrintDialog();
            this.printDocument = new PrintDocument();
            this.printDocument.PrintPage += new PrintPageEventHandler(this.printDocument_PrintPage);

            dtgvBill = new DataGridView();
            dtgvBill.BorderStyle = BorderStyle.Fixed3D;
            dtgvBill.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<QuanLyQuanCafe.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (QuanLyQuanCafe.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("HÓA ĐƠN", new Font("Arial", 20), Brushes.Black, new Point(350, 20));

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(t.ID);
            e.Graphics.DrawString("\nID Bill: " + idBill.ToString(), new Font("Arial", 16), Brushes.Black, new Point(200, 50));

            e.Graphics.DrawString("\n" + t.Name, new Font("Arial", 16), Brushes.Black, new Point(200, 80));

            LoadDtgv();
            Bitmap objBmp = new Bitmap(1000, this.dtgvBill.Height);
            lsvBill.DrawToBitmap(objBmp, new Rectangle(0, 0, 1000, this.dtgvBill.Height));
            e.Graphics.DrawImage(objBmp, 200, 150);

            e.Graphics.DrawString("\n Giảm giá: " + nmDiscount.Value.ToString() + "%", new Font("Arial", 16), Brushes.Black, new Point(200, this.dtgvBill.Height + 180));

            CultureInfo culture = new CultureInfo("vi-VN");
            e.Graphics.DrawString("\n Tổng tiền: " + PayPrice.ToString("c", culture), new Font("Arial", 16), Brushes.Black, new Point(200, this.dtgvBill.Height + 210));

            e.Graphics.DrawString("\n Hẹn gặp lại quý khách !", new Font("Arial", 16), Brushes.Black, new Point(320, this.dtgvBill.Height + 260));

        }

        void LoadDtgv()
        {
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(t.ID);
            dtgvBill.DataSource = MenuDAO.Instance.GetBillByID(idBill);
            dtgvBill.Width = 1000;
            dtgvBill.Height = 500;
        }
        void LoadtotalPrice()
        {
            List<QuanLyQuanCafe.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(t.ID);

            foreach (QuanLyQuanCafe.DTO.Menu item in listBillInfo)
            {
                TotalPrice += item.TotalPrice;
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            lbTotalPrice.Text = TotalPrice.ToString("c", culture);

        }
        private void btnAdd500k_Click(object sender, EventArgs e)
        {
            SumPrice += 500000;
            ExcessPrice = SumPrice - PayPrice;
            load();
        }

        private void btnAdd200k_Click(object sender, EventArgs e)
        {
            SumPrice += 200000;
            ExcessPrice = SumPrice - PayPrice;
            load();
        }

        private void btnAdd100k_Click(object sender, EventArgs e)
        {
            SumPrice += 100000;
            ExcessPrice = SumPrice - PayPrice;
            load();
        }

        private void btnAdd50k_Click(object sender, EventArgs e)
        {
            SumPrice += 50000;
            ExcessPrice = SumPrice - PayPrice;
            load();
        }

        private void btnAdd20k_Click(object sender, EventArgs e)
        {
            SumPrice += 20000;
            ExcessPrice = SumPrice - PayPrice;
            load();
        }

        private void btnAdd10k_Click(object sender, EventArgs e)
        {
            SumPrice += 10000;
            ExcessPrice = SumPrice - PayPrice;
            load();
        }

        private void btnAdd5k_Click(object sender, EventArgs e)
        {
            SumPrice += 5000;
            ExcessPrice = SumPrice - PayPrice;
            load();
        }

        private void btnAdd2k_Click(object sender, EventArgs e)
        {
            SumPrice += 2000;
            ExcessPrice = SumPrice - PayPrice;
            load();
        }

        private void btnAdd1k_Click(object sender, EventArgs e)
        {
            SumPrice += 1000;
            ExcessPrice = SumPrice - PayPrice;
            load();
        }

        private void btnAddFullMoney_Click(object sender, EventArgs e)
        {
            SumPrice = PayPrice;
            ExcessPrice = SumPrice - PayPrice;
            load();
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
             if (SumPrice - PayPrice >= 0)
             {
                 int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(t.ID);
                 int discount = (int)nmDiscount.Value;

                 double totalPrice = Convert.ToDouble(lbTotalPrice.Text.Split(',')[0]);
                 double finalTotaoPrice = totalPrice - (totalPrice / 100) * discount;

                 if (idBill != -1)
                 {
                     if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\n Tổng tiền - (Tổng tiền /100)xGiảm giá(%)\n=>{1}-({1} / 100) x {2}% = {3}", t.Name, totalPrice, discount, finalTotaoPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                     {
                        p.Document = this.printDocument;
                        p.ShowDialog();
                        BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotaoPrice);
                         this.Close();
                     }
                 }
             }
             else
             {
                 MessageBox.Show("Số tiền thanh toán chưa đủ !");
             }

            /*p.Document = this.printDocument;
            p.ShowDialog();*/
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            nmDiscount.Value = 0;
            PayPrice = TotalPrice;
            SumPrice = 0;
            ExcessPrice = 0;
            load();
        }

        void load()
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            lbPayPrice.Text = PayPrice.ToString("c", culture);
            lbSumMoney.Text = SumPrice.ToString("c", culture);
            lbExcessMoney.Text = ExcessPrice.ToString("c", culture);
        }

        private void nmDiscount_ValueChanged(object sender, EventArgs e)
        {
            int discount = Convert.ToInt32(nmDiscount.Value);
            PayPrice = TotalPrice - (TotalPrice * discount) / 100;
            ExcessPrice = SumPrice - PayPrice;
            load();
        }
    }
}
