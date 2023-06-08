using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace userManagement
{
    public partial class submit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string email, pwd;
            email = Request.QueryString["email"].ToString();
            pwd = Request.QueryString["pwd"].ToString();
            //Response.Write("email :" + email + "<br>");
            //Response.Write("password :" + pwd + "<br>");
            Label1.Text = "email:- "+ email;
            Label2.Text= "pwd:- "+pwd;
        }
    }
}