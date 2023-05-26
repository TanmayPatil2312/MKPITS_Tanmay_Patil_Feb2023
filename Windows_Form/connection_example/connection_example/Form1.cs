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

namespace connection_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creating string
            string constr = "server=TANMAY\\SQLEXPRESS;database=connection_example1;" +
                "integrated security=true;";
            // creating connection
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                label1.Text = "Connection successfull";
            }
            catch(Exception ee)
            {
                label1.Text = ee.ToString();
            }
            finally 
            { 
                conn.Close(); 
            }
        }

    }
}
