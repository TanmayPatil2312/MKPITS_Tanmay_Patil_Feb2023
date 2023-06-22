using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace drivenit
{
    public partial class Transaction : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("server=TANMAY\\SQLEXPRESS;integrated security=true;database=drivenitDB");
        SqlCommand command = null;
        string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                str = "insert into Transactions values(@ItemID,@TransType,@TransQty,@TransDate)";
                command = new SqlCommand(str, conn);
                command.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                string transt = null;
                if (RadioButton1.Checked)
                {
                    transt = "I";
                }
                else if (RadioButton2.Checked)
                {
                    transt = "R";
                }
                command.Parameters.AddWithValue("@TransType", transt);
                command.Parameters.AddWithValue("@TransQty", Convert.ToInt32(TextBox1.Text));
                command.Parameters.AddWithValue("@TransDate", TextBox2.Text);
                conn.Open();
                command.ExecuteNonQuery();

                // getting the balqty from itemmaster table for particular item id
                str = "select max(BaLQty) from ItemMaster where ItemID=@ItemID";
                command = new SqlCommand(str, conn);
                command.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(command.ExecuteScalar());
                if (transt == "I")
                {
                    bq = bq - Convert.ToInt32(TextBox1.Text);
                }
                else if (transt == "R")
                {
                    bq = bq + Convert.ToInt32(TextBox1.Text);
                }

                // updating bal qty on item master table
                str = "update ItemMaster set BalQty=@BalQty where ItemID=@ItemID";
                command = new SqlCommand(str, conn);
                command.Parameters.AddWithValue("@BalQty", bq);
                command.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                command.ExecuteNonQuery();

                Label1.Text = "record saved";
            }
            catch (Exception ex)
            {

                Label1.Text = ex.ToString();
            }
            finally
            {
                conn.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int updatedqty = 0;

            Response.Write("transaction id" + transid.ToString());
            updatedqty = Convert.ToInt32(TextBox1.Text) - oldtransqty;

            Response.Write("updated qty" + updatedqty.ToString());
            try
            {
                str = "update Transactions set TransType=@TransType,TransQty=@TransQty,TransDate=@TransDate where TransID=@TransID";
                command = new SqlCommand(str, conn);

                string transt = null;
                if (RadioButton1.Checked)
                {
                    transt = "I";
                }
                else if (RadioButton2.Checked)
                {

                    transt = "R";
                }
                command.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                command.Parameters.AddWithValue("@TransType", transt);
                command.Parameters.AddWithValue("@TransQty", Convert.ToInt32(TextBox1.Text));
                command.Parameters.AddWithValue("@TransDate", TextBox2.Text);
                command.Parameters.AddWithValue("@TransId", transid);

                conn.Open();
                command.ExecuteNonQuery();

                //getting the balqty from itemmaster table for particular item id
                str = "select max(BalQty) from ItemMaster where ItemID=@ItemID";
                command = new SqlCommand(str, conn);
                command.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(command.ExecuteScalar());
                Response.Write("bq " + bq.ToString());
                Response.Write("updateqty " + updatedqty.ToString());
                if (RadioButton1.Checked)
                    bq = bq - updatedqty;
                if (RadioButton2.Checked)
                    bq = bq + updatedqty;

                Response.Write("<br>newupdateqty " + bq.ToString());
                if (bq < 0)
                {
                    Label1.Text = "stock not available";
                }
                else
                {



                    //if (transt == "I")
                    //{
                    //    bq = bq - Convert.ToInt32(TextBox1.Text);
                    //}
                    //else if (transt == "R")
                    //{
                    //    bq = bq + Convert.ToInt32(TextBox1.Text);
                    //}

                    //updating bal qty on item master table
                    str = "update ItemMaster set BalQty=@BalQty where ItemID=@ItemID";
                    command = new SqlCommand(str, conn);
                    command.Parameters.AddWithValue("@BalQty", bq);
                    command.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                    command.ExecuteNonQuery();

                    Label1.Text = "record updated successfully";
                }
            }
            catch (Exception ex)
            {

                Label1.Text = ex.ToString();
            }

            finally
            {
                conn.Close();
            }

        }

        static int transid = 0;
        static int oldtransqty = 0;
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[4].Text;

            DateTime dd = Convert.ToDateTime(GridView1.SelectedRow.Cells[5].Text);
            TextBox2.Text = dd.ToString("yyyy-MM-dd");

            DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[2].Text;

            string res = GridView1.SelectedRow.Cells[3].Text;
            if (res == "I")
            {
                RadioButton1.Checked = true;
                RadioButton2.Checked = false;
            }
            if (res == "R")
            {
                RadioButton2.Checked = true;
                RadioButton1.Checked = false;
            }
            transid = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[4].Text;
            oldtransqty = Convert.ToInt32(TextBox1.Text);
            DateTime dd = Convert.ToDateTime(GridView1.SelectedRow.Cells[5].Text);
            TextBox2.Text = dd.ToString("yyyy-MM-dd");
            DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[1].Text;

            string res = GridView1.SelectedRow.Cells[3].Text;
            if (res == "I")
            {
                RadioButton2.Checked = false;
                RadioButton1.Checked = true;
            }
            if (res == "R")
            {
                RadioButton1.Checked = false;
                RadioButton2.Checked = true;

            }
            transid = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);

        }
    }
}
