using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace invoice_generation_form
{
    public static class invoice_generation
    {
        private static string connectionString = "server=TANMAY\\SQLEXPRESS; integrated security=true; database=electronic_products_invoice;";
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                return conn;
            }
            catch
            {
                return null;
            }
        }
        public static DataSet Getname()
        {
            SqlConnection conn = GetConnection(); /// conncection 
            string query = "select NAME from Computer"; //
            DataSet ds = new DataSet(); // dataset is a return 
            SqlDataAdapter da = new SqlDataAdapter(query, conn); //
            da.Fill(ds, "Computer"); //  
            return ds; //
        }
        public static DataSet Getproductname(string NAME)
        {
            SqlConnection conn = GetConnection();
            string query = " select  * from Computer where NAME=@NAME";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@NAME", NAME);
            da.Fill(ds, "Computer");
            return ds;
        }
        public static DataSet Getcgst(string NAME)
        {
            SqlConnection conn = GetConnection();
            string query = "select CGST , SGST from Computer where Name=@Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@NAME", NAME);
            da.Fill(ds, "Computers");
            return ds;
        }

        //        CREATE TABLE CUSTOMER(ID INT PRIMARY KEY IDENTITY, FIRST_NAME VARCHAR(30),
        //            LAST_NAME VARCHAR(30),GENDER VARCHAR(10),
        //MOBILE VARCHAR(20),PAID_AMOUNT DECIMAL)

        public static DataSet Getcustomer(string FIRST_NAME, string LAST_NAME, string GENDER, string MOBILE_NO, decimal PAID_AMOUNT)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            string query = "insert into Customer values(@FIRST_NAME,@LAST_NAME,@GENDER,@MOBILE_NO,@PAID_AMOUNT)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@FIRST_NAME", FIRST_NAME);
            cmd.Parameters.AddWithValue("@LAST_NAME", LAST_NAME);
            cmd.Parameters.AddWithValue("@GENDER", GENDER);
            cmd.Parameters.AddWithValue("@MOBILE_NO", MOBILE_NO);
            cmd.Parameters.AddWithValue("@PAID_AMOUNT", PAID_AMOUNT);
            cmd.ExecuteNonQuery();
            conn.Close();
        
            return "inserted record successfully";

        }
    }

}
