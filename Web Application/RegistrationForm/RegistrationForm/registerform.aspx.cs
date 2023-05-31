using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationForm
{
    public partial class registerform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb =new System.Text.StringBuilder();
            sb.Append("name " + TextBox1.Text + "<br>");
            sb.Append("password " + TextBox2.Text + "<br>");
            sb.Append("Address" + TextBox3.Text + "<br>");
            sb.Append("MobileNo" + TextBox4.Text+ "<br>");
            sb.Append("date of birth" + TextBox5.Text + "<br>");
            if(RadioButton1.Checked)
            sb.Append("gender" + RadioButton1.Text + "<br>");
            else if (RadioButton2.Checked)
                sb.Append("gender" + RadioButton2.Text + "<br>");
            else if (RadioButton3.Checked)
                sb.Append("gender" + RadioButton3.Text + "<br>");


            if(CheckBox2.Checked)
                sb.Append("hobbies " + CheckBox2.Text + "<br>");
            if (CheckBox2.Checked)
                sb.Append("hobbies " + CheckBox2.Text + "<br>");
            sb.Append("city " + DropDownList1.Text + "<br>");

            Label2.Text = sb.ToString();




        }
    }
}