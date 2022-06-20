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
    public partial class Register : Form
    {
        Controller objcontroller;
        public Register()
        {
            InitializeComponent();
            objcontroller = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox17.Text== "" || textBox19.Text== "")
                MessageBox.Show("Please enter the requirements.");
            else
            {
                int result = objcontroller.InsertCitizen(textBox11.Text, textBox12.Text, textBox13.Text, Int16.Parse(textBox14.Text), textBox15.Text, textBox16.Text, checkBox1.Checked, Int16.Parse(textBox17.Text), textBox19.Text);
                if (result == 0)
                    MessageBox.Show("Failed to add patient. Please try again.");
                else
                    MessageBox.Show("Patient added successfully.");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

		private void textBox11_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
