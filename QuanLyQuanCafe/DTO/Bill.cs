using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Bill
    {
        private int iD;
        private int status;
        private int discount;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }

        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status, int discount)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
            this.Discount = discount;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["ID_Bill"];
            this.DateCheckIn = (DateTime?)row["DateCheckIn"];

            var DateCheckOutTemp = row["DateCheckOut"];
            if (DateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)DateCheckOutTemp;

            this.Status = (int)row["status"];

            if (row["discount"].ToString() != "")

                this.Discount = (int)row["discount"];
        }

    }
}
