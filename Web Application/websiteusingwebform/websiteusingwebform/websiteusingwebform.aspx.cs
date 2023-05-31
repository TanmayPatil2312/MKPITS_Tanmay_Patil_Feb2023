using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace websiteusingwebform
{
    public partial class websiteusingwebform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList4.Items.Clear();

            switch (DropDownList3.Text)
            {
                case "India":
                    DropDownList4.Items.Add("Nagpur");
                    DropDownList4.Items.Add("Mumbai");
                    break;
                case "Nepal":
                    DropDownList4.Items.Add("Kathmandu");
                    DropDownList4.Items.Add("Lalitpur");
                    break;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Country   " + DropDownList3.Text + "<br>");
            sb.Append("City      " + DropDownList4.Text + "<br>");
            foreach (ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                    sb.Append("course    " + li.Value + "<br>");
                }
            }
            sb.Append("center     " + ListBox1.SelectedItem.ToString() + "<br>");
            Label1.Text = sb.ToString();

        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}