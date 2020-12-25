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
            string query = "select ID_Food as [ID], ID_FoodCategory as [Category ID] ,NameFood as [Tên Món],Price as [Giá],Active from Food where Active = 1 and ID_FoodCategory = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public DataTable GetListFood()
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListFood");
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
            
            int result = DataProvider.Instance.ExecuteNonQuery("update Food set Image_Food ="+ img+ " where NameFood = "+name);
       

            return result > 0;
        }
        public Image getimagebyid(int id)
        {
            
            DataTable mtb = DataProvider.Instance.ExecuteQuery("select * from Food where ID_Food ="+id);


            Image img = ByteArrayToImage((byte[])mtb.Rows[0]["Image_Food"]);
        
            return img;
        }

        public int getidcategorybyid(int id)
        {
            string query = string.Format("select ID_FoodCategory from Food where ID_Food = {0}", id);
            var v = DataProvider.Instance.ExecuteScalar(query);
            
            return Convert.ToInt32(v);
        }

        public string getnamebyid(int id)
        {
            string query = string.Format("select NameFood from Food where ID_Food = {0}", id);
            var v = DataProvider.Instance.ExecuteScalar(query);

            return v.ToString();
        }

        public int getpricebyid(int id)
        {
            string query = string.Format("select Price from Food where ID_Food = {0}", id);
            var v = DataProvider.Instance.ExecuteScalar(query);

            return Convert.ToInt32(v);
        }

        public DataTable getFoodofBillinMonth(string month, string year)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_getFoodofBillinMonth @MONTH , @YEAR", new object[] { month, year });
        }

        public DataTable getFoodofBillinDay(string month, string year, string day)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_getFoodofBillinDay @MONTH , @YEAR , @DAY", new object[] { month, year, day });
        }

        public bool ChangeActive(int id, int active)
        {
            string query = string.Format("update dbo.Food set Active = {0} where ID_Food = {1}", active.ToString(), id.ToString());
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
