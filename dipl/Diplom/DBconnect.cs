using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    class DBconnect
    {
        private static string ConnStr = "Data Source=DESKTOP-SJBK3TL\\TRANSBD;Initial Catalog=schedule;Integrated Security=True; User ID = DBC; Password=12345";

        SqlConnection conn = new SqlConnection(ConnStr);

        public void ConnOpen()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void ConnClosed()
        {
            if(conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public SqlConnection SqlConnection()
        {
            return conn;
        }
    }
}
