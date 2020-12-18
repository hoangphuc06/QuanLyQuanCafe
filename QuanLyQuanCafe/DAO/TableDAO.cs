using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        public static int TableWidth = 150;
        public static int TableHeight = 150;

        private TableDAO() { }

        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTable @idTable1 , @idTable2", new object[] { id1, id2 });
        }

        public void MergeTable(int id1, int id2, int id3)
        {
            DataProvider.Instance.ExecuteQuery("USP_MergeTable @idTable1 , @idTable2 , @idTable3", new object[] { id1, id2, id3 });
        }

        public List<Table> LoadTableList()
        {
            List<Table> tablelsit = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.TableFood");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tablelsit.Add(table);
            }

            return tablelsit;
        }

        public bool InsertTable(string name)
        {
            string query = string.Format("Insert into dbo.TableFood(NameTable,StatusTable) values (N'{0}',N'Trống')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateTable(string name, int id)
        {
            string query = string.Format("update dbo.TableFood set NameTable = N'{0}' where ID_TableFood = {1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteTable(int id)
        {
            string query = string.Format("delete dbo.TableFood where ID_TableFood = {0}",id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
