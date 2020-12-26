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
        public Food(int id, string name, int categoryId, float price, int active)
        {
            this.iD = id;
            this.name = name;
            this.CategoryiD = categoryId;
            this.Price = price;
            this.Active = active;
        }
        public Food(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.name = row["Name"].ToString();
            this.CategoryiD = (int)row["CategoryID"];
            this.price = (float)Convert.ToDouble(row["Price"].ToString());
            this.Active = (int)row["Active"];
        }
        private int iD;

        private string name;

        private int CategoryiD;

        private float price;

        private int active;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public int CategoryID
        {
            get { return CategoryiD; }
            set { CategoryiD = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Active { get => active; set => active = value; }
    }
}
