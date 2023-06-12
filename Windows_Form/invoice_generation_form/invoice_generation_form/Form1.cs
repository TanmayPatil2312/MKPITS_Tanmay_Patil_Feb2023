using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace invoice_generation_form
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable("table");

        enum paymentmode { cash, EMI }
        paymentmode mode;
        enum Gender { Male, Female, Other }
        Gender gender;

        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = invoice_generation.Getname();
            listBox1.DataSource = ds.Tables[0];
            listBox1.DisplayMember = "Name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems != null)
            {
                string selectedValue = listBox1.SelectedItems[0].ToString();
            }
            DataSet ds1 = invoice_generation.Getproductname(listBox1.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                textBox1.Text = dr["NAME"].ToString();

                textBox2.Text = dr["AVAILABLE_QTY"].ToString();
                textBox3.Text = dr["SELL_QTY"].ToString();
                textBox4.Text = dr["PRICE_PER_UNIT"].ToString();

                textBox5.Text = textBox3.Text; //quantity required  = total quantity
                textBox6.Text = textBox4.Text; //total price = price 
            }
            DataSet ds2 = invoice_generation.Getcgst(listBox1.Text);
            foreach (DataRow dr in ds2.Tables[0].Rows)
            {
                textBox7.Text = dr["cgst"].ToString();
                textBox8.Text = dr["sgst"].ToString();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBox6.Text) * Convert.ToDouble(textBox7.Text) / 100.0;
            //total price * quantity required /100
            textBox9.Text= amount.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBox6.Text) * Convert.ToDouble(textBox8.Text) / 100.0;
            textBox10.Text= amount.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox14.Clear();
            textBox15.Clear();
            if (radioButton4.Checked)
            {
                textBox14.Clear();

                mode = paymentmode.cash;
                textBox14.Text = textBox6.Text;
            }

            double netamount = Convert.ToDouble(textBox6.Text) + Convert.ToDouble(textBox10.Text);
            textBox15.Text=netamount.ToString();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox14.Clear();
            textBox15.Clear();
            //grid view ();

            //public void gridview()
           // { 
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
           

            //mode = paymentmode.EMI;
            //if(radioButton5.Checked)
            //{
            //    decimal EMI = Convert.ToDecimal(textBox15.Text) / 3;
            //    dataGridView1.DataSource = EMI;
            //    dataGridView1.DataSource = dt;
            //    for(int i=0;i<2;i++)
            //    {
            //        dt.Rows.Add(EMI);
            //    }
            //    dataGridView1.DataSource = EMI;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = null;
            if(radioButton1.Checked)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                gender = "female";
            }
            string result = invoice_generation.Getcustomer(textBox11.Text, textBox12.Text, gender, textBox13.Text, Convert.ToDecimal(textBox14.Text));
            MessageBox.Show(result);
        }

        private void textBox14_Leave(object sender, EventArgs e)
        {
            mode = paymentmode.EMI;
            double total = Convert.ToDouble(textBox6.Text);
            double paid = Convert.ToDouble(textBox14.Text);
            if (paid > total)
            {
                MessageBox.Show("paid amount not greater than total amount");
            }
            else
            {
                double netamount = Convert.ToDouble(textBox6.Text) - Convert.ToDouble(textBox14.Text);
                textBox15.Text = netamount.ToString();
            }
        }
    }
}
