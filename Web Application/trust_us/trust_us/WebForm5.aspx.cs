using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace trust_us
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=trust_me");
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            string str = null;

            if(RadioButton1.Checked)
            {
                Label3.Visible = true;
                DropDownList2.Visible = true;
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = null;
            SqlConnection conn = new SqlConnection("server=TANMAY\\SQLEXPRESS;integrated security=true;database=trust_me");
            SqlCommand command;
            if (RadioButton1.Checked)
            {
                try
                {
                    query = "insert into Transactions (item_id,transaction_date,Department_id,Quantity)";
                    command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@item_id", DropDownList1.SelectedValue);
                    command.Parameters.AddWithValue("@transaction_date", TextBox10.Text);
                    command.Parameters.AddWithValue("@Department_id", DropDownList2.SelectedValue);
                    command.Parameters.AddWithValue("@Quantity", TextBox9.Text);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                    //code to get balance_quantity from Item_Master table

                    int bal_qty = 0;
                    query = "select balance_quantity from Item_Master where Item_Id=@Item_Id";
                    command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Item_Id", DropDownList1.SelectedValue);
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        bal_qty = Convert.ToInt32(reader[0].ToString());
                    }

                    reader.Close();
                    conn.Close();
                    //response.Write("bal_qty" + bal_qty.ToString());
                    int qty = bal_qty - Convert.ToInt32(TextBox9.Text);
                    ///  code is pending please complete it 



            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Label3.Visible = true;
            DropDownList2.Visible = true;
            Label2.Visible = false;
            DropDownList1.Visible = false;

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {


            Label3.Visible = false;
            DropDownList2.Visible = false;
            Label2.Visible = true;
            DropDownList1.Visible = true;
        }
    }
}