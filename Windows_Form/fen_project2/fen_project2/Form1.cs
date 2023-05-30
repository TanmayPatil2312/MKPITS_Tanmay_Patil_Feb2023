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

        enum SelectCategory { Student, ITProfessionl }  // 0= student and 1=IT Professional  // enum is a declaration in which it allow only two parameters only 
        SelectCategory category;

        enum Gender { Male, Female, Other }  // 0=male 1=female 2=other 
        Gender gender;

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
            comboBox1.ValueMember = "NationID";
            textBox2.Text = "1000";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = CourseRegistration.Getstatename(comboBox1.Text); //from nationname we have to go to state name 
            comboBox2.DataSource = ds.Tables["TableState"]; // in this line from the table we need the data that table name is written 
            comboBox2.DisplayMember = "StateName";// this is column name because we want state name list in combobbox2
            comboBox2.ValueMember = "StateID";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = CourseRegistration.Getcityname(comboBox2.Text); // from statename we have to go to city name 
            comboBox3.DataSource = ds.Tables["TableCity"]; // int this line  from the table we need the data that table name is written 
            comboBox3.DisplayMember = "CityName"; //in this line written the column name because we want city name list in combobox3 
            comboBox3.ValueMember = "CityID";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox3.Clear();
                textBox4.Clear();
                category = SelectCategory.Student;
                textBox2.Text = "1000";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)  // In this we are telling the user the if you are the IT professional
            {
                textBox3.Clear();
                textBox4.Clear();
                category = SelectCategory.ITProfessionl;
                textBox2.Text = "3000";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            check_balance_amount(); //method to call calculation 
        }
        double total = 0;
        double fp = 0;
        double bal_amount = 0;
        public void check_balance_amount()
        {
            double paid = Convert.ToDouble(textBox3.Text);
             total = Convert.ToDouble(textBox2.Text); // In this we are calculating balance amount using this code and bal amt = total amt - paid amt .
             fp = 0;  // fp is a fifity percent delcared for the calculation 
            if (category == 0)
            {
                fp = total * 0.5;
            }
            else
            {
                fp = total * 0.8;
            }
            if (Convert.ToDouble(textBox3.Text) < fp)
            {
                MessageBox.Show("Paid Amount Should be at least 50% for Students and for IT Professionals 80%");

            }
            else if (paid > total)
            {
                MessageBox.Show("paid amount should not be greater than total amount ");
            }
            else
            {
                bal_amount = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox3.Text);
                textBox4.Text = bal_amount.ToString();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //this area of code is written because in textbox3 only user should enter numbers and if user enter characters the box should not accept the character in it .
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // this area of code is written because in textbox3 only user should enter numbers and if user enter characters the box should not accept the character in it .
            {
                e.Handled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                gender = Gender.Male;  // 0 
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                gender = Gender.Female; // 1
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                gender = Gender.Female;   // 2 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = CourseRegistration.savetablecourseregdetaill(Convert.ToInt32(category), textBox1.Text, Convert.ToInt32(gender));
            MessageBox.Show(result);


            // for 5 table record insertion 
            result = CourseRegistration.tableregaddress1(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue));
            MessageBox.Show(result);

            result = CourseRegistration.savetablefeedetail1(Convert.ToDouble(textBox2.Text), fp, Convert.ToInt32(textBox3.Text), Convert.ToDouble(textBox4.Text), dateTimePicker1.Value);
            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearall(); // this is the method written for to clear all fields of the form 
        }
        public void clearall()
        {
            textBox1.Clear(); // to clear the previous entered text. 
            textBox2.Clear(); //to clear the previous entered text.
            textBox3.Clear(); //to clear the previous entered text. 
            textBox4.Clear();  // to clear the previous entered text.
            comboBox1.Text = ""; //to clear the previous selected option of combobox 
            comboBox2.Text = "";  //to clear the previous selected option of combobox 
            comboBox3.Text = "";  //to clear the previous selected option of combobox 
        }
    }
}
