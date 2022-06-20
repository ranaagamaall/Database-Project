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
    public partial class Citizen_Patient : Form
    {
        Controller objcontroller;
        public Citizen_Patient()
        {
            InitializeComponent();
            objcontroller = new Controller();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox121.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please make sure to fill all required fields");
            }
       
            else if (textBox121.TextLength != 14)
            {
                MessageBox.Show("Invalid National ID, National ID must consist of 14 numbers exactly");
            }
            else
            {
                int r = objcontroller.InsertPatient(textBox121.Text, comboBox2.Text, comboBox1.Text, checkBox1.Checked);
                if (r == 0)
                    MessageBox.Show("Insertion of patient failed");
                else
                    MessageBox.Show("Patient Added Succesfully");
            }
        }

		private void Citizen_Patient_Load(object sender, EventArgs e)
		{

		}
	}
}
