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
    public partial class cart : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("server=.\\SQLEXPRESS;integrated security=true;database=shopping_website");
        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            string ProductId = Request.QueryString["ProductId"].ToString();
            Session["ProductId"] = ProductId;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("checkmobno.aspx");
        }
    }
}