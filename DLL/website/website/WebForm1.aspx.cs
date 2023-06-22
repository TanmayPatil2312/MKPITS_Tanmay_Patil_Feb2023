using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace website
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("server=.\\SQLEXPRESS;integrated security=true;database=shopping_website");
        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                try
                {
                    SqlDataAdapter da1 = new SqlDataAdapter("select * from Products", con);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1, "prod");
                    //  DataList1.DataSource = ds.Tables["prod"].DefaultView;
                    //DataList1.DataBind();
                    GridView1.DataSource = ds1.Tables["prod"].DefaultView;
                    GridView1.DataBind();
                    //  Response.Write(ds.Tables["products"].Rows[0].ItemArray[1].ToString());
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }
    }
}