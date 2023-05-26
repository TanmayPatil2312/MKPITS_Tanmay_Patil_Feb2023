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

using System.Data;

namespace hostel_connection
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlDataReader dr = EmployeeDetails.GetCity();
            //            //reading the records from sqldatareader

            while(dr.Read())
            {
                comboBox1.Items.Add(dr["cityname"].ToString()); 
            }
        }
    }
}
