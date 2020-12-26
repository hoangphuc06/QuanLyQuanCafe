using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyQuanCafe.DTO;
using System.Security.Cryptography;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;

namespace QuanLyQuanCafe
{
    class UserAccount
    {
        private static UserAccount instance;

        public static UserAccount Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserAccount();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private UserAccount() { }

        public bool Login(string username, string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hashPass = "";
            foreach (byte item in hashData)
            {
                hashPass += item;
            }

            string query = "USP_Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, hashPass });
            return result.Rows.Count > 0;
        }

        public Account GetAccountByUserNamae(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account WHERE UserName = '" + userName + "'");
            foreach (DataRow item in data.Rows)
            {

                return new Account(item);
            }
            return null;
        }

        public bool UpdatePassword(string userName, string pass, string newPass)
        {
            // Mã hóa password
            byte[] temp1 = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] hashData1 = new MD5CryptoServiceProvider().ComputeHash(temp1);

            string hashPass1 = "";
            foreach (byte item in hashData1)
            {
                hashPass1 += item;
            }

            // Mã hóa new password
            byte[] temp2 = ASCIIEncoding.ASCII.GetBytes(newPass);
            byte[] hashData2 = new MD5CryptoServiceProvider().ComputeHash(temp2);

            string hashPass2 = "";
            if (newPass != null && newPass != "")
            {
                foreach (byte item in hashData2)
                {
                    hashPass2 += item;
                }
            }

            string query = string.Format("UPDATE dbo.Account SET PassWord = N'{0}' WHERE UserName = N'{1}' AND PassWord = N'{2}'", hashPass2, userName, hashPass1);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateAccount(string name, string displayName)
        {
            string query = string.Format("UPDATE dbo.Account SET DisplayName = N'{1}' WHERE UserName = N'{0}'", name, displayName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT UserName, DisplayName, Type, Active FROM dbo.Account");
        }

        public bool InsertAccount(string name, string displayName, int type)
        {
            if (Check(name) == 1)
            {
                string query = string.Format("INSERT dbo.Account (UserName, DisplayName, Type, PassWord, Active) VALUES ( N'{0}', N'{1}', {2}, N'{3}', 1)", name, displayName, type, "1962026656160185351301320480154111117132155");
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateAccount(string name, string displayName, int type)
        {
            string query = string.Format("UPDATE dbo.Account SET DisplayName = N'{1}', Type = {2} WHERE UserName = N'{0}'", name, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteAccount(string name)
        {
            string query = string.Format("DELETE FROM dbo.Account WHERE UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool ResetPassword(string name)
        {
            string query = string.Format("UPDATE dbo.Account SET PassWord = N'1962026656160185351301320480154111117132155' WHERE UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool ChangeActive(string name, int active)
        {
            string query = string.Format("UPDATE dbo.Account SET Active = {0} WHERE UserName = N'{1}'", active, name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public int Check(string userName)
        {
            string check = string.Format("SELECT * FROM dbo.Account WHERE UserName = N'{0}'", userName);
            var test = DataProvider.Instance.ExecuteScalar(check);
            if (test == null)
                return 1;
            else
                return 0;
        }
        Image ByteArrayToImage(byte[] img)
        {
            if (IsValidImage(img) == true)
            {
                MemoryStream m = new MemoryStream(img);
                return Image.FromStream(m);
            }
            else
                return null;
            
        }
        public bool UpdateImage(string name, byte[] img)
        {
            SqlConnection conn = new SqlConnection(DataProvider.Instance.ConnectionSTR);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Account set Image_Account = @hinh where UserName = @ten", conn);
            cmd.Parameters.Add("@ten", name);
            cmd.Parameters.Add("@hinh", img);
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result > 0;
        }

        public static bool IsValidImage(byte[] bytes)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(bytes))
                    Image.FromStream(ms);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }

        public Image GetImageByName(string name)
        {
            string temp = string.Format("select * from Account where UserName = N'{0}'", name);
            DataTable mtb = DataProvider.Instance.ExecuteQuery(temp);

            if (IsValidImage((byte[])mtb.Rows[0]["Image_Account"]) == false)
                return null;

            Image img = ByteArrayToImage((byte[])mtb.Rows[0]["Image_Account"]);
            return img;
        }

        public int DemTaiKhoanQL()
        {
            string query = "SELECT COUNT(UserName) FROM Account WHERE Type = 0";
            int dem = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query).ToString());
            return dem;
        }

        public string GetDisplayNameByID(string id)
        {
            string query = "SELECT DisplayName FROM Account WHERE UserName = '" + id + "'";
            string displayname = DataProvider.Instance.ExecuteScalar(query).ToString();
            return displayname;
        }
    }
}
