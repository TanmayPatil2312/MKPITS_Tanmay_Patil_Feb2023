using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace drivenit
{
    public partial class ItemMaster : System.Web.UI.Page
    {

        SqlConnection conn = new SqlConnection("server=TANMAY\\SQLEXPRESS;integrated security=true;database=drivenitDB");
        SqlCommand command = null;
        string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into ItemMaster values(@ItemDescr,@BalQty,@CreatedOn )";
            SqlCommand command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@ItemDescr", TextBox2.Text);
            command.Parameters.AddWithValue("@BalQty", Convert.ToInt32(TextBox3.Text));
            command.Parameters.AddWithValue("@CreatedOn", TextBox4.Text);

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            Label1.Text = "record saved successfully ";
            TextBox1.Text = "";
            TextBox1.Focus();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update ItemMaster set ItemDescr=@ItemDescr,BalQty=@BalQty,CreatedOn=@CreatedOn where ItemID=@ItemID";
            SqlCommand command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@ItemDescr", TextBox2.Text);
            command.Parameters.AddWithValue("@BalQty", Convert.ToInt32(TextBox3.Text));
            command.Parameters.AddWithValue("@CreatedOn", TextBox4.Text);
            command.Parameters.AddWithValue("@ItemId", Convert.ToInt32(TextBox1.Text));




            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            Label1.Text = "record updated ";
            TextBox1.Text = "";
            TextBox1.Focus();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "delete from ItemMaster  where ItemID=@ItemID";
            SqlCommand command = new SqlCommand(str, conn);
            //command.Parameters.AddWithValue("@ItemDescr", TextBox1.Text);
            //command.Parameters.AddWithValue("@BalQty", Convert.ToInt32(TextBox2.Text));
            //command.Parameters.AddWithValue("CreatedOn", TextBox3.Text);
            command.Parameters.AddWithValue("@ItemId", Convert.ToInt32(TextBox4.Text));


            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            Label1.Text = "record deleted ";
        }
    }
}