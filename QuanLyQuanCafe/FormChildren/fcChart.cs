using System;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.FormChildren
{
    public partial class fcChart : Form
    {
        public fcChart()
        {
            InitializeComponent();
            Load_ChartYear();
        }
        private void Load_ChartYear()
        {

            DateTime today = DateTime.Now;

            chart1.DataSource = DataProvider.Instance.ExecuteQuery("select  MONTH(DateCheckOut) AS month , sum(totalPrice) as sum from dbo.Bill where Year(DateCheckOut) = " + today.Year + " group  by MONTH(DateCheckOut)");
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh số";

            chart1.Series["Doanh Thu"].XValueMember = "month";
            chart1.Series["Doanh Thu"].YValueMembers = "sum";

            chart1.Series["Doanh Thu"]["DrawingStyle"] = "Cylinder";
        }
        private void Load_ChartDay(DateTime dtp)
        {


            chart1.DataSource = DataProvider.Instance.ExecuteQuery("select  Datepart(HH,DateCheckIn) AS hour , sum(totalPrice) as sum from dbo.Bill where Year(DateCheckIn) = " + dtp.Year + " And Month (DateCheckIn)=" + dtp.Month + " And Day(DateCheckIn)=" + dtp.Day + " group  by Datepart(HH,DateCheckIn)");
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Giờ";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh số";
            chart1.Series["Doanh Thu"]["DrawingStyle"] = "Cylinder";
            chart1.Series["Doanh Thu"].XValueMember = "hour";
            chart1.Series["Doanh Thu"].YValueMembers = "sum";
        }
        private void Load_ChartMonth(DateTime dtp)
        {


            chart1.DataSource = DataProvider.Instance.ExecuteQuery("select  Day(DateCheckIn) AS day , sum(totalPrice) as sum from dbo.Bill where Year(DateCheckIn) = " + dtp.Year + " And Month(DateCheckIn)=" + dtp.Month + " group  by Day(DateCheckIn)");
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh số";
            chart1.Series["Doanh Thu"]["DrawingStyle"] = "Cylinder";
            chart1.Series["Doanh Thu"].XValueMember = "day";
            chart1.Series["Doanh Thu"].YValueMembers = "sum";
        }

        private void cbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtp.Visible = false;
            if (cbOptions.Text == "Năm")
                Load_ChartYear();
            if (cbOptions.Text == "Ngày")
            {
                dtp.Visible = true;
                Load_ChartDay(dtp.Value);
            }

            if (cbOptions.Text == "Tháng")
            {
                dtp.Visible = true;
                Load_ChartMonth(dtp.Value);

            }
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            if (cbOptions.Text == "Ngày")
                Load_ChartDay(dtp.Value);
            if (cbOptions.Text == "Tháng")
                Load_ChartMonth(dtp.Value);
        }

        private void btnColumn_Click(object sender, EventArgs e)
        {
            btnColumn.Visible = false;
            btnLine.Visible = true;

            chart1.Series["Doanh Thu"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

        }


       
        
        private void btnLine_Click(object sender, EventArgs e)
        {
            btnLine.Visible = false;
            btnColumn.Visible = true;
            chart1.Series["Doanh Thu"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

        }
    }
}
