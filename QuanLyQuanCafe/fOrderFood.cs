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
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
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
            int foodID = (cbFood.SelectedItem as Food).iD;
            string query1 = "select count from dbo.BillInfo as a,dbo.Bill as b Where a.ID_BillInfo=b.ID_Bill and status=0 and b.ID_TableFood= " + t.ID + " AND ID_Food= " + foodID;
            object b = DataProvider.Instance.ExecuteScalar(query1);
            if (b == null)
            {
                string query2 = "delete from dbo.BillInfo where ID_BillInfo = (select ID_Bill from dbo.Bill where ID_TableFood = "+t.ID+" and status = 0 )";
                string query3 = "delete from dbo.Bill where ID_TableFood=" + t.ID + "and status=0";
                string query4 = "update dbo.TableFood set StatusTable=N'Trống' where ID_TableFood=" + t.ID;
                DataProvider.Instance.ExecuteNonQuery(query2);
                DataProvider.Instance.ExecuteNonQuery(query3);
                DataProvider.Instance.ExecuteNonQuery(query4);
            }
        }
    }
}
