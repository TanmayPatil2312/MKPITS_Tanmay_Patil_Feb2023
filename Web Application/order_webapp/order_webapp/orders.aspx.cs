using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace order_webapp
{
    public partial class orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string item_name;
            item_name = TextBox1.Text;

            int price = 0;
            price = Convert.ToInt32(TextBox2.Text);
            int quantity = 0;
            quantity = Convert.ToInt32(TextBox3.Text);

            int totalprice = 0;

            if(item_name=="Budweiser Magnum")
            {
                totalprice = price * quantity;
            }
            else if (item_name=="Tuborg")
            {
                totalprice= price* quantity;
            }
            else if (item_name=="Bira Boom")
            {
                totalprice=price* quantity;
            }
            else
            {
                Label1.Text = "Sorry beer  is not in our stock";
            }
            Label1.Text=totalprice.ToString();

        }
    }
}