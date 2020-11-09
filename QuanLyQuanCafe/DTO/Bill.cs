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
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }

        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["ID_Bill"];
            this.DateCheckIn = (DateTime?)row["DateCheckIn"];

            var DateCheckOutTemp = row["DateCheckOut"];
            if (DateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)DateCheckOutTemp;

            this.Status = (int)row["status"];
        }    
    }
}
