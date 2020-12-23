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
    public partial class fcCategory : Form
    {
        BindingSource categoryList = new BindingSource();
        public fcCategory()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            dtgvCategory.DataSource = categoryList;
            LoadListCategory();
            AddCategoryBinding();
        }

        void LoadListCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }

        void AddCategoryBinding()
        {
            txbCategoryID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "iD", true, DataSourceUpdateMode.Never));
            txbCategoryName.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "name", true, DataSourceUpdateMode.Never));
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;
            int id = Convert.ToInt32(txbCategoryID.Text);
            CategoryDetails f = new CategoryDetails();
            f.LoadCategory(id, name);
            f.ShowDialog();
            if (f.CategoryName != null && f.IsChannged(name))
            {
                if (CategoryDAO.Instance.UpdateCategory(f.CategoryName, f.ID))
                {
                    MessageBox.Show("Sửa thành công !");
                    LoadListCategory();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại !");
                }
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {         
            CategoryDetails f = new CategoryDetails();
            f.ShowDialog();
            if (f.CategoryName != null && f.IsAdd())
            {
                string name = f.CategoryName;
                if (CategoryDAO.Instance.InsertCategory(name))
                {
                    MessageBox.Show("Thêm thành công !");
                    LoadListCategory();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm !");
                }
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbCategoryID.Text);
            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xóa thành công !");
                LoadListCategory();
            }
            else
            {
                MessageBox.Show("Xóa thất bại !");
            }
        }
    }
}
