using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace bike_connection
{
    public static class DatabaseConnection    //static class
    {
        //static variable to create connection 
        private static string ConnectionString = "server=TANMAY\\SQLEXPRESS;integrated security=true;database=tcs;";
        public static SqlConnection GetConnection() // method name is getconnection and return type is sql connection 

        {
            SqlConnection conn=new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        //creating static  method to insert record in table
        public static string insertrecord(string userid , string username,string password)
        {
            SqlConnection conn = GetConnection();

            string query = "insert into users values (@userid,@username,@password)";
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@userid", userid);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                //execute the command using executenon query method 
                command.ExecuteNonQuery();
                return "record inserted successfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                conn.Close();
            }
        }
        public static string updaterecord(string username,string password)
        {
            SqlConnection conn = GetConnection();
            string query = "update users set password=@password where username=@username ";
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@username", username);

                command.ExecuteNonQuery();

                return "record updated successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString() ;

            }
            finally
            {
                conn.Close();
            }
        }

        public static string deleterecord(string username)
        {
            SqlConnection conn = GetConnection();
            string query = "delete from users where username=@username ";
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@username", username);

                command.ExecuteNonQuery();

                return "record deleted successfully";

            }
            catch (Exception ex)
            {
                return ex.ToString();

            }
            finally
            {
                conn.Close();
            }
        }

        /// connected environment using select command 
        //public static SqlDataReader GetCity()
        //{
        //    SqlConnection conn = GetConnection();
        //    string query = " select * from city";
        //    try
        //    {
        //        SqlCommand command = new SqlCommand(query, conn);
        //        SqlDataReader dr = command.ExecuteReader();
        //        return dr;
        //    }
        //    catch (Exception ex )
        //    {
        //        return null ;
        //    }
        //}
        ///

        //disconnected environment code 
        //dataset is return type 
        public static DataSet GetCity()
        {
            SqlConnection conn = GetConnection ();
            string query = "select * from city ";
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query,conn);
                da.Fill(ds, "city");
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //data grid view code 
        public static DataSet InternDetails()
        {
            SqlConnection conn = GetConnection();
            DataSet ds = new DataSet(); //object name is different it will only run within this menthod only .
            try
            {
                string qr = "select * from users";
                SqlDataAdapter da = new SqlDataAdapter(qr,conn);
                da.Fill(ds, "users");
                return ds;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public static DataSet searchinterndetail(string userid)
        {
            SqlConnection conn = GetConnection();
            DataSet ds =new DataSet();
            string qr = "select * from users where userid=@userid";
            SqlDataAdapter da = new SqlDataAdapter(qr, conn);
            da.SelectCommand.Parameters.AddWithValue("@userid", userid);
            da.Fill(ds, "users");
            return ds;
        }

    }
}
