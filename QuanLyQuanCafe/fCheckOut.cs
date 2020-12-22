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
//using System.Drawing;
using iTextSharp.text.pdf;

namespace QuanLyQuanCafe
{
    public partial class fCheckOut : Form
    {
        double TotalPrice = 0;
        double ExcessPrice = 0;
        double SumPrice = 0;
        double PayPrice = 0;
        Table t;
        Account ac;
        private PrintDialog printDialog;
        private PrintDocument printDocument;
        private PrintPreviewDialog p = new PrintPreviewDialog();

        public fCheckOut(Table table, Account account)
        {
            t = table;
            ac = account;
            InitializeComponent();
            LoadtotalPrice();
            PayPrice = TotalPrice;
            lbNameFood.Text = table.Name;
            load();
            ShowBill(table.ID);

            this.printDialog = new PrintDialog();
            this.printDocument = new PrintDocument();
            this.printDocument.PrintPage += new PrintPageEventHandler(this.printDocument_PrintPage);
        }


        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<QuanLyQuanCafe.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            double totalPrice = 0;
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
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            double fontHeight = font.GetHeight();

            int startX = 50;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("COFFEE SHOP", new Font("Cooper", 20), new SolidBrush(Color.Red), startX + 200, startY);
            offset = offset + (int)fontHeight + 10;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(t.ID);
            graphic.DrawString("ID Bill: ".PadRight(10) + idBill.ToString(), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;

            graphic.DrawString(t.Name, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;

            graphic.DrawString("Người thu tiền: ".PadRight(10) + ac.UserName, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;

            DateTime now = DateTime.Now;
            graphic.DrawString("Thời gian: ".PadRight(10) + now, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;

            graphic.DrawString("Địa chỉ: KP6, Linh Trung, Thủ Đức, TP.HCM", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 20;

            string top = "Sản phẩm".PadRight(20) + "SL".PadRight(10) + "Giá".PadRight(10) + "Thành tiền".PadRight(10);
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;

            foreach (ListViewItem item in lsvBill.Items)
            {
                string ten = item.SubItems[0].Text;
                string dongia = item.SubItems[2].Text;
                string slsp = item.SubItems[1].Text;
                string thanhtien = item.SubItems[3].Text;

                graphic.DrawString(ten, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(slsp, font, new SolidBrush(Color.Black), 270, startY + offset);
                graphic.DrawString(dongia, font, new SolidBrush(Color.Black), 360, startY + offset);
                graphic.DrawString(thanhtien, font, new SolidBrush(Color.Black), 470, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }

            offset = offset + 20;
            graphic.DrawString("Giảm giá: ".PadRight(30) + nmDiscount.Value.ToString() + "%", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)fontHeight + 5;
            graphic.DrawString("Tổng cộng: ".PadRight(30) + PayPrice.ToString("###,###"), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)fontHeight + 20;
            graphic.DrawString("Hẹn gặp lại quý khách !", font, new SolidBrush(Color.Black), startX + 200, startY + offset);

        }

        void LoadtotalPrice()
        {
            List<QuanLyQuanCafe.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(t.ID);

            foreach (QuanLyQuanCafe.DTO.Menu item in listBillInfo)
            {
                TotalPrice += item.TotalPrice;
            }

            lbTotalPrice.Text = TotalPrice.ToString();

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
                string idUser = ac.UserName;

                double totalPrice = Convert.ToDouble(lbTotalPrice.Text.Split(',')[0]);
                double finalTotaoPrice = totalPrice - (totalPrice / 100) * discount;

                if (idBill != -1)
                {
                    if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\n Tổng tiền - (Tổng tiền /100)xGiảm giá(%)\n=>{1}-({1} / 100) x {2}% = {3}", t.Name, totalPrice, discount, finalTotaoPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        p.Document = this.printDocument;
                        p.ShowDialog();
                        BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotaoPrice,idUser);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Số tiền thanh toán chưa đủ !");
            }

            //p.Document = this.printDocument;
            //p.ShowDialog();
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
            lbPayPrice.Text = PayPrice.ToString();
            txbSumMoney.Text = SumPrice.ToString();
            lbExcessMoney.Text = ExcessPrice.ToString();
        }

        private void nmDiscount_ValueChanged(object sender, EventArgs e)
        {
            int discount = Convert.ToInt32(nmDiscount.Value);
            PayPrice = TotalPrice - (TotalPrice * discount) / 100;
            ExcessPrice = SumPrice - PayPrice;
            load();
        }

        private void txbSumMoney_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbSumMoney.Text))
            {
                SumPrice = 0;
                ExcessPrice = SumPrice - PayPrice;
                lbExcessMoney.Text = ExcessPrice.ToString();
            }   
            else
            {
                SumPrice = Convert.ToDouble(txbSumMoney.Text);
                ExcessPrice = SumPrice - PayPrice;
                load();
            }    
        }
    }
}
