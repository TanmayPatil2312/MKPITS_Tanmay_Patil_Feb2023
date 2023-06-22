using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storedlibrary
{
    
    
        internal static class DbConnection
        {
            public static SqlConnection conn;
            public static SqlConnection getConnection()
            {
                conn = new SqlConnection("server=TANMAY\\SQLEXPRESS;integrated security=true;database=trust_me");

                return conn;
            }

        }
}

