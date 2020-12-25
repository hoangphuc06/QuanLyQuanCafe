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

        void LoadTableList(int active)
        {
            tableList.DataSource = TableDAO.Instance.LoadTableList(active);
        }

        void AddTableBinding()
        {
            lbID.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "ID", true, DataSourceUpdateMode.Never));
            lbNameTable.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Tên Bàn", true, DataSourceUpdateMode.Never));
            lbTableStatus.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Trạng Thái", true, DataSourceUpdateMode.Never));
            lbActive.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Active", true, DataSourceUpdateMode.Never));
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            string name = lbNameTable.Text;
            int id = Convert.ToInt32(lbID.Text);
            string status = lbTableStatus.Text;
            TableDetails f = new TableDetails();
            f.Loadtable(id,name,status);
            f.ShowDialog();
            if (f.TableName != null)
            {
                if (TableDAO.Instance.UpdateTable(f.TableName, id))
                {
                    MessageBox.Show("Sửa thành công !");
                    LoadTableList();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại !");
                }
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            TableDetails f = new TableDetails();
            f.ShowDialog();          
            if (f.TableName != null && f.IsAdd())
            {
                string name = f.TableName;
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
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {

        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lbID.Text);
            int active = Convert.ToInt32(lbActive.Text);
            if (active == 1)
            {
                active = 0;
            }
            else
            {
                active = 1;
            }
            if (TableDAO.Instance.ChangeActive(id, active))
            {
                MessageBox.Show("Đổi trạng thái thành công !");
                LoadTableList();
            }
            else
            {
                MessageBox.Show("Đổi trạng thái thất bại !");
            }
        }
    }
}
