using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace website
{
    public partial class _Default : Page
    {
        SqlConnection con=new SqlConnection("server=.\\SQLEXPRESS;integrated security=true;database=shopping_website");
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
                    da1.Fill(ds1, "product");
                  DataList1.DataSource = ds1.Tables["product"].DefaultView;
                    DataList1.DataBind();
                    //GridView1.DataSource = ds.Tables["prod"].DefaultView;
                    //GridView1.DataBind();
                  //  Response.Write(ds.Tables["products"].Rows[0].ItemArray[1].ToString());
                }catch(Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}