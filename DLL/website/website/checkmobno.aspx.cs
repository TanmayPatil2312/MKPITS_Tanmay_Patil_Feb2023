using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace website
{
    public partial class checkmobno : System.Web.UI.Page
    {
        string ProductId;
        SqlConnection con = new SqlConnection("server=.\\SQLEXPRESS;integrated security=true;database=shopping_website");
        SqlCommand command;
        string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductId = Convert.ToString(Session["ProductId"]);
            Response.Write("ProductId" + ProductId);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = TextBox1.Text;
            string prodname = null;
            int prodprice = 0;
            int qty = 0;
            string sessionid = null;
            if(res=="123456")
            {
                query = "select * from Products where ProductId=@ProductId";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@ProductId", ProductId);
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    prodname = dr["productname"].ToString();
                    prodprice = Convert.ToInt32(dr["productprice"].ToString());

                    qty = 1;
                    sessionid = Session.SessionID;

                }
                con.Close();
                Response.Write("productname " + prodname + "<br>");
                Response.Write("productprice " + prodprice + "<br>");
                Response.Write("qty " + qty + "<br>");
                Response.Write("session id " + sessionid + "<br>");
                //save the product data into carttable

                // Response.Redirect("cart1.aspx");
            }
            else
            {
                Label1.Text = "invalid otp";
            }
        }
    }
}