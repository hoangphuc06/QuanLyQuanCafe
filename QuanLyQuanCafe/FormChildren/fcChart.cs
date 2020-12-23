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

        string CurrentMonth;
        string CurrentYear;
        string CurrentDay;

        string day, month, year;
        public fcChart()
        {
            InitializeComponent();
            loadCurrent();
            load();
        }

        void loadCurrent()
        {
            CurrentMonth = DateTime.Now.ToString("MM");
            CurrentYear = DateTime.Now.ToString("yyyy");
            CurrentDay = DateTime.Now.ToString("dd");
        }

        void load()
        {
            day = dateTimePicker1.Value.ToString("dd");
            month = dateTimePicker1.Value.ToString("MM");
            year = dateTimePicker1.Value.ToString("yyyy");

            DoanhSoBanHang();
            ChartMoneydaybydate();
            TopFood();
            SanPham();
            lbChart.Text = "Biểu đồ tháng " + month + "/" + year;
        }

        private void SanPham()
        {
            connect.Open();

            SqlCommand cmdSoSPThang = new SqlCommand("select sum(Price*Amount) from Resources where YEAR(DayIn) = " + year + " and MONTH(DayIn) = " + month, connect);
            SqlCommand cmdSoSPToday = new SqlCommand("select sum(Price*Amount) from Resources where YEAR(DayIn) = " + year + " and MONTH(DayIn) = " + month + " and DAY(DayIn) = " + day, connect);

            var SoSPThang = (cmdSoSPThang.ExecuteScalar());
            var SoSPToday = (cmdSoSPToday.ExecuteScalar());

            if (SoSPThang == DBNull.Value)
            {
                lbSumSP.Text = "0";
            }
            else
            {
                lbSumSP.Text = SoSPThang.ToString();
            }

            if (SoSPToday == DBNull.Value)
            {
                if (day == CurrentDay && month == CurrentMonth && year == CurrentYear)
                {
                    lbSPtoday.Text = "Hôm nay: " + 0;
                }
                else
                {
                    lbSPtoday.Text = day + "/" + month + "/" + year + ": 0";
                }
            }
            else
            {
                if (day == CurrentDay && month == CurrentMonth && year == CurrentYear)
                {
                    lbSPtoday.Text = "Hôm nay: " + SoSPToday.ToString();
                }
                else
                {
                    lbSPtoday.Text = day + "/" + month + "/" + year + ": " + SoSPToday.ToString();
                }
            }

            connect.Close();
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
                lbCount.Text = "Số lượng: ";


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


                string query1 = "select top(1)  sum(bi.count) from Food f, Bill b, BillInfo bi where b.ID_Bill = bi.ID_BillInfo and bi.ID_Food = f.ID_Food and MONTH(b.DateCheckOut) = " + month + " and YEAR(b.DateCheckOut) = " + year + " group by f.ID_Food order by sum(bi.count) desc";
                SqlCommand cmd1 = new SqlCommand(query1, connect);
                var sl = (cmd1.ExecuteScalar());
                lbCount.Text = "Số lượng: " + sl.ToString();
            }
            connect.Close();
        }

        private void DoanhSoBanHang()
        {
            connect.Open();

            SqlCommand cmdCountTongHDThangNay = new SqlCommand("select COUNT (distinct ID_Bill) from dbo.Bill where MONTH(DateCheckOut) = '" + month + "' and YEAR(DateCheckOut) = " + year, connect);
            SqlCommand cmdCountTongHDToday = new SqlCommand("select COUNT (distinct ID_Bill) from dbo.Bill where DAY(DateCheckOut) = " + day + " and MONTH(DateCheckOut) = " + month + "and YEAR(DateCheckOut) = " + year, connect);
            SqlCommand cmdCountTongTienThangNay = new SqlCommand("select sum (totalPrice) from dbo.Bill where MONTH(DateCheckOut) = " + month + " and YEAR(DateCheckOut) = " + year, connect);
            SqlCommand cmdCountTienToday = new SqlCommand("select sum (totalPrice) from dbo.Bill where DAY(DateCheckOut) = " + day + " and MONTH(DateCheckOut) = " + month + "and YEAR(DateCheckOut) = " + year, connect);

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
                if (day == CurrentDay && month == CurrentMonth && year == CurrentYear)
                {
                    lbDoanhSoToday.Text = "Hôm nay: " + 0;
                }    
                else
                {
                    lbDoanhSoToday.Text = day + "/" + month + "/" + year + ": 0"; 
                }    
                
            }
            else
            {
                if (day == CurrentDay && month == CurrentMonth && year == CurrentYear)
                {
                    lbDoanhSoToday.Text = "Hôm nay: " + CountTienToday.ToString();
                }
                else
                {
                    lbDoanhSoToday.Text = day + "/" + month + "/" + year + ": " + CountTienToday.ToString();
                }
                
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
                if (day == CurrentDay && month == CurrentMonth && year == CurrentYear)
                {
                    lbHDtoday.Text = "Hôm nay: " + 0;
                }
                else
                {
                    lbHDtoday.Text = day + "/" + month + "/" + year + ": 0";
                }
            }
            else
            {
                if (day == CurrentDay && month == CurrentMonth && year == CurrentYear)
                {
                    lbHDtoday.Text = "Hôm nay: " + CountHDtoday.ToString();
                }
                else
                {
                    lbHDtoday.Text = day + "/" + month + "/" + year + ": " + CountHDtoday.ToString();
                }
            }

            

            connect.Close();
        }

        private void ChartMoneydaybydate()
        {
            chart1.Series["Thu nhập"].XValueType = ChartValueType.DateTime;

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd";
            DataSet ds = new DataSet();
            connect.Open();
            
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
