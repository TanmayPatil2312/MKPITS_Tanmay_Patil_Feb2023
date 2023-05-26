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

namespace fen_project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = CourseRegistration.Getnationname();
            comboBox1.DataSource = ds.Tables["TableNation"]; // in this table name is written 
            comboBox1.DisplayMember = "NationName"; //in this we want the data of column i.e column name we have to write .

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = CourseRegistration.Getstatename(comboBox1.Text); //from nationname we have to go to state name 
            comboBox2.DataSource = ds.Tables["TableState"]; // in this line from the table we need the data that table name is written 
            comboBox2.DisplayMember = "StateName";// this is column name because we want state name list in combobbox2

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = CourseRegistration.Getcityname(comboBox2.Text); // from statename we have to go to city name 
            comboBox3.DataSource = ds.Tables["TableCity"]; // int this line  from the table we need the data that table name is written 
            comboBox3.DisplayMember = "CityName"; //in this line written the column name because we want city name list in combobox3 
        }
    }
}
