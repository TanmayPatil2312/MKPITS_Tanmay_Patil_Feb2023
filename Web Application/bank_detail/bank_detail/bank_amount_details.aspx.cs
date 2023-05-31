using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bank_detail
{
    public partial class bank_amount_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int amount = 1000;

            int addamount = Convert.ToInt32(TextBox2.Text);

            int totalbalance = 0;

            string acctype = TextBox3.Text;

            if(acctype =="withdrawal")
            {
                totalbalance = amount - addamount;
            }
            else if (acctype =="deposit")
            {
                totalbalance = amount + addamount;
            }
            else if (addamount > amount)
            {
                Label1.Text = "AddAmount is not greater than Amount ";
            }
            Label1.Text=totalbalance.ToString();
            clearall();
        }
        public void clearall()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }
    }
}