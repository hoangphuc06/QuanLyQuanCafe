using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
    class CategoryDAO
    {
        public static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }
        private CategoryDAO() { }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string query = "select * from FoodCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }
            return list;
        }

        public List<Category> GetListCategory(int active)
        {
            List<Category> list = new List<Category>();
            string query = "select * from FoodCategory where Active = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }
            return list;
        }

        public Category GetCategoryByID(int id)
        {
            Category category = null;
            string query = "select * from FoodCategory where ID_FoodCategory =" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);

            }
            return category;
        }

        public bool InsertCategory(string name)
        {
            string query = string.Format("Insert into dbo.FoodCategory(name,active) values (N'{0}', 1)", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCategory(string name, int id)
        {
            string query = string.Format("update dbo.FoodCategory set name = N'{0}' where ID_FoodCategory = {1}", name, id.ToString());
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteCategory(int id)
        {
            string query = string.Format("delete dbo.FoodCategory where ID_FoodCategory = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public int GetCountFoodinCategory(int id)
        {
            var n = DataProvider.Instance.ExecuteScalar("SELECT COUNT(ID_Food) FROM Food f WHERE f.Active = 1 and f.ID_FoodCategory = " + id.ToString());
            return Convert.ToInt32(n);
        }

        public int GetCountCategoryActive1()
        {
            var n = DataProvider.Instance.ExecuteScalar("SELECT COUNT(ID_FoodCategory) FROM FoodCategory f WHERE f.Active = 1");
            return Convert.ToInt32(n);
        }

        public bool ChangeActive(int id, int active)
        {
            string query = string.Format("update dbo.FoodCategory set Active = {0} where ID_FoodCategory = {1}", active.ToString(), id.ToString());
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
