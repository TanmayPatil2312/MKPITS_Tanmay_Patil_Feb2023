using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movie_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox3.Text = "";
            switch (comboBox1.Text)
            {
                case "The Conjuring 3":
                    comboBox2.Items.Add("VR Cinepolis");
                    comboBox2.Items.Add("PVR Cinemas");
                    break;
                case "The Nunn":
                    comboBox2.Items.Add("Sangam Cinemas");
                    comboBox2.Items.Add("Smruti Cinemas");
                    break;
                case "Fast and Furious 3":
                    comboBox2.Items.Add("Liberty Cinemas");
                    comboBox2.Items.Add("Panchasheel Talkies");
                    break;


            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            comboBox3.Items.Clear();
            switch (comboBox2.Text)
            {
                case "VR Cinepolis":
                    comboBox3.Items.Add("12:00 PM");
                    comboBox3.Items.Add(" 9:00 AM ");
                    textBox1.Text = "100";
                    break;
                case "PVR Cinemas":
                    comboBox3.Items.Add(" 01:30 PM ");
                    comboBox3.Items.Add(" 03:30 PM ");
                    textBox1.Text = "150";


                    break;
                case "Sangam Cinemas":
                    comboBox3.Items.Add(" 04:30 PM ");
                    comboBox3.Items.Add(" 10:20 PM ");
                    textBox1.Text = "200";

                    break;
                case "Smruti Cinemas":
                    comboBox3.Items.Add(" 06:30 PM ");
                    comboBox3.Items.Add(" 08:20 PM ");
                    textBox1.Text = "170";

                    break;
                case "Liberty Cinemas":
                    comboBox3.Items.Add(" 09:30 PM ");
                    comboBox3.Items.Add(" 11:20 PM ");
                    textBox1.Text = "190";

                    break;
                case "Panchasheel Talkies":
                    comboBox3.Items.Add(" 10:30 AM ");
                    comboBox3.Items.Add(" 12:30 PM ");
                    textBox1.Text = "90";

                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Movie_Ticket mt = null;
            if (radioButton1.Checked)
            {
                mt=new Online_Booking(Convert.ToInt32(numericUpDown1.Value),Convert.ToSingle(textBox1.Text));
            }
            if(radioButton2.Checked)
            {
                mt = new Box_Office( Convert.ToInt32(numericUpDown1.Value), Convert.ToSingle(textBox1.Text));

            }
             label7.Text = mt.Calculate_Ticket_Price();
        }
    }
}
