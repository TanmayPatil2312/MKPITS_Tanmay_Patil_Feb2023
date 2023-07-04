using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLoginDetails.show();
            //using (FormLoginDetails Fd=new FormLoginDetails())
            //{
            //    this.Fd.show();
            //}
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetAll();
        }
        private void ResetAll()
        {
            textBoxName.Clear();
            textBoxAge.Clear();
            textBoxMobileNumber.Clear();
        }
    }
}
