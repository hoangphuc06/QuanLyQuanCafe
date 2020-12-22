using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;
using System.Data.SqlClient;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe.FormChildren
{
    public partial class fcChart : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-2V5RLH6O\SQLEXPRESS01;Initial Catalog=QuanLyQuanCafe;Integrated Security=True");

        string CurrentMonth = DateTime.Now.ToString("MM");
        string CurrentYear = DateTime.Now.ToString("yyyyy");
        string CurrentDay = DateTime.Now.ToString("dd");

        string day, month, year;
        public fcChart()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            day = dateTimePicker1.Value.ToString("dd");
            month = dateTimePicker1.Value.ToString("MM");
            year = dateTimePicker1.Value.ToString("yyyy");

            DoanhSoBanHang();
            ChartMoneydaybydate();
            TopFood();
            lbChart.Text = "Biểu đồ tháng " + month + "/" + year;
        }

        private void TopFood()
        {
            connect.Open();
            string query = "select top(1) f.ID_Food from Food f, Bill b, BillInfo bi where b.ID_Bill = bi.ID_BillInfo and bi.ID_Food = f.ID_Food and MONTH(b.DateCheckOut) = " + month + " and YEAR(b.DateCheckOut) = " + year +  " group by f.ID_Food order by sum(bi.count) desc";
            SqlCommand cmd = new SqlCommand(query,connect);
            var id = (cmd.ExecuteScalar());
            
            if (id == null)
            {
                picFood.Image = null;

                lbIDFood.Text = "ID Food: ";
                lbIDFoodCategory.Text = "ID Category: ";
                lbFoodName.Text = "Tên: ";
                lbFoodPrice.Text = "Giá: ";
                
                connect.Close();
                return;
            }    
            else
            {
                int idfood = Convert.ToInt32(id);
                picFood.Image = FoodDAO.Instance.getimagebyid(idfood);

                lbIDFood.Text = "ID Food: " + idfood.ToString();
                lbIDFoodCategory.Text = "ID Category: " + FoodDAO.Instance.getidcategorybyid(idfood).ToString();
                lbFoodName.Text = "Tên: " + FoodDAO.Instance.getnamebyid(idfood);
                lbFoodPrice.Text = "Giá: " + FoodDAO.Instance.getpricebyid(idfood).ToString("###,###");
                
            }
            connect.Close();
        }

        private void DoanhSoBanHang()
        {
            connect.Open();

            SqlCommand cmdCountTongHDThangNay = new SqlCommand("select COUNT (distinct ID_Bill) from dbo.Bill where MONTH(DateCheckOut) = '" + month + "'", connect);
            SqlCommand cmdCountTongHDToday = new SqlCommand("select COUNT (distinct ID_Bill) from dbo.Bill where DAY(DateCheckOut) = DAY(GETDATE())", connect);
            SqlCommand cmdCountTongTienThangNay = new SqlCommand("select sum (totalPrice) from dbo.Bill where MONTH(DateCheckOut) = " + month , connect);
            SqlCommand cmdCountTienToday = new SqlCommand("select sum (totalPrice) from dbo.Bill where DAY(DateCheckOut) = DAY(GETDATE())", connect);

            var CountTongHD = (cmdCountTongHDThangNay.ExecuteScalar());
            var CountHDtoday = (cmdCountTongHDToday.ExecuteScalar());
            var CountTongTienThangNay = (cmdCountTongTienThangNay.ExecuteScalar());
            var CountTienToday = (cmdCountTienToday.ExecuteScalar());

            if (CountTongTienThangNay == DBNull.Value)
            {
                lbTongDoanhSo.Text = "0";
            }
            else
            {
                lbTongDoanhSo.Text = CountTongTienThangNay.ToString();
            }

            if (CountTienToday == DBNull.Value)
            {
                lbDoanhSoToday.Text = "Hôm nay: " + 0;
            }
            else
            {
                lbDoanhSoToday.Text = "Hôm nay: " + CountTienToday.ToString();
            }

            if (CountTongHD == DBNull.Value)
            {
                lbSumHD.Text = "0";
            }    
            else
            {
                lbSumHD.Text = CountTongHD.ToString();
            }

            if (CountHDtoday == DBNull.Value)
            {
                lbHDtoday.Text = "0";
            }
            else
            {
                lbHDtoday.Text = "Hôm nay: " + CountHDtoday.ToString();
            }

            

            connect.Close();
        }

        private void ChartMoneydaybydate()
        {
            chart1.Series["Thu nhập"].XValueType = ChartValueType.DateTime;

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM";
            DataSet ds = new DataSet();
            connect.Open();
            //SqlDataAdapter adapt = new SqlDataAdapter("SELECT CAST(HDtime AS DATE) AS Ngay,COUNT(value) as slsp, HDthanhtoan as tien FROM HoaDon CROSS APPLY STRING_SPLIT(HDmasp, ',') where MONTH(HDtime) = '"+ CurrentMonth + "' group by HDtime, HDthanhtoan ORDER BY HDtime", connect);
            SqlDataAdapter adapt = new SqlDataAdapter("select DAY(DateCheckOut) as [Ngày], sum(totalPrice) as [Tiền] from bill where MONTH(DateCheckOut) = " + month + " and YEAR(DateCheckOut) = " + year + " group by DAY(DateCheckOut) order by DAY(DateCheckOut)", connect);

            adapt.Fill(ds);
            chart1.DataSource = ds;
            //set the member of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Thu nhập"].XValueMember = "Ngày";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Thu nhập"].YValueMembers = "Tiền";
            chart1.Series["Thu nhập"].IsValueShownAsLabel = true;
            //ChartSlspDayByDay.Titles.Add("Salary Chart");
            connect.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            load();
        }
    }
}
