using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stud_Result
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, total;
            s1= Convert.ToInt32(textBox1.Text);
            s2= Convert.ToInt32(textBox2.Text);
            s3= Convert.ToInt32(textBox3.Text);
            total = s1 + s2 + s3;
            label4.Text = " Total :- " + total;

            float per = (total / 300.0f) * 100.0f;
            label5.Text = " Percentage :-" + total;

            if(per>=75)
            {
                label6.Text = " Distinction";
            }
            else if (per>=60 && per<75)
            {
                label6.Text = " Mharo choro Pass with 'First Class' ";

            }
            else
            {
                label6.Text = " Mharo Choro 'Fail' Hue gavaa  ";
            }
        }
    }
}
