using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            string country = comboBox1.Text;
            // MessageBox.Show(country);
            switch (country)
            {
                case "INDIA":
                    comboBox2.Items.Add("Mumbai");
                    comboBox2.Items.Add("Pune");
                    comboBox2.Items.Add("Goa");
                    comboBox2.Items.Add("Bangalore");
                    break;
                case "USA":
                    comboBox2.Items.Add("Philadelphia");
                    comboBox2.Items.Add("San Antonio");
                    comboBox2.Items.Add("San Diego");
                    break;
                case "UK":
                    comboBox2.Items.Add("Derby");
                    comboBox2.Items.Add("London");
                    comboBox2.Items.Add("Leicester");
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SetSelected(0, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "Country : " + comboBox1.Text + "\n";
            label4.Text += "City : " + comboBox2.Text + "\n";

            label4.Text += "Travel Package : " + listBox1.SelectedItem.ToString() + "\n";

        }

        
    }
}