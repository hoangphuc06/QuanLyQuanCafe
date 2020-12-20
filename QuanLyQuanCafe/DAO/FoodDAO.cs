using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DTO;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;

namespace QuanLyQuanCafe.DAO
{
    class FoodDAO
    {
        public static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }
        private FoodDAO() { }

        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();
            string query = "select * from Food where ID_FoodCategory = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();
            string query = "select * from Food ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public bool InsertFood(string name, int categoryid, float price)
        {
            string query = string.Format("Insert into dbo.Food(NameFood,ID_FoodCategory,Price) values (N'{0}',{1},{2})", name, categoryid, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateFood(string name, int categoryid, float price, int id)
        {
            string query = string.Format("update dbo.Food set NameFood = N'{0}', ID_FoodCategory = {1}, Price = {2} where ID_Food = {3}", name, categoryid, price, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteFood(int id)
        {
            string query = string.Format("delete dbo.Food where ID_Food = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool GetImageByID(int id)
        {
            string query = string.Format("select image from dbo.Food where ID_Food = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<Food> SearchFoodByName(string name)
        {
            List<Food> list = new List<Food>();
            string query = string.Format("select * from dbo.Food where dbo.GetUnsignString(NameFood) like N'%' + dbo.GetUnsignString(N'{0}')+ '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        Image ByteArrayToImage(byte[] img)
        {
            MemoryStream m = new MemoryStream(img);
            return Image.FromStream(m);
        }
        public bool UpdateFoodImage(byte[] img, string name)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-FLVOAAN8;Initial Catalog=QuanLyQuanCafe;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Food set Image_Food = @hinh where NameFood = @ten", conn);
            cmd.Parameters.Add("@ten", name);
            cmd.Parameters.Add("@hinh", img);
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result > 0;
        }
        public Image getimagebyid(int id)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-FLVOAAN8;Initial Catalog=QuanLyQuanCafe;Integrated Security=True");
            conn.Open();
            string Sqlcmd = string.Format("select * from Food where ID_Food = {0}", id);
            SqlDataAdapter cmd = new SqlDataAdapter(Sqlcmd, conn);
            DataTable mtb = new DataTable();
            cmd.Fill(mtb);
            Image img = ByteArrayToImage((byte[])mtb.Rows[0]["Image_Food"]);
            conn.Close();
            return img;
        }
    }
}
