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
    public partial class Gov_Vaccines : Form
    {
        Controller objcontroller;
        public Gov_Vaccines()
        {
            InitializeComponent();
            objcontroller = new Controller();
        }

        private void Gov_Vaccines_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox322.Text == "" || textBox321.Text == "" || textBox323.Text == "" || textBox324.Text == "" || textBox325.Text == "")
            {
                MessageBox.Show("Please make sure to fill all required fields");
            }
           
            else if (!(int.TryParse(textBox324.Text, out int re2)))
            {
                MessageBox.Show("Please Insert numbers only in the Amount Textbox");
            }
            else if (!(int.TryParse(textBox325.Text, out int re3)))
            {
                MessageBox.Show("Please Insert numbers/integers only in the Doses Textbox");
            }
            else if (textBox322.TextLength != 2)
            {
                MessageBox.Show("Invalid Vaccine ID, Vaccine ID must consist of 2 numbers exactly");
            }
            else
            {
                int r = objcontroller.InsertVaccine(textBox322.Text, textBox321.Text, textBox323.Text, Int16.Parse(textBox324.Text), Int16.Parse(textBox325.Text));
                if (r == 0)
                    MessageBox.Show("Insertion of Vaccine Failed");
                else
                    MessageBox.Show("Vaccine Inserted Succesfully");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox326.Text == "" || textBox327.Text == "")
            {
                MessageBox.Show("Please make sure to fill all required fields");
            }
            
            else if (!(int.TryParse(textBox327.Text, out int re2)))
            {
                MessageBox.Show("Please Insert numbers only in the Amount Textbox");
            }
            else if (textBox326.TextLength != 2)
            {
                MessageBox.Show("Invalid Vaccine ID, Vaccine ID must consist of 2 numbers exactly");
            }
            else
            {
                int r = objcontroller.UpdateVaccine(textBox326.Text, Int32.Parse(textBox327.Text));
                if (r == 0)
                    MessageBox.Show("Updated Failed");
                else
                    MessageBox.Show("Update Succesfully");
            }
        }
    }
}
