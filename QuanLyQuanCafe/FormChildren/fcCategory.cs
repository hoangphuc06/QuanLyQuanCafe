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
            lbCategoryID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "iD", true, DataSourceUpdateMode.Never));
            lbCategoryName.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "name", true, DataSourceUpdateMode.Never));
            lbActive.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Active", true, DataSourceUpdateMode.Never));
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string name = lbCategoryName.Text;
            int id = Convert.ToInt32(lbCategoryID.Text);
            CategoryDetails f = new CategoryDetails();
            f.LoadCategory(id, name);
            f.ShowDialog();
            if (f.CategoryName != null && f.IsChannged(name))
            {
                if (CategoryDAO.Instance.UpdateCategory(f.CategoryName, id))
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
            int id = Convert.ToInt32(lbCategoryID.Text);
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

        private void btnActive_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lbCategoryID.Text);
            int active = Convert.ToInt32(lbActive.Text);
            if (active == 1)
            {
                active = 0;
            }
            else
            {
                active = 1;
            }
            if (CategoryDAO.Instance.ChangeActive(id, active))
            {
                MessageBox.Show("Đổi trạng thái thành công !");
                LoadListCategory();
            }
            else
            {
                MessageBox.Show("Đổi trạng thái thất bại !");
            }
        }
    }
}
