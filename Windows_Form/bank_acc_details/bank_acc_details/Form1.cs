using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_acc_details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int bal = 1000;
        private void Deposit_Click(object sender, EventArgs e)
        {
            int amt = Convert.ToInt32(textBox2.Text);
            if (amt > 0)
            {
                bal = bal + amt;
                label3.Text = " Amount deposited  & Bal is " + bal;
            }
            else
            {
                label3.Text = " Enter amount greater than ";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int amt=Convert.ToInt32(textBox2.Text);
            if (amt<=bal)
            {
                bal = bal - amt;
                label3.Text = "Amount with bal is  " + bal;
            }
            else
            {
                label3.Text = "Insufficient Fund";
            }
        }
    }
}

