using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace server_object_methods
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("hello from WebForm1 page  ");
            Server.Execute("WebForm2.aspx");
            Response.Write("  welcome back to WebForm1 page ");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("hello from WebForm1 transfer page  ");
            Server.Transfer("WebForm2.aspx");
            Response.Write("  welcome back to WebForm1 transfer page");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Write(Server.HtmlEncode("<H1> is an example of a Heading tag </H1>"));
            Response.Write("<H1> is an example of a Heading tag </H1>");


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Write(Server.UrlEncode("http://localhost/code/map.aspx"));
            Response.Write("http://localhost/code/map.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string name = Server.UrlEncode("John Saunder");
            Response.Redirect("WebForm3.aspx?name=" + name);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string name = "John Saunder";
            Response.Redirect("WebForm3.aspx?name=" + name);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string name = Server.UrlEncode("John Saunders");
            string password = Server.UrlEncode("King");
            Response.Write("WebForm3.aspx?name" + name + "&password=" + password);


        }
    }
}