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
    public partial class Gov_AddFacilities : Form
    {
        Controller objcontroller;
        public Gov_AddFacilities()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox32.Text == "" || textBox31.Text == "" || textBox33.Text == "" || textBox34.Text == "" || textBox35.Text == "")
            {
                MessageBox.Show("Please, Insert all values");
            }
            
            else if (textBox32.TextLength != 6)
            {
                MessageBox.Show("Invalid Hospital ID, Hospital ID must consist of 6 numbers exactly");
            }
            else if (textBox35.TextLength != 4)
            {
                MessageBox.Show("Invalid Hospital Passcode, Hospital Passcode must consist of 4 numbers exactly");
            }
            else
            {
                int r = objcontroller.InsertHospital(textBox32.Text, textBox31.Text, textBox33.Text, Int32.Parse(textBox34.Text), checkBox1.Checked, Int32.Parse(textBox35.Text));
                if (r == 0)
                    MessageBox.Show("Insertion of Hospital failed");
                else
                    MessageBox.Show("Hospital Added Succesfully");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox36.Text == "" || textBox37.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Please, Insert all values");
            }
            
            else if (textBox37.TextLength != 4)
            {
                MessageBox.Show("Invalid Service ID, Service ID must consist of 4 numbers exactly");
            }
            else
            {
                int r = objcontroller.InsertService(textBox36.Text, textBox37.Text, comboBox1.Text);
                if (r == 0)
                    MessageBox.Show("Insertion of Service Failed");
                else
                    MessageBox.Show("Service Added Succesfully");
            }
        }

        private void Gov_AddFacilities_Load(object sender, EventArgs e)
        {
            objcontroller = new Controller();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int r = objcontroller.InsuranceCompany(textBox66.Text, textBox67.Text, float.Parse(textBox68.Text));
            if (r == 0)
                MessageBox.Show("Insertion of Insurance Company Failed");
            else
                MessageBox.Show("Insertion is added Succesfully");
        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox67_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
