﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acc_with_polymorphism_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            account act = null;
            string Acttype;
            Acttype = Convert.ToString(comboBox1.Text);
            if (Acttype == "saving")
            {
                act = new saving();
                int result = act.deposit(Convert.ToInt32(textBox2.Text));

                label5.Text = Convert.ToString("balance:-" + result);
            }
            else if (Acttype == "current")
            {
                act = new current();
                int result = act.deposit(Convert.ToInt32(textBox2.Text));
                label5.Text = Convert.ToString("balance:-" + result);
            }
        
        }

        
    }
}
