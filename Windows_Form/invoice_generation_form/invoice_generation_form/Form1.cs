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
        public Form1()
        {
            InitializeComponent();
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
            listBox1.DisplayMember= "Name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = invoice_generation.Getproductname(listBox1.Text);
            foreach(DataSet dr in ds1.Tables[0].Rows)
            {
                textBox1.Text = dr["NAME"].ToString();
                textBox2.Text = dr["AVAILABLE_QTY"].ToString();
                textBox3.Text = dr["SELL_QTY"].ToString();
                textBox4.Text = dr["PRICE_PER_UNIT"].ToString();
            }
        }
    }
}
