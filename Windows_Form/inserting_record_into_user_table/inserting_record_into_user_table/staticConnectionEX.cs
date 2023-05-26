using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace inserting_record_into_user_table
{
   public static class staticConnectionEX
    {
        //creating a static variable 
        private static string connectionString = "server=TANMAY\\SQLEXPRESS;integrated security=true;database=bike;";

        //creating a static method
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                return con;
            }
            catch(SqlException ee)
            {
                return null;
            }
        }
        //creating a static method to insert record into users table 
        public static string InsertRecord(String username,string password)
        {
            SqlConnection con = GetConnection();
            //creating a insert command 
            string query = "insert into bike_static_connection values (@username,@password)";
            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sql parameters
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                //executing the command using execute non query method

                command.ExecuteNonQuery();
                return "record inserted successfully";
            }
            catch(Exception ee)
            {
                return ee.ToString();
            }
            finally
            {
                con.Close();
            }
        }
    }

}
