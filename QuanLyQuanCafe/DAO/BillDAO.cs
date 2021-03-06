﻿using QuanLyQuanCafe.DTO;
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
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE ID_TableFood = " + id.ToString() + " AND status = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
            // Thành công: bill ID
            // Thất bại: -1 
        }

        public void CheckOut(int id, int discount, float totalPrice, string idUser)
        {
            string query = "Update dbo.Bill SET DateCheckOut = GETDATE(), status = 1, " + "discount = " + discount + ", totalPrice = " + totalPrice + ", ID_User = '" + idUser + "' WHERE ID_Bill = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { id });

        }
        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }
        public int GetMaxIdBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(ID_Bill) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }
        public void DeleteBillByTableID(int id)
        {
            string query1 = "select count from dbo.BillInfo as a,dbo.Bill as b Where a.ID_BillInfo=b.ID_Bill and status=0 and b.ID_TableFood= " + id;
            object b = DataProvider.Instance.ExecuteScalar(query1);
            if (b == null)
            {
                string query2 = "delete from dbo.BillInfo where ID_BillInfo = (select ID_Bill from dbo.Bill where ID_TableFood = " + id + " and status = 0 )";
                string query3 = "delete from dbo.Bill where ID_TableFood=" + id + "and status=0";
                string query4 = "update dbo.TableFood set StatusTable=N'Trống' where ID_TableFood=" + id;
                DataProvider.Instance.ExecuteNonQuery(query2);
                DataProvider.Instance.ExecuteNonQuery(query3);
                DataProvider.Instance.ExecuteNonQuery(query4);
            }
        }
    }
}
