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

namespace QuanLyQuanCafe.FormChildren
{
    public partial class fDetails : Form
    {
        public fDetails(string d, string m, string y)
        {
            InitializeComponent();
            dtgvMonth.DataSource = FoodDAO.Instance.getFoodofBillinMonth(m, y);
            dtgvDay.DataSource = FoodDAO.Instance.getFoodofBillinDay(m, y, d);
            label1.Text = "Số lượng sản phẩm bán được tháng " + m + "/" + y;
            label2.Text = "Số lượng sản phẩm bán được ngày " + d + "/" + m + "/" + y;
        }
    }
}
