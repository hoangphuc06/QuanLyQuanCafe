﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Table
    {
        public Table(int id, string name, string status, int active)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
            this.Active = active;
        }

        public Table(DataRow row)
        {
            this.ID = (int)row["ID_TableFood"];
            this.Name = row["NameTable"].ToString();
            this.Status = row["StatusTable"].ToString();
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
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

       

        private int active;

        public int Active { get => active; set => active = value; }

    }
}
