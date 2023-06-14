using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trust_us
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=trust_me");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e) //Add
        {
            // ADD button code in item page 
            str = "insert into Item_Master values(@Item_Name,@Category,@rate,@balance_quantity";
            SqlCommand command = new SqlCommand(str, conn);
            //command.Parameters.AddWithValue("@Item_id", Convert.ToInt32(TextBox5.Text));
            command.Parameters.AddWithValue("@Item_Name", TextBox5.Text); 
            command.Parameters.AddWithValue("@Category", (DropDownList1.Text));
            command.Parameters.AddWithValue("@rate", Convert.ToInt32(TextBox6.Text));
            command.Parameters.AddWithValue("@balance_quantity", Convert.ToInt32(TextBox7.Text));

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            Label1.Text = "record saved ";
         
        }

        protected void Button5_Click(object sender, EventArgs e) //update
            //this is the code to show Updated data on grid 
        {
            loaddata();
        }
        public void loaddata()
        {
            str = "select * from Item_Master ";
            da = new SqlDataAdapter(str, conn);
            da.Fill(ds, "tableitem");
            GridView1.DataSource = ds.Tables["tableitem"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e) //Update
        {
            str = "update Item_Master set Item_Name=@Item_Name, Category=@Category, rate=@rate ,balance_quantity=@balance_quantity where Item_Id=@Item_Id ";
            SqlCommand command = new SqlCommand(str, conn);
            
            command.Parameters.AddWithValue("Item_Name",TextBox5.Text);
            command.Parameters.AddWithValue("Category", DropDownList1.Text);
            command.Parameters.AddWithValue("rate",Convert.ToInt32( TextBox6.Text));
            command.Parameters.AddWithValue("balance_quantity", Convert.ToInt32(TextBox7.Text));
            command.Parameters.AddWithValue("Item_Id", TextBox8.Text);

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            Label1.Text = "Record Updated Successfully ";
            loaddata();
        }

        protected void Button3_Click(object sender, EventArgs e)  //Delete
        {
            str = "delete from Item_Master where Item_Name=@Item_Name";
            SqlCommand command = new SqlCommand(str, conn);

            command.Parameters.AddWithValue("@Item_Name",(TextBox5.Text));

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            Label1.Text = "Record Deleted";
           
            loaddata();
        }
    }
}