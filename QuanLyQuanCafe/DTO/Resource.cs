using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe.DTO
{
    class Resource
    {
        private string id;

        private string nName;

        private int amount;

        private float price;
        private DateTime? dayin;
        private string unit;
        private string displayname;

        public Resource(string fid,string fname,int famount,float fprice,DateTime fdayin,string funit,string fdisplayname)
        {
            this.id = fid;
            this.nName = fname;
            this.amount = famount;
            this.price = fprice;
            this.dayin = fdayin;
            this.unit = funit;
            this.displayname = fdisplayname;
        }
        public Resource(DataRow row)
        {
            this.id = row["ID_Resource"].ToString();
            this.nName = row["RName"].ToString();
            this.amount = (int)row["Amount"];
            this.price = (float)Convert.ToDouble(row["Price"]);
            this.unit = row["Unit"].ToString();
            var datein = row["DayIn"];
            if(!string.IsNullOrEmpty(datein.ToString()))
                this.dayin = (DateTime?)datein;
            this.displayname = row["UserName"].ToString();
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }      
        public string RName
        {
            get { return nName; }
            set { nName = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public DateTime? Dayin { get => dayin; set => dayin = value; }
        public string Unit { get => unit; set => unit = value; }
        public string Displayname { get => displayname; set => displayname = value; }
    }
}
