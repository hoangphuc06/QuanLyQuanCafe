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
            



            var SoSPThang = DataProvider.Instance.ExecuteScalar("select sum(Price*Amount) from Resources where YEAR(DayIn) = " + year + " and MONTH(DayIn) = " + month);
            var SoSPToday = DataProvider.Instance.ExecuteScalar("select sum(Price*Amount) from Resources where YEAR(DayIn) = " + year + " and MONTH(DayIn) = " + month + " and DAY(DayIn) = " + day);

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

            
        }

        private void TopFood()
        {


            var id = DataProvider.Instance.ExecuteScalar("select top(1) f.ID_Food from Food f, Bill b, BillInfo bi where b.ID_Bill = bi.ID_BillInfo and bi.ID_Food = f.ID_Food and MONTH(b.DateCheckOut) = " + month + " and YEAR(b.DateCheckOut) = " + year + " group by f.ID_Food order by sum(bi.count) desc");
            
            if (id == null)
            {
                picFood.Image = null;

                lbIDFood.Text = "ID Food: ";
                lbIDFoodCategory.Text = "ID Category: ";
                lbFoodName.Text = "Tên: ";
                lbFoodPrice.Text = "Giá: ";
                lbCount.Text = "Số lượng: ";


               
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



                var sl = DataProvider.Instance.ExecuteScalar("select top(1)  sum(bi.count) from Food f, Bill b, BillInfo bi where b.ID_Bill = bi.ID_BillInfo and bi.ID_Food = f.ID_Food and MONTH(b.DateCheckOut) = " + month + " and YEAR(b.DateCheckOut) = " + year + " group by f.ID_Food order by sum(bi.count) desc");
                lbCount.Text = "Số lượng: " + sl.ToString();
            }
          
        }

        private void DoanhSoBanHang()
        {
   

           

            var CountTongHD = DataProvider.Instance.ExecuteScalar("select COUNT (distinct ID_Bill) from dbo.Bill where MONTH(DateCheckOut) = '" + month + "' and YEAR(DateCheckOut) = " + year);
            var CountHDtoday = DataProvider.Instance.ExecuteScalar("select COUNT (distinct ID_Bill) from dbo.Bill where DAY(DateCheckOut) = " + day + " and MONTH(DateCheckOut) = " + month + "and YEAR(DateCheckOut) = " + year);
            var CountTongTienThangNay = DataProvider.Instance.ExecuteScalar("select sum (totalPrice) from dbo.Bill where MONTH(DateCheckOut) = " + month + " and YEAR(DateCheckOut) = " + year);
            var CountTienToday = DataProvider.Instance.ExecuteScalar("select sum (totalPrice) from dbo.Bill where DAY(DateCheckOut) = " + day + " and MONTH(DateCheckOut) = " + month + "and YEAR(DateCheckOut) = " + year);

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

            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fDetails f = new fDetails(day, month, year);
            f.ShowDialog();
        }

        private void ChartMoneydaybydate()
        {
            chart1.Series["Thu nhập"].XValueType = ChartValueType.DateTime;

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd";
            DataTable ds = DataProvider.Instance.ExecuteQuery("select DAY(DateCheckOut) as [Ngày], sum(totalPrice) as [Tiền] from bill where MONTH(DateCheckOut) = " + month + " and YEAR(DateCheckOut) = " + year + " group by DAY(DateCheckOut) order by DAY(DateCheckOut)");
            
            
            
            chart1.DataSource = ds;
            //set the member of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Thu nhập"].XValueMember = "Ngày";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Thu nhập"].YValueMembers = "Tiền";
            chart1.Series["Thu nhập"].IsValueShownAsLabel = true;
            //ChartSlspDayByDay.Titles.Add("Salary Chart");
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            load();
        }

       
    }
}
