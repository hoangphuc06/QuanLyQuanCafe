﻿using System;
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
            this.ID = id;
            this.Name = name;
            this.CategoryID = categoryid;
            this.Price = price;
            this.Active = active;
        }
        public Food(DataRow row)
        {
            this.ID = (int)row["ID_Food"];
            this.Name = row["NameFood"].ToString();
            this.CategoryID = (int)row["ID_FoodCategory"];
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
            this.Active = (int)row["Active"];
        }
        private int ID;

        private string Name;

        private int CategoryID;

        private float Price;

        private int active;

        public int iD
        {
            get { return ID; }
            set { ID = value; }
        }
        public int categoryid
        {
            get { return CategoryID; }
            set { CategoryID = value; }
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

        public int Active { get => active; set => active = value; }
    }
}
