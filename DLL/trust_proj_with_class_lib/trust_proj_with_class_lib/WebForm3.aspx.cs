using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using storedlibrary;

namespace trust_proj_with_class_lib
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
      
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = vendor_class.insertVendor_Mast(TextBox2.Text);
            Label1.Text = res;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = vendor_class.updateVendor_Mast(TextBox2.Text, Convert.ToInt32(TextBox1.Text));
            Label1.Text = res;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string res = vendor_class.deleteVendor_Mast(Convert.ToInt32(TextBox1.Text));
            Label1.Text = res;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = vendor_class.searcVendor_Mast(Convert.ToInt32(TextBox1.Text));
            if (ds.Tables[0].Rows.Count != 0)
            {
                TextBox2.Text = ds.Tables["vendor_mast"].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                Label1.Text = "no record exist";
            }

        }
    }
}