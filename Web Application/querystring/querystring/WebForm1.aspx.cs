using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace querystring
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //code to retrieve query string value 

        protected void Page_Load(object sender, EventArgs e)
        {
            //code to retrieve query string value 
            //string username = Request.QueryString["username"].ToString();
            //Label1.Text = username;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("default01.aspx?username=" + TextBox1.Text);


        }
        //now to retrieve value of querystring in default5.aspx page 
        //create another web form suppose (default5.aspx)


    }
}