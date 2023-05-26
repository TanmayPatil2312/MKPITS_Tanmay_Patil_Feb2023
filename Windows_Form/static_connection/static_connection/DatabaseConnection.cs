using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace static_connection
{
    public static class DatabaseConnection
    {
       
        
            //creating a static variable 
            private static string connectionString = "server=TANMAY\\SQLEXPRESS;database=bike; integrated security=true;";
            //creating a static method 
            public static SqlConnection GetConnection()
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    return conn;
                }
                catch (SqlException ee)
                {
                    return null;
                }
            }
        }
    }


