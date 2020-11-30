using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe.DTO
{
    class Food
    {
        public Food(int id, string name, int categoryId, float price)
        {
            this.ID = id;
            this.Name = name;
            this.CategoryID = categoryid;
            this.Price = price;
        }
        public Food(DataRow row)
        {
            this.ID = (int)row["ID_Food"];
            this.Name = row["NameFood"].ToString();
            this.CategoryID = (int)row["ID_FoodCategory"];
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
        }
        private int ID;

        private string Name;

        private int CategoryID;

        private float Price;

        public int iD
        {
            get { return ID; }
            set { ID = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public float price
        {
            get { return Price; }
            set { Price = value; }
        }
        public int categoryid
        {
            get { return CategoryID; }
            set { CategoryID = value; }
        }
    }
}
