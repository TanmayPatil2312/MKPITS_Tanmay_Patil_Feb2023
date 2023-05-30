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
    }
    
}
