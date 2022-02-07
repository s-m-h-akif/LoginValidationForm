using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginValidationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if(textBox_name.Text == " ")
            {
                label_nameWarning.Visible = true;
                MessageBox.Show("Enter UserName");
            }
            if(textBox_password.Text == " ")
            {
                label_passwordWarning.Visible = true;
                MessageBox.Show("Enter password");
            }
            else if(!Regex.Match(textBox_name.Text,"^[a-zA-Z]*$").Success)
            {
                MessageBox.Show("Number is not Allowed");
                textBox_name.Focus();
            }
            else if(textBox_password.Text == "admin")
            {
                label_nameWarning.Visible = false;
                label_passwordWarning.Visible=false;

                this.Hide();
                MdiForm mdi = new MdiForm();
                mdi.Show();

            }
        }
    }
}
