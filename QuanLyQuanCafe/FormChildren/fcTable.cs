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
    public partial class fcTable : Form
    {
        BindingSource tableList = new BindingSource();
        public fcTable()
        {
            InitializeComponent();
            load();
            //txbID.Enabled = false;
            //cbxTableStatus.Enabled = false;
        }

        void load()
        {
            dtgvTable.DataSource = tableList;
            LoadTableList();
            AddTableBinding();
        }

        void LoadTableList()
        {
            tableList.DataSource = TableDAO.Instance.LoadTableList();
        }

        void AddTableBinding()
        {
            txbID.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "iD", true, DataSourceUpdateMode.Never));
            txbNameTable.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "name", true, DataSourceUpdateMode.Never));
            cbxTableStatus.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "status", true, DataSourceUpdateMode.Never));
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            string name = txbNameTable.Text;
            int id = Convert.ToInt32(txbID.Text);
            if (TableDAO.Instance.UpdateTable(name,id))
            {
                MessageBox.Show("Sửa thành công !");
                LoadTableList();
            }
            else
            {
                MessageBox.Show("Sửa thất bại !");
            }    
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string name = txbNameTable.Text;
            if (TableDAO.Instance.InsertTable(name))
            {
                MessageBox.Show("Thêm thành công !");
                LoadTableList();
            }    
            else
            {
                MessageBox.Show("Thêm thất bại !");
            }    
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbID.Text);
            if (TableDAO.Instance.DeleteTable(id))
            {
                MessageBox.Show("Xóa thành công !");
                LoadTableList();
            }
            else
            {
                MessageBox.Show("Xóa thất bại !");
            }
        }
    }
}
