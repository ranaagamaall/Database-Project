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
    public partial class Hosp_StaffMembers : Form
    {
        Controller objcontroller;
        public Hosp_StaffMembers()
        {
            InitializeComponent();
            objcontroller = new Controller();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox211.Text == "" || textBox212.Text == "" || textBox213.Text == "" || textBox214.Text == "" || textBox215.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Please make sure to fill all required fields");
            }
          
            else if (textBox211.TextLength != 14)
            {
                MessageBox.Show("Invalid National ID, National ID must consist of 14 numbers exactly");
            }
            else
            {
                int r = objcontroller.InsertStaffMember(textBox211.Text, textBox212.Text, textBox213.Text, comboBox1.Text, textBox214.Text, textBox215.Text);
                if (r == 0)
                    MessageBox.Show("Insertion of Staff Member failed");
                else
                    MessageBox.Show("Staff Member is added Succesfully");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox216.Text == "")
            {
                MessageBox.Show("Please make sure to fill the required field");
            }
         
            else if (textBox216.TextLength != 14)
            {
                MessageBox.Show("Invalid National ID, National ID must consist of 14 numbers exactly");
            }
            else
            {
                int r = objcontroller.DeleteStaffMember(textBox216.Text);
                if (r == 0)
                    MessageBox.Show("Deletion of Staff Member failed");
                else
                    MessageBox.Show("Staff Member is Deleted Succesfully");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox218.Text == "" || textBox217.Text == "")
                MessageBox.Show("Please enter all requirements.");
            else
            {
                int result = objcontroller.InsertWorkIn(textBox217.Text, textBox218.Text);
                if (result == 0)
                    MessageBox.Show("Failed to link staff member. Please try again.");
                else
                    MessageBox.Show("Staff member is linked succesfully to the hospital.");
            }
        }

        private void textBox217_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox218_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
