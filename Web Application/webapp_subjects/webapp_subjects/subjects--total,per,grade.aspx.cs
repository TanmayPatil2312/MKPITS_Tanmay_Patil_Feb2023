using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webapp_subjects
{
    public partial class subjects__total_per_grade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //int sub1 = 50;
            int sub1 = Convert.ToInt32(TextBox1.Text);
            //int sub2 =50;
            int sub2 = Convert.ToInt32(TextBox2.Text);

            // int sub3 =50 ;
            int sub3 = Convert.ToInt32(TextBox3.Text);

            int total = 0;
            int per = 0;
            total = sub1 + sub2 + sub3;
            Label1.Text= total.ToString();
            per = (total * 100) / 300;
            Label2.Text=per.ToString();
            if(per>90)
            {
                Label3.Text = "Distinction";
            }
            else if(per>70)
            {
                Label3.Text = "Bhidu First Class Pass ZHala tu ";

            }
            else
            {
                Label3.Text = "We are so sad to inform you that you are FAIL";
            }
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