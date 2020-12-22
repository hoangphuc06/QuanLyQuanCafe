using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DTO;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe.FormChildren
{
    public partial class BillDetails : Form
    {
        int idBill;
        double total;
        string idTable, ngthu, ngvao, ngra, discount;

        public BillDetails(int a, string b, string c, string d, string e, string f, double g)
        {
            InitializeComponent();

            idBill = a;
            idTable = b;
            ngthu = c;
            ngvao = d;
            ngra = e;
            discount = f;
            total = g;

            ShowBill(a);
            load();
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<QuanLyQuanCafe.DTO.Menu> listBillInfo = MenuDAO.Instance.GetBillMenuByID(id);
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

        void load()
        {
            lbIdBill.Text = "ID Bill: " + idBill.ToString(); ;
            lbIdTable.Text = "ID Bàn: " + idTable;
            lbNgThu.Text = "Người thu: " + ngthu;
            lbNgVao.Text = "Ngày vào: " + Convert.ToDateTime(ngvao).ToShortDateString();
            lbNgRa.Text = "Ngày ra: " + Convert.ToDateTime(ngra).ToShortDateString();
            lbDiscount.Text = "Giảm giá: " + discount + "%";
            lbTotal.Text = "Tổng cộng: " + total.ToString("###,###.###") + " VNĐ";
        }
    }
}
