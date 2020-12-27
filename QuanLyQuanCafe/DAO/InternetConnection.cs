using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{

    public class InternetConnection
    {
        private static InternetConnection instance;


        public static InternetConnection Instance
        {
            get
            {
                if (instance == null) instance = new InternetConnection();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private InternetConnection() { }

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int description, int reservedValue);
        public static bool IsConnectedToInternet()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }
    }
}
