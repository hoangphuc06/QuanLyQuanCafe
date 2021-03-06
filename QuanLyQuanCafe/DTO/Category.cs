﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Category
    {
        public Category(int id, string name, int active)
        {
            this.ID = id;
            this.Name = name;
            this.Active = active;
        }

        public Category(DataRow row)
        {
            this.ID = (int)row["ID_FoodCategory"];
            this.name = row["name"].ToString();
            this.Active = (int)row["Active"];

        }
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        

        private int active;
        public int Active { get => active; set => active = value; }


    }
}
