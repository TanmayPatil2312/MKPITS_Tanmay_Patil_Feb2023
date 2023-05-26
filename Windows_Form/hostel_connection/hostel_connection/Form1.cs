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

namespace hostel_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = DatabaseConnection.InsertRecord(textBox1.Text, textBox2.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = DatabaseConnection.UpdateRecord(textBox1.Text, textBox2.Text);

        }
        public void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = DatabaseConnection.DeleteUser(textBox1.Text);
            clearall();

        }
    }
}
