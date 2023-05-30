using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace fen_project2
{
    public static class CourseRegistration /// class name 
    {
        public static string connectionString = "Server=TANMAY\\SQLEXPRESS; integrated security=true;database=fendahlProject2";
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString); //storing variable name of sql connection 
            try
            {
                //connection open 
                //conn.Open();//jiase he open connection kiye usko bolte hai connected environment
                //agr open close nhi kiye to use bolte hai dissconnected environment
                return conn;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public static DataSet Getnationname() // database store the data in the form of tables 
        {
            SqlConnection conn = GetConnection(); /// conncection 
            string query = "select NationName,NationID from TableNation"; //sql query for combobox1 to show the nation name 
            DataSet ds = new DataSet(); // dataset is a return 
            SqlDataAdapter da = new SqlDataAdapter(query, conn); //sqldataadapter return the dataset 
            da.Fill(ds, "TableNation"); // in this line write the table name in which nation name coulumn is present 
            return ds; //dataset return 
        }

        public static DataSet Getstatename(string NationName)
        {
            SqlConnection conn = GetConnection();
            string query = "select s.StateID, s.StateName from TableState s inner join TableNation n on s.NationID=n.NationID where NationName=@NationName";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@NationName",NationName); ///from nation name we have to select state name so in bracket previous combobox1 label name is written.
            da.Fill(ds1, "TableState");
            return ds1;
        }
        public static DataSet Getcityname(string StateName)
        {
            SqlConnection conn = GetConnection();
            string query = "select s.CityID, s.CityName from TableCity s inner join TableState n on s.StateID=n.StateID where StateName=@StateName";
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@StateName", StateName);
            da.Fill(ds2, "TableCity");
            return ds2;
        }


        //  4 table  TableCourseRegDetaill  in this data we insert through win form .
        public static string savetablecourseregdetaill (int CategoryID , string FullName , int GenderID)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            string query = "insert into TableCourseRegDetaill values (@categoryid,@fullname,@genderid) ";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@categoryid", CategoryID);
            command.Parameters.AddWithValue("@fullname", FullName);
            command.Parameters.AddWithValue("@genderid", GenderID);
            command.ExecuteNonQuery();
            conn.Close();
            return "BHidu record inserted successfully in this TableCourseRegDetaill";
        }


        //  5 table method to save record in TableRegAddress1 --- 
        static int CourseRegID = 0;
        public static string tableregaddress1 (int NationID , int StateID , int CityID)
        {
            SqlConnection conn = GetConnection();   
            conn.Open();
            string query = "select top 1 CourseRegID from TableCourseRegDetaill order by CourseRegID desc ";
            SqlCommand command = new SqlCommand(query, conn);
            CourseRegID =Convert.ToInt32(command.ExecuteScalar()); // return the previous entered value through win form 
            query = "insert into TableRegAddress2 values (@CourseRegID,@NationID,@StateID ,@CityID)";
            command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@CourseRegID", CourseRegID);
            command.Parameters.AddWithValue("@NationID", NationID);
            command.Parameters.AddWithValue("@StateID", StateID);
            command.Parameters.AddWithValue("@CityID", CityID);
            command.ExecuteNonQuery ();
            conn.Close();
            return " Record save in TableRegAddress1";




        }

        // 6 table method to save record in TableFeeDetail1 --
        public static string savetablefeedetail1(double TotalAmount , double MinPer ,double PaidAmount ,double BalAmount , DateTime PaidDate)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            string query = "insert into TableFeeDetail1 values (@CourseRegID,@TotalAmount,@MinPer,@PaidAmount,@BalAmount,@PaidDate)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@CourseRegID", CourseRegID);
            command.Parameters.AddWithValue("@TotalAmount", TotalAmount);
            command.Parameters.AddWithValue("@MinPer", MinPer);
            command.Parameters.AddWithValue("@PaidAmount", PaidAmount);
            command.Parameters.AddWithValue("@BalAmount", BalAmount);
            command.Parameters.AddWithValue("@PaidDate", PaidDate);
            command.ExecuteNonQuery ();
            conn.Close ();
            return "Record Saved in  TableFeeDetail1";
        }



    }
}
