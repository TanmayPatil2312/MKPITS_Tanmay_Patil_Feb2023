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
            string query = "select NationName from TableNation"; //sql query for combobox1 to show the nation name 
            DataSet ds = new DataSet(); // dataset is a return 
            SqlDataAdapter da = new SqlDataAdapter(query, conn); //sqldataadapter return the dataset 
            da.Fill(ds, "TableNation"); // in this line write the table name in which nation name coulumn is present 
            return ds; //dataset return 
        }

        public static DataSet Getstatename(string NationName)
        {
            SqlConnection conn = GetConnection();
            string query = "select s.StateName from TableState s inner join TableNation n on s.NationID=n.NationID where NationName=@NationName";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@NationName",NationName); ///from nation name we have to select state name so in bracket previous combobox1 label name is written.
            da.Fill(ds1, "TableState");
            return ds1;
        }
        public static DataSet Getcityname(string StateName)
        {
            SqlConnection conn = GetConnection();
            string query = "select s.CityName from TableCity s inner join TableState n on s.StateID=n.StateID where StateName=@StateName";
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@StateName", StateName);
            da.Fill(ds2, "TableCity");
            return ds2;
        }
        
        
    }
}
