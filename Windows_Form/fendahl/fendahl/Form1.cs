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
using fendahl;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fendahl
{
    public partial class Form1 : Form

    {
        enum Nationality { Indian, NRI } //enum class
        Nationality nationality;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = ProductStore.Gettableproductcategory();
            comboBox1.DataSource = ds.Tables["TableProductCategory"];//combobox code 1
            comboBox1.DisplayMember = "Product_Type_Name";
            comboBox1.ValueMember = "Product_Category_ID";

        }
        int CGST = 0;
        int SGST = 0;
        int IGST = 0;
        int TGST = 0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = ProductStore.Gettableproductname(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "Product_Name";//combobox run code
            comboBox2.ValueMember = "ProductID";
            DataSet ds1 = ProductStore.GetGstDetails(comboBox1.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                CGST = Convert.ToInt32(dr["CGST"].ToString());
                SGST = Convert.ToInt32(dr["SGST"].ToString());
                IGST = Convert.ToInt32(dr["IGST"].ToString());
            }
            if (nationality == 0) //nationality==0 means bydefault indian
            {
                TGST = CGST + SGST;
            }
            else
            {
                TGST = IGST;//nationality==1 means bydefault NRI

            }
            textBox3.Text = CGST.ToString();
            textBox4.Text = SGST.ToString();
            textBox5.Text = IGST.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;
            textBox3.Text = CGST.ToString();
            textBox4.Text = SGST.ToString();
            textBox5.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text));
            calculate_total();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            textBox3.Text = CGST.ToString();
            textBox4.Text = SGST.ToString();
            textBox5.Text = IGST.ToString();
            calculate_total();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds2 = ProductStore.GetProductPrice(comboBox2.Text);
            foreach (DataRow dr in ds2.Tables[0].Rows) //tables[0] me ham table ka nam bhi lekh skte
            {
                textBox9.Text = dr["ProductPrice"].ToString();//table column name
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")//textbox10.text======quantity
            {

            }
            else
            {
                calculate_total();
            }
        }
        public void calculate_total()
        {
            //price * qquantity

            double totalamount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox10.Text);
            textBox11.Text = totalamount.ToString();

            //price*cgst/100
            double CGSTamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox3.Text) / 100.0);
            textBox6.Text = CGSTamount.ToString();

            //price*sgst/100
            double SGSamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox4.Text) / 100.0);
            textBox7.Text = SGSamount.ToString();

            //price*igst/100
            double IGSTamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox5.Text) / 100.0);
            textBox8.Text = IGSTamount.ToString();
            //total price+amount

            double Netamount = 0;
            if (nationality == 0)
            {
                Netamount = Convert.ToDouble(textBox11.Text) + Convert.ToDouble(textBox8.Text);
            }
            else
            {
                Netamount = Convert.ToDouble(textBox11.Text) + Convert.ToDouble(textBox8.Text);
            }
            textBox12.Text = Netamount.ToString();
        }
        //fill quantity ,totalprice and amount textboxes and other




        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //code for save button ..
        private void button1_Click(object sender, EventArgs e)
        {
            checkuserdetails();
        }
        public void checkuserdetails()
        {
                if(textBox1.Text==""||textBox2.Text=="")
            {
                MessageBox.Show("please fill all the details");
            } 
                else if (textBox10.Text=="0")
             {
                MessageBox.Show("quantity cannot be zero");
             }
            else
            {
                string result = ProductStore.saveTableInvoiceDetails(textBox1.Text, textBox2.Text,
                    Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue),
                    Convert.ToInt32(nationality), dateTimePicker1.Value,
                    Convert.ToDecimal(textBox10.Text), Convert.ToDecimal(textBox9.Text),
                    Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text),
                    Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox6.Text),
                    Convert.ToDecimal(textBox7.Text), Convert.ToDecimal(textBox8.Text),
                    Convert.ToDecimal(textBox11.Text));

                MessageBox.Show(result);
            }
        }

        public void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            textBox10.Clear();
            textBox9.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox11.Clear();
            textBox12.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            clearall1();
        }

        public void clearall1()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            textBox10.Clear();
            textBox9.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox11.Clear();
            textBox12.Clear();

        }
    }
}




