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

namespace fendahl_revision
{
    public partial class Form1 : Form
    {
        
            enum Nationality { Indian, NRI }
        Nationality nationality;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = productstore.Getproductcategory();
            comboBox1.DataSource= ds.Tables[0];
            comboBox1.DisplayMember= "Product_Type_Name";
            comboBox1.ValueMember = "Product_Category_Id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = productstore.Getproductname(comboBox1.Text);
            comboBox2.DataSource= ds.Tables[0];
            comboBox2.DisplayMember= "Product_Name";
            comboBox2.ValueMember= "ProductId";

            DataSet ds1 = productstore.Getproductgstdetail(comboBox1.Text);

        }
    }

        /*private void Form1_Load(object sender, EventArgs e)
        {
       
        }*/
   
}
