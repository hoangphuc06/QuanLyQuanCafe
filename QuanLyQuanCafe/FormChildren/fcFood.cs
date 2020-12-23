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
using System.IO;

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
            //LoadCategoryIntoCombobox(cbxFoodCategory);
            AddFoodBinding();
        }
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        //void LoadCategoryIntoCombobox(ComboBox cb)
        //{
        //    cb.DataSource = CategoryDAO.Instance.GetListCategory();
        //    cb.DisplayMember = "name";
        //}

        void AddFoodBinding()
        {
            lbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "iD", true, DataSourceUpdateMode.Never));
            lbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            lbFoodCategory.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "categoryid", true, DataSourceUpdateMode.Never));
            lbFoodPrice.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        //private void txbFoodName_TextChanged(object sender, EventArgs e)
        //{
        //    if (dtgvFood.SelectedCells.Count > 0 && dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value != null)
        //    {
        //        int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;
        //        Category category = CategoryDAO.Instance.GetCategoryByID(id);
        //        cbxFoodCategory.SelectedItem = category;
        //        int Index = -1, i = 0;
        //        foreach (Category item in cbxFoodCategory.Items)
        //        {
        //            if (item.ID == category.ID)
        //            {
        //                Index = i;
        //                break;
        //            }
        //            i++;
        //        }
        //        cbxFoodCategory.SelectedIndex = Index;

        //    }
        //}

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            FoodDetails f = new FoodDetails();
            f.ShowDialog();
            if (f.FoodName != null && f.IsAdd())
            {
                string name = f.FoodName;
                int categoryid = f.Category;
                float price = f.Price;
                byte[] image = f.FoodImage;
                if (FoodDAO.Instance.InsertFood(name, categoryid, price))
                {
                    FoodDAO.Instance.UpdateFoodImage(image, name);
                    MessageBox.Show("Thêm thành công");
                    LoadListFood();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm!");
                }
            }
            this.Show();

        }
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        private void btnEditFood_Click(object sender, EventArgs e)
        {
            FoodDetails f = new FoodDetails();
            int fid = Convert.ToInt32(lbFoodID.Text);
            string fname = lbFoodName.Text;
            int fcategory = Convert.ToInt32(lbFoodCategory.Text);
            float fprice = (float)Convert.ToInt32(lbFoodPrice.Text);
            byte[] img = ImageToByteArray( FoodDAO.instance.getimagebyid(fid));
            f.LoadFood(fid, fname, fcategory, fprice);
            f.ShowDialog();
            if (f.IsChannged(fname, fcategory, fprice,img) && f.FoodName != null)
            {
                fname = f.FoodName;
                fcategory = f.Category;
                fprice = f.Price;
                byte[] image = f.FoodImage;
                if (FoodDAO.Instance.UpdateFood(fname, fcategory, fprice, fid))
                {
                    FoodDAO.Instance.UpdateFoodImage(image, fname);
                    MessageBox.Show("Sửa thành công");
                    LoadListFood();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                }
            }
            this.Show();
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lbFoodID.Text);
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

        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbFindFoodName_TextChanged(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txbFindFoodName.Text);
        }

        private void dtgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvFood.CurrentCell.RowIndex;
            int b = (int)dtgvFood.Rows[r].Cells[0].Value;
            ptbFoodImage.Image = FoodDAO.Instance.getimagebyid(b);
        }
    }
}
