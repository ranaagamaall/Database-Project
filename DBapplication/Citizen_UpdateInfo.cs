using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Citizen_UpdateInfo : Form
    {
        Controller controllerObj;
        public Citizen_UpdateInfo()
        {
            InitializeComponent();
        }
        private void Citizen_UpdateInfo_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }
        private void button1_Click(object sender, EventArgs e)
        {
                if (textBox1.Text == "" || textBox2.Text == "")//validation part

                MessageBox.Show("Please insert all requirements.");

          
                else if (textBox1.TextLength != 14)
                {
                    MessageBox.Show("Invalid National ID, National ID must consist of 14 numbers exactly");
                }
                else
                {
                int result = controllerObj.UpdateCitizenPassword(textBox1.Text.ToString(), textBox2.Text);
                    if (result == 0)
                    {
                    MessageBox.Show("Failed to update password.");
                    }
                    else
                    {
                    MessageBox.Show("Password is updated successfully");
                    }
                }
        }

	}
}
