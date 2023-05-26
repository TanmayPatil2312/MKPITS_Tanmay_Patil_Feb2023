using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace fendahl_revision
{
    public static class productstore ///class name 
    {
        public static string connectionString= "server=TANMAY\\SQLEXPRESS;integrated security=true;database=tcs"; //method to create connection 
        public static SqlConnection Getconnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static DataSet Getproductcategory()
        {
            SqlConnection con = Getconnection();
            string query = "select * from tableproductcategory";
            DataSet ds = new DataSet();
            SqlDataAdapter dr= new SqlDataAdapter(query,con);
            dr.Fill(ds, "Product_Type_Name");
            return ds;

        }
        public static DataSet Getproductname(string product_type_name)
        {
            SqlConnection con = Getconnection();
            string query = "select p.productid,p.product_name from tableproduct p inner join tableproductcategory t on p.productid=t.product_category_id where product_type_name=@Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter dr = new SqlDataAdapter(query, con);
            dr.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", product_type_name);

            dr.Fill(ds,"tableproduct");
            return ds;

        }
        public static DataSet Getproductgstdetail(string product_type_name)
        {
            SqlConnection con = Getconnection();
            string query = "select a.cgst,a.sgst,a.igst from tableproductgstdetailss a inner join tableproductcategory t on a.product_gst_id=t.product_category_id where product_type_name=@Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter dr = new SqlDataAdapter(query, con);
            dr.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", product_type_name);

            dr.Fill(ds, "tableproductgstdetailss");
            return ds;

        }
    }
}
