using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trust_us
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=trust_me");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e) // add button code 
        {
            // ADD button code in item page 
            str = "insert into Vendor_mast values(@Vendor_Name)";
            SqlCommand command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@Vendor_Name", TextBox4.Text);
            //command.Parameters.AddWithValue("@Department_", TextBox9.Text);

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            //TextBox4.Text = "";
            //TextBox4.Focus();
            Label1.Text = "record saved ";
            loaddata();
        }

        protected void Button5_Click(object sender, EventArgs e)  // show grid view 
        {
            loaddata();

        }
        public void loaddata()
        {
            str = "select * from Vendor_mast ";
            da = new SqlDataAdapter(str, conn);
            da.Fill(ds, "tableitem");
            GridView1.DataSource = ds.Tables["tableitem"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)  //modify button code
        {
            str = "update Vendor_mast set Vendor_Name=@Vendor_Name where Vendor_id=@Vendor_id";
            SqlCommand command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@Vendor_Name", TextBox4.Text);
            command.Parameters.AddWithValue("@Vendor_id", Convert.ToInt32(TextBox5.Text));

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            //TextBox8.Text = "";
            //TextBox8.Focus();
            Label1.Text = "record updated ";
            loaddata();
        }

        protected void Button3_Click(object sender, EventArgs e) // delete button code
        {
            str = "delete from Vendor_mast where Vendor_id=@Vendor_id";
            SqlCommand command = new SqlCommand(str, conn);
            //command.Parameters.AddWithValue("@Vendor_Name", TextBox4.Text);
            command.Parameters.AddWithValue("@Vendor_id", Convert.ToInt32(TextBox5.Text));

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            //TextBox8.Text = "";
            //TextBox8.Focus();
            Label1.Text = "Record Delete  ";
            loaddata();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "select * from Vendor_mast where Vendor_id=@Vendor_id";
            da = new SqlDataAdapter(str, conn);
            da.SelectCommand.Parameters.AddWithValue("@Vendor_id", TextBox5.Text);
            da.Fill(ds, "Vendor_mast");

            //TextBox8.Text = ds.Tables["Department_mast"].Rows[0].ItemArray[1].ToString();

            GridView1.DataSource = ds.Tables["Vendor_mast"].DefaultView;
            GridView1.DataBind();
        }
    }
}