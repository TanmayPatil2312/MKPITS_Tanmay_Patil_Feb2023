using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.EnterpriseServices;
using System.Drawing;

namespace DBConListClass.Models
{
    public class ItemDBHandler
    {
        private SqlConnection conn;
        private void connection()
        {
            //string constring = ConfigurationManager.ConnectionStrings["CompShopConString"].ToString();
            string constr = "server=TANMAY\\SQLEXPRESS;integrated security=True;database=mvc_connection";
            conn=new SqlConnection(constr);
        }

        //2 . ----Get All Item List -----
        // list generic class to create collection of itemmodel objects
        public List<ItemModel> GetItemsList()
        {
            connection();
            List<ItemModel> list = new List<ItemModel>();
            string query = "select * from itemlist";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            ad.Fill(dt);
            conn.Close();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new ItemModel
                {
                    ID = Convert.ToInt32(dr["id"]),
                    Name = Convert.ToString(dr["name"]),
                    Category = Convert.ToString(dr["category"]),
                    Price = Convert.ToInt32(dr["Price"])
                });

            }
            return list;
        }


        // 1. ------Insert Item-----
        public bool InsertItem(ItemModel iList)
        {
            connection();
            string query = "Insert Into Itemlist Values ('"+iList.Name+"','"+iList.Category + "'," + iList.Price + ")";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if (i >= 1)
                return true;
            else
                return false;
        }
    }
}