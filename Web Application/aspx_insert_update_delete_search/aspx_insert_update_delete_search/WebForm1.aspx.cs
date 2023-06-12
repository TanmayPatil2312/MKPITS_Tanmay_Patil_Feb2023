using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Policy;

namespace aspx_insert_update_delete_search
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("server=TANMAY\\SQLEXPRESS; integrated security = true; database=bike");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //by clicking this button we show the data on grid view 
            loaddata();
        }
        public void loaddata()
        {
            str = "select * from customer";
            da = new SqlDataAdapter(str, conn);
            da.Fill(ds, "customer");
            GridView1.DataSource = ds.Tables["customer"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // by clicking this button the data will be inserted in table and shown in gridview also 
            str = "insert into customer values (@customer_id,@first_name,@last_name,@phone,@email,@street,@city,@state,@zip_code)";
            SqlCommand command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@customer_id", Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@first_name", TextBox2.Text);
            command.Parameters.AddWithValue("@last_name", TextBox3.Text);
            command.Parameters.AddWithValue("@phone", Convert.ToInt32(TextBox4.Text));
            command.Parameters.AddWithValue("email", TextBox5.Text);
            command.Parameters.AddWithValue("street", TextBox6.Text);
            command.Parameters.AddWithValue("city", TextBox7.Text);
            command.Parameters.AddWithValue("state", TextBox8.Text);
            command.Parameters.AddWithValue("zip_code", Convert.ToInt32(TextBox9.Text));

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            Label1.Text = "Record Saved";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();



        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //            // by clicking this button the data will be updated in table and shown in gridview also 

            str = "update customer set first_name=@first_name, last_name=@last_name, phone=@phone, email=@email, street=@street, city=@city, state=@state, zip_code=@zip_code where customer_id=@customer_id";
            SqlCommand command = new SqlCommand(str, conn);
            command.Parameters.AddWithValue("@customer_id", Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@first_name", TextBox2.Text);
            command.Parameters.AddWithValue("@last_name", TextBox3.Text);
            command.Parameters.AddWithValue("@phone",(TextBox4.Text));
            command.Parameters.AddWithValue("email", TextBox5.Text);
            command.Parameters.AddWithValue("street", TextBox6.Text);
            command.Parameters.AddWithValue("city", TextBox7.Text);
            command.Parameters.AddWithValue("state", TextBox8.Text);
            command.Parameters.AddWithValue("zip_code", (TextBox9.Text));

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            Label1.Text = "Record Updated";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "delete from customer where customer_id=@customer_id";
            SqlCommand command = new SqlCommand(str, conn);

            command.Parameters.AddWithValue("@customer_id", Convert.ToInt32(TextBox1.Text));

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            Label1.Text = "Record Deleted";
            TextBox1.Text = "";
            TextBox1.Focus ();
            loaddata();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            str = "select * from customer where customer_id=@customer_id";
            da = new SqlDataAdapter(str, conn);
            da.SelectCommand.Parameters.AddWithValue("@customer_id", Convert.ToInt32(TextBox1.Text));
            da.Fill(ds, "customer");

            TextBox2.Text = ds.Tables["customer"].Rows[0].ItemArray[1].ToString();
            TextBox3.Text = ds.Tables["customer"].Rows[0].ItemArray[2].ToString();
            TextBox4.Text = ds.Tables["customer"].Rows[0].ItemArray[3].ToString();

            GridView1.DataSource = ds.Tables["customer"].DefaultView;
            GridView1.DataBind();
        }
    }
}