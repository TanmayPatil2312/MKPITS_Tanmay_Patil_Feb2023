using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace studentdetailsmvc.Models
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

            string query = "SELECT * FROM studentlist";
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
                    Address = Convert.ToString(dr["Address"]),
                    Mobno = Convert.ToDecimal(dr["Mobno"])
                });
            }
            return iList;
        }
        public bool InsertItem(ItemModels iList)
        {
            connection();
            string query = "INSERT INTO studentlist VALUES('" + iList.Name + "','" + iList.Address + "'," + iList.Mobno + ")";
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
            string query = "UPDATE studentlist SET Name = '" + iList.Name + "', Category = '" + iList.Address + "',Price = '" + iList.Mobno + "' WHERE ID = " + iList.ID;
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
            string query = "Delete from studentlist where ID=" + id;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }
    }
}