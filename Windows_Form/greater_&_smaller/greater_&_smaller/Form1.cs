using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace greater___smaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1=Convert.ToInt32(textBox1.Text);
            int n2=Convert.ToInt32(textBox2.Text);
            if(n1>n2)
            {
                label3.Text = " Number 1 is Big Daddy";
            }
            else
            {
                label3.Text = "Number 2 is Big Daddy ";
            }
            if (n1 >= n2)
            {
                label3.Text = "Both Number are Equal";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox1.Text);
            int n2 = Convert.ToInt32(textBox2.Text);
            if (n1 < n2)
            {
                label3.Text = " Number 1 is Small Daddy";
            }
            else
            {
                label3.Text = "Number 2 is Small Daddy ";
            }
            if(n1<=n2)
            {
                label3.Text = "Both Number are Equal";
            }
        }
    }
}
