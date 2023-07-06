using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace connectioninsertitem.Models
{
    public class ItemDBHandler
    {
        private SqlConnection con;
        private void connection()
        {
            // string constring = ConfigurationManager.ConnectionStrings["CompShopConString"].ToString();
            string constr = "server=TANMAY\\SQLEXPRESS;integrated security=true;database=mvc_connection";
            con = new SqlConnection(constr);
        }


        public List<ItemModels> GetItemList()
        {
            connection();

            List<ItemModels> iList = new List<ItemModels>();

            string query = "SELECT * FROM itemlist";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            adapter.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                iList.Add(new ItemModels
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    Name = Convert.ToString(dr["Name"]),
                    Category = Convert.ToString(dr["Category"]),
                    Price = Convert.ToDecimal(dr["Price"])
                });
            }
            return iList;
        }
        public bool InsertItem(ItemModels iList)
        {
            connection();
            string query = "INSERT INTO itemlist VALUES('" + iList.Name + "','" + iList.Category + "'," + iList.Price + ")";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }
        public bool UpdateItem(ItemModels iList)
        {
            connection();
            string query = "UPDATE ItemList SET Name = '" + iList.Name + "', Category = '" + iList.Category + "',Price = " + iList.Price + " WHERE ID = " + iList.ID;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }
        public bool DeleteItem(int id)
        {
            connection();
            string query = "Delete from ItemList where ID=" + id;
            SqlCommand cmd=new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            
            if (i >=1)
                return true;
            else
                return false;
        }
    }
}