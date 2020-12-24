using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe
{
    public partial class fOrderFood : Form
    {
        private Table t;
        public fOrderFood(Table table)
        {
            t = table;
            InitializeComponent();
            LoadCategory();
            ShowBill(t.ID);
            lbNameFood.Text = table.Name;
            
        }
        void LoadCategory()
        {
            if (CategoryDAO.Instance.GetCountCategoryActive1() == 0)
            {
                btnAdd.Enabled = false;
                btnSubtract.Enabled = false;
            }
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory(1);
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            if (CategoryDAO.Instance.GetCountFoodinCategory(id) == 0)
            {
                cbFood.Text = null;
                pictureBox1.Image = null;
                btnAdd.Enabled = false;
                btnSubtract.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
                btnSubtract.Enabled = true;
            }

            LoadFoodListByCategoryID(id);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(t.ID);
            int foodID = (cbFood.SelectedItem as Food).iD;
            int count = (int)nmFoodCount.Value;

            string query = "select count from dbo.BillInfo as a,dbo.Bill as b Where a.ID_BillInfo=b.ID_Bill and status=0 and b.ID_TableFood= " + t.ID + " AND ID_Food= " + foodID;
            object i = DataProvider.Instance.ExecuteScalar(query);
            int a;
            if (i == null)
                a = 0;
            else
                 a=int.Parse(i.ToString());

            if (a > 0 || a + nmFoodCount.Value > 0)
            {
                if (idBill == -1)
                {
                    BillDAO.Instance.InsertBill(t.ID);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIdBill(), foodID, count);

                }
                else
                {
                    BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
                }

                ShowBill(t.ID);
                
            }

        }

      
            void ShowBill(int id)
            {
                lsvBill.Items.Clear();
                List<QuanLyQuanCafe.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
                float totalPrice = 0;
                foreach (QuanLyQuanCafe.DTO.Menu item in listBillInfo)
                {
                    ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                    lsvItem.SubItems.Add(item.Count.ToString());
                    lsvItem.SubItems.Add(item.Price.ToString());
                    lsvItem.SubItems.Add(item.TotalPrice.ToString());
                    totalPrice += item.TotalPrice;
                    lsvBill.Items.Add(lsvItem);
                }

            }

        

        private void fOrderFood_FormClosed(object sender, FormClosedEventArgs e)
        {
            BillDAO.Instance.DeleteBillByTableID(t.ID);
        }

        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;
            Food selected = cb.SelectedItem as Food;
            id = selected.iD;

            pictureBox1.Image = FoodDAO.Instance.getimagebyid(id);

            nmFoodCount.Value = 1;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(t.ID);
            int foodID = (cbFood.SelectedItem as Food).iD;
            int count = -(int)nmFoodCount.Value;

            string query = "select count from dbo.BillInfo as a,dbo.Bill as b Where a.ID_BillInfo=b.ID_Bill and status=0 and b.ID_TableFood= " + t.ID + " AND ID_Food= " + foodID;
            object i = DataProvider.Instance.ExecuteScalar(query);
            int a;
            if (i == null)
            {
                a = 0;
                return;
            }      
            else
                a = int.Parse(i.ToString());

            if (a > 0 || a + nmFoodCount.Value > 0)
            {
                if (idBill == -1)
                {
                    BillDAO.Instance.InsertBill(t.ID);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIdBill(), foodID, count);

                }
                else
                {
                    BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
                }

                ShowBill(t.ID);

            }
        }

        private void cbCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbFood_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
