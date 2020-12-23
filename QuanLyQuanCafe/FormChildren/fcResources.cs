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
    public partial class fcResources : Form
    {
        bool isAdd;
        BindingSource ResourceList = new BindingSource();
        public fcResources()
        {
            InitializeComponent();
            load();
        }
        string day, month, year;
        void load()
        {
            day = dtpkDate.Value.ToString("dd");
            month = dtpkDate.Value.ToString("MM");
            year = dtpkDate.Value.ToString("yyyy");
            dtgvResource.DataSource = ResourceList;
            LoadListResource();
            //ListMonthResoures();
            AddFoodBinding();

        }
        void LoadListResource()
        {
            ResourceList.DataSource = ResourceDAO.Instance.GetListResource();
        }
        void AddFoodBinding()
        {
            txbID.DataBindings.Add(new Binding("Text",dtgvResource.DataSource,"ID",true,DataSourceUpdateMode.Never));
            txbName.DataBindings.Add(new Binding("Text", dtgvResource.DataSource, "RName", true, DataSourceUpdateMode.Never));
            txbSoLuong.DataBindings.Add(new Binding("Text", dtgvResource.DataSource, "Amount", true, DataSourceUpdateMode.Never));
            txbPrice.DataBindings.Add(new Binding("Text", dtgvResource.DataSource, "Price", true, DataSourceUpdateMode.Never));
            txbDonvi.DataBindings.Add(new Binding("Text", dtgvResource.DataSource, "Unit", true, DataSourceUpdateMode.Never));
            txbDay.DataBindings.Add(new Binding("Text", dtgvResource.DataSource, "Dayin", true, DataSourceUpdateMode.Never));
            txbNguoiNhap.DataBindings.Add(new Binding("Text", dtgvResource.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txbID.Enabled = true;
            txbName.Enabled = true;
            txbPrice.Enabled = true;
            txbDay.Text = DateTime.Now.ToShortDateString();
            txbDonvi.Enabled = true;
            txbSoLuong.Enabled = true;
            txbNguoiNhap.Enabled = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            isAdd = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                string id = txbID.Text;
                string rname = txbName.Text;
                float price = Convert.ToInt32(txbPrice.Text);
                string dayin = DateTime.Now.ToShortDateString();
                string unit = txbDonvi.Text;
                int amount = Convert.ToInt32(txbSoLuong.Text);
                string username = txbNguoiNhap.Text;
                if (ResourceDAO.Instance.InsertResource(id, rname, price, dayin, unit, amount, username))
                {
                    MessageBox.Show("Nhập thành công");
                    LoadListResource();
                }
            }
            else
            {
                string id = txbID.Text;
                string rname = txbName.Text;
                float price = Convert.ToInt32(txbPrice.Text);
                string dayin = DateTime.Now.ToShortDateString();
                string unit = txbDonvi.Text;
                int amount = Convert.ToInt32(txbSoLuong.Text);
                string username = txbNguoiNhap.Text;
                if (ResourceDAO.Instance.UpdateResource(id, rname, price, dayin, unit, amount, username))
                {
                    MessageBox.Show("Cập nhật thành công");
                    LoadListResource();
                }
            }
                txbID.Enabled = false;
                txbName.Enabled = false;
                txbPrice.Enabled = false;
                txbDay.Enabled = false;
                txbDonvi.Enabled = false;
                txbSoLuong.Enabled = false;
                txbNguoiNhap.Enabled = false;
                btnAdd.Enabled = true;
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txbID.Enabled = false;
            txbName.Enabled = true;
            txbPrice.Enabled = true;
            txbDay.Enabled = true;
            txbDonvi.Enabled = true;
            txbSoLuong.Enabled = true;
            txbNguoiNhap.Enabled = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            isAdd = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            if(ResourceDAO.Instance.DeleteResource(id))
            {
                MessageBox.Show("Xóa thành công");
                ListMonthResoures();
            }    
        }

        void ListMonthResoures()
        {

            ResourceList.DataSource =  ResourceDAO.Instance.GetResourceByMonth(dtpkDate.Value.Month, dtpkDate.Value.Year);
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            ListMonthResoures();
        }
    }
}
