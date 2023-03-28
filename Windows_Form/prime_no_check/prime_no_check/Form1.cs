using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prime_no_check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num=Convert.ToInt32(textBox1.Text);
            int counter = 0;
            int isprime = 0;

            for(counter=2;counter<num;counter++)
            {
                if(num%counter==0)
                {
                    isprime = 1;
                    break;
                }
            }
            if(isprime==0)
            {
                label3.Text = "Number is prime no. :- " + num;
            }
            else 
            {
                label3.Text = " Number is not a prime no. :-" + num;
            }
        }
    }
}
