using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;


        public static BillDAO Instance 
        {    
            get
            {
                if (instance == null) instance = new BillDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private BillDAO() { }

        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE ID_TableFood = " + id.ToString() +" AND status = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
            // Thành công: bill ID
            // Thất bại: -1 
        }
    }
}
