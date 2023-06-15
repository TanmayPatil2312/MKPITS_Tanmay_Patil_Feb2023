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
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=trust_me");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // ADD button code in item page 
            str = "insert into Department_mast values(@Department_name)";
            SqlCommand command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@Department_name", TextBox8.Text);
            //command.Parameters.AddWithValue("@Department_", TextBox9.Text);

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            TextBox8.Text = "";
            TextBox8.Focus();
            Label1.Text = "record saved ";
            loaddata();
        }

        protected void Button5_Click(object sender, EventArgs e) //  show grid vieww button code 
        {
            loaddata();
        }
        public void loaddata()
        {
            str = "select * from Department_mast ";
            da = new SqlDataAdapter(str, conn);
            da.Fill(ds, "tableitem");
            GridView1.DataSource = ds.Tables["tableitem"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)//modify
        {
            str = "update Department_mast set Department_name=@Department_name where Department_id=@Department_id";
            SqlCommand command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@Department_name", TextBox8.Text);
            command.Parameters.AddWithValue("@Department_id",Convert.ToInt32( TextBox9.Text));

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            TextBox8.Text = "";
            TextBox8.Focus();
            Label1.Text = "record updated ";
            loaddata();
        }

        protected void Button3_Click(object sender, EventArgs e)//delete
        {
            str = "delete from Department_mast where Department_name=@Department_name";
            SqlCommand command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@Department_name", TextBox8.Text);
           // command.Parameters.AddWithValue("@Department_id", Convert.ToInt32(TextBox9.Text));

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            TextBox8.Text = "";
            TextBox8.Focus();
            Label1.Text = "Record Deleted  ";
            loaddata();
        }

        protected void Button4_Click(object sender, EventArgs e) //search 
        {
            str = "select * from Department_mast where Department_id=@Department_id";
            da = new SqlDataAdapter(str, conn);
            da.SelectCommand.Parameters.AddWithValue("@Department_id",TextBox9.Text);
            da.Fill(ds, "Department_mast");

            //TextBox8.Text = ds.Tables["Department_mast"].Rows[0].ItemArray[1].ToString();
           
            GridView1.DataSource = ds.Tables["Department_mast"].DefaultView;
            GridView1.DataBind();
        }
    }
}