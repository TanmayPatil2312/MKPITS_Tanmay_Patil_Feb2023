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
using System.Security.Cryptography.X509Certificates;

namespace bike_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            // // connected environment form code 
            //SqlDataReader dr = DatabaseConnection.GetCity();
            // while (dr.Read())
            // {
            //     comboBox1.Items.Add(dr["cityname"].ToString());
            // }
            // //

           
           // disconnected environment city code  (this will help us to automatically connected or diconnect the data from the db 
            DataSet ds = DatabaseConnection.GetCity();
            foreach (DataRow dr in ds.Tables["city"].Rows) 
            {
                comboBox1.Items.Add(dr["cityname"].ToString());
            }
            //

            //data grid view code 
           DataSet dss = DatabaseConnection.InternDetails();
            dataGridView1.DataSource = dss.Tables["users"];



        }

        public void clearall()
        {
            textBox3.Clear();
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = " ";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = null;
            result = DatabaseConnection.insertrecord(textBox3.Text, textBox1.Text,textBox2.Text);
            label3.Text = result;
            clearall();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = DatabaseConnection.updaterecord(textBox1.Text, textBox2.Text);
            clearall();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text= DatabaseConnection.deleterecord(textBox1.Text);
            clearall();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds = DatabaseConnection.searchinterndetail(textBox3.Text);
            dataGridView1.DataSource = ds.Tables["users"];
            textBox1.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString(); // to start with first row we entered the array from 1 
            textBox2.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            comboBox1.Text= ds.Tables[0].Rows[0].ItemArray[3].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearall();

        }
    }
}
