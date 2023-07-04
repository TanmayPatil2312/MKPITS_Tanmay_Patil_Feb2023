using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;



namespace DBconnectionwithmvc.Models
{
    public class ItemDBHandler
    {
        SqlConnection conn = null;
        public void connection()
        {
            // string constr = System.Configuration.ConfigurationManager.ConnectionStrings["CompShopConString"].ToString();
            string constr = "server=TANMAY\\SQLEXPRESS;integrated security=true; database=mvc_connection";
            conn = new SqlConnection(constr);
        }

        //insert itemmethod to isert record into itemlist table 
        public bool InsertIItem(ItemModel ilist)
        {
            connection();
            string query = "insert into itemtable values('" + ilist.Name + "','" + ilist.Category + "','" + ilist.Price + "')";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            int i = command.ExecuteNonQuery();
            conn.Close();
            if(i>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
