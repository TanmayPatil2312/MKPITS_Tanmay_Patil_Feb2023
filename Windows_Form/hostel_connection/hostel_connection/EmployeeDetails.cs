using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;

namespace hostel_connection
{
     class EmployeeDetails
    {

        //creating a static variable 
        private static string connectionString= "server=TANMAY\\SQLEXPRESS; integrated security=true; database=bike;";
        //creating a static method 
        public static SqlConnection GetConnection()
        {
            SqlConnection conn= new SqlConnection(connectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch(SqlException ee)
            {
                return null;
            }
        }
        // method to return city name 
        public static SqlDataReader GetCity()
        {
            SqlConnection conn= GetConnection();
            string query = "select* from city ";
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                //sqldatareader is used to store record returned from city table
                SqlDataReader dr = command.ExecuteReader();
                return dr;
            }
            catch
            {
                return null;
            }
        }

    }
}
