using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace JWTDemo.Helper
{
    public class Database
    {
        public IDbConnection conn;
        public Database()
        {
            conn = new MySqlConnection("server=localhost;user id=root;database=sistem_kartu_rencana_studi;SslMode=none");
        }

        public bool Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                return true;
            }
            return false;
        }

        public bool Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                return true;
            }
            return false;
        }
    }
}
