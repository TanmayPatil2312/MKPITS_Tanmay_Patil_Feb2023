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
using System.Diagnostics.Eventing.Reader;

namespace static_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DatabaseConnection.GetConnection();
                if(conn != null)
                {
                label1.Text = "Connected Successfully Chote";
                conn.Close();
                }
                else
                {
                    label1.Text = "Unable To Connect Chote";

                }

        }
    }
}
