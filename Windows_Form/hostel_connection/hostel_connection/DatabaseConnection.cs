using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hostel_connection
{
    internal class DatabaseConnection
    {
        //creating a static variable 
        private static string connectingString = "server=TANMAY\\SQLEXPRESS; integrated security=true; database=institute;";

        //creating a static method 
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectingString);
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
        //creating a static method to insert record into users table 
        public static string InsertRecord(string empname,string password)
        {
            SqlConnection conn=GetConnection();

            //creating a insert command 
            string query = "insert into employees1 values (@empname,@password)";
            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, conn);
                //defining sql parameters
                command.Parameters.AddWithValue("@empname", empname);
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
                conn.Close();
            } 
        }
        //creating a static method to update record into users table
        public static string UpdateRecord(string empname, string password)
        {
            SqlConnection conn=GetConnection() ;

            //creating a insert command 
            string query = "update employees1 set password=@password where empname=@empname";
            //@username and @password are sql parameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, conn);
                //defining sql parameters
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@empname", empname);
                //executing the command using execute non query method
                command.ExecuteNonQuery();
                return "record updated successfully";

            }
            catch(Exception ee)
            {
                return ee.ToString();
            }
            finally
            {
                conn.Close();
            }
        }
        //creating a static method to delete record from users table 
        public static string DeleteRecord(string empname)
        {
            SqlConnection conn = GetConnection();
            //creating a insert command 
            string query = "delete from employees1 where username=@username";
            //@username and @password are sql parameters 
            try
            {
                //creating an object of sql command class
                SqlCommand command = new SqlCommand(query, conn);
                //defining sql paarmeters 
                command.Parameters.AddWithValue("@empname", empname);
                //executing the command using execute non query method 
                command.ExecuteNonQuery();
                return "record deleted successfully";
            }
            catch(Exception ee)
            {
                return ee.ToString();
            }
            finally
            {
                conn.Close ();
            }
            

           
        }
    }
}
