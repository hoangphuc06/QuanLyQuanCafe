using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyQuanCafe.DTO;
using System.Security.Cryptography;

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
            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[]{username,hashPass});
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

        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
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
            
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword", new object[] {userName, displayName, hashPass1, hashPass2});
            return result > 0;
        }
        
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT UserName, DisplayName, Type FROM dbo.Account");
        }

        public bool InsertAccount(string name, string displayName, int type)
        {
            string query = string.Format("INSERT dbo.Account (UserName, DisplayName, Type, PassWord) VALUES ( N'{0}', N'{1}', {2}, N'{3}')", name, displayName, type, "1962026656160185351301320480154111117132155");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
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
    }
}
