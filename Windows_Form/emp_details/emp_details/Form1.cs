using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emp_details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int basicsalary, hra, da, totalsalary;
            string empname;
            empname = (textBox1.Text);
            basicsalary=Convert.ToInt32(textBox2.Text);

            hra = (basicsalary * 35) / 100;
            label4.Text = " HRA is :- " + hra;

            da = (basicsalary * 45) / 100;
            label5.Text = " DA is :- " + da;

            totalsalary = basicsalary + hra + da;
            label6.Text = " Total salary is :- " + totalsalary;
        }
    }
}
