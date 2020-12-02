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
    public partial class fcFood : Form
    {
        BindingSource foodList = new BindingSource();
        public fcFood()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            dtgvFood.DataSource = foodList;
            LoadListFood();
            LoadCategoryIntoCombobox(cbxFoodCategory);
            AddFoodBinding();
        }
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "name";
        }

        void AddFoodBinding()
        {
            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "iD", true, DataSourceUpdateMode.Never));
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbFoodPrice.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        private void txbFoodName_TextChanged(object sender, EventArgs e)
        {
            if (dtgvFood.SelectedCells.Count > 0)
            {
                int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;
                Category category = CategoryDAO.Instance.GetCategoryByID(id);
                cbxFoodCategory.SelectedItem = category;
                int Index = -1, i = 0;
                foreach (Category item in cbxFoodCategory.Items)
                {
                    if (item.ID == category.ID)
                    {
                        Index = i;
                        break;
                    }
                    i++;
                }
                cbxFoodCategory.SelectedIndex = Index;

            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryid = (cbxFoodCategory.SelectedItem as Category).ID;
            float price = Convert.ToInt32(txbFoodPrice.Text);
            if (FoodDAO.Instance.InsertFood(name, categoryid, price))
                {
                    MessageBox.Show("Thêm thành công");
                    LoadListFood();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm!");
                }

        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryid = (cbxFoodCategory.SelectedItem as Category).ID;
            float price = Convert.ToInt32(txbFoodPrice.Text);
            int id = Convert.ToInt32(txbFoodID.Text);
            if (FoodDAO.Instance.UpdateFood(name, categoryid, price, id))
            {
                MessageBox.Show("Sửa thành công");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbFoodID.Text);
            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xoá thành công");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
            LoadListFood();
        }
    }
}
