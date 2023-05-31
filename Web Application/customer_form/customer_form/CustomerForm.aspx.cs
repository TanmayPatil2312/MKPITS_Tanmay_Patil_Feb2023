using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace customer_form
{
    public partial class CustomerForm : System.Web.UI.Page
    {
        enum payment { cash , EMI }
        payment pay;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        int res = 0;
        int rate = 0;
        int qty = 0;

        protected void Button1_Click(object sender, EventArgs e)
        {
            string custname = TextBox1.Text;
            string ordname = TextBox2.Text;
            int rate = Convert.ToInt32(TextBox3.Text);
            int qty= Convert.ToInt32(TextBox4.Text);
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton1.Checked)
            {
                pay = payment.cash;
                double rate=Convert.ToDouble(TextBox3.Text)*Convert.ToDouble(TextBox4.Text);
                Label1.Text= rate.ToString();
            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton2.Checked)
            {
                pay = payment.EMI;
                double rate = Convert.ToDouble(TextBox3.Text) * (Convert.ToDouble(TextBox4.Text) / 3);
                Label2.Text=rate.ToString();
                Label1.Text=rate.ToString();    
                Label3.Text=rate.ToString();
            }
        }

        public void clearall()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            clearall();

        }
    }
}