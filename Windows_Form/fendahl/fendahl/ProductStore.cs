using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace fendahl
{
    public static class ProductStore //class name 
    {
        private static string connectionString = "server=TANMAY\\SQLEXPRESS;integrated security=true;database=tcs";
        // method to create connection 
        public static SqlConnection GetConnection() // sql connection return type write this as it is shown 
        {
            SqlConnection conn = new SqlConnection(connectionString); //storing variable name of sql connection 
            try
            {
                //connection open 
                conn.Open();//jiase he open connection kiye usko bolte hai connected environment
                            //agr open close nhi kiye to use bolte hai dissconnected environment
                return conn;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                //conn.Close();
            }
        }
        //method to return product category 
        public static DataSet Gettableproductcategory() // method which can be taken anything 
        {
            SqlConnection conn = GetConnection(); //connection 
            string query = "select * from TableProductCategory"; // sql query ( TableProductCategory -> it is table name)
            DataSet ds = new DataSet(); //dataset is a class name which have a object as "ds"
            SqlDataAdapter da = new SqlDataAdapter(query, conn); //sqldataadapter is a class in which "da" is a object of class 
            da.Fill(ds, "TableProductCategory"); //fill is a method which add class data or method data 
            return ds; // it returns dataset 

        }

        //method to return product name for given product type name
        public static DataSet Gettableproductname(string Product_Type_Name)  //(TableProductCategory --> Product_Type_Name this we)
        {
            SqlConnection conn = GetConnection();
            string query = "select p.ProductID,p.Product_name from TableProduct p inner join TableProductCategory t on p.Product_Category_ID = t.Product_Category_ID where t.Product_Type_Name = @Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name); //when we use @ this command is compulsory to write otherwise it will give the error
            da.Fill(ds, "TableProduct"); //TableProduct() it is a table name  
            return ds;
        }

        //method to return gstdetails for given product type name
        public static DataSet GetGstDetails(string product_type_name)
        {
            SqlConnection conn = GetConnection();

            string query = " select a.cgst,a.sgst,a.igst from TableProductGSTDetails a inner join TableProductCategory b on a.Product_Gst_ID = b.Product_Gst_ID where b.Product_Type_Name = @Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@product_type_name", product_type_name);
            da.Fill(ds, "TableProductGSTDetails");
            return ds;

        }
        // method to return product price for given product_name
        public static DataSet GetProductPrice(string Product_Name)
        {
            SqlConnection conn = GetConnection();
            string query = "select ProductPrice from TableProduct where Product_Name=@Product_Name";//query find productprice from tableproduct 
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@Product_Name", Product_Name);//productname kyu lekhe kyu ke hme productname me se price chahiye
            da.Fill(ds2, "TableProduct");//tablename (tableproduct)
            return ds2;//return ds2
        }

        //method to save record inside invoice table
        public static string saveTableInvoiceDetails(string Customer_Name, string Customer_Contact, int Product_Category_ID, int Product_ID, int Residential_Type_ID, DateTime Invoice_Date
,       decimal Quantity, decimal Price, decimal CGST, decimal SGST, decimal IGST, decimal CGST_Value, decimal SGST_Value, decimal IGST_Value, decimal Total_Amount)
            //table4 record parameters
        {
            string result = null;
            // System.Windows.Forms.MessageBox.Show(invoice_date.ToString());
            string query = "insert into TableInvoiceDetailss values (@Customer_Name , @Customer_Contact , @Product_Category_ID, @Product_ID , @Residential_Type_ID , @Invoice_Date,@Quantity , @Price , @CGST , @SGST , @IGST , @CGST_Value , @SGST_Value , @IGST_Value , @Total_Amount )";

            SqlConnection conn = GetConnection();
            //jiase he kuch insert kiye to hme use krna pdta Sqlcommand class
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@Customer_Name", Customer_Name); //textbox1
            command.Parameters.AddWithValue("@Customer_Contact", Customer_Contact);//textbox2
            command.Parameters.AddWithValue("@Product_Category_ID", Product_Category_ID);//combobox1
            command.Parameters.AddWithValue("@Product_ID", Product_ID);//combox2
            command.Parameters.AddWithValue("@Residential_Type_ID", Residential_Type_ID); //nationality= radiobutton1 radiobutton2
            command.Parameters.AddWithValue("@Invoice_Date", Invoice_Date); //datetimepicker1
            command.Parameters.AddWithValue("@Quantity", Quantity); //textbox10
            command.Parameters.AddWithValue("@Price", Price); //textbox9
            command.Parameters.AddWithValue("@CGST", CGST); //textbox3
            command.Parameters.AddWithValue("@SGST", SGST); //textbox4
            command.Parameters.AddWithValue("@IGST", IGST); //textbox5
            command.Parameters.AddWithValue("@CGST_Value", CGST_Value); //textbox6
            command.Parameters.AddWithValue("@SGST_Value", SGST_Value); //textbox7
            command.Parameters.AddWithValue("@IGST_Value", IGST_Value); //textbox8
            command.Parameters.AddWithValue("@Total_Amount", Total_Amount); //textbox11
            try
            {
                command.ExecuteNonQuery();
                result = "Record Saved Successfully";
            }
            catch (Exception ee)
            {
                result = ee.ToString();
            }
            finally
            {
                conn.Close();//connection open kiye to close
            }
            return result;






        }


    }
}