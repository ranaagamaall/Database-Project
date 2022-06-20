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
    public partial class Citizen : Form
    {
        Controller objcontroller;
        public Citizen()
        {
            InitializeComponent();
            objcontroller = new Controller();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register p = new Register();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please, Insert all values");
            }
            else if (textBox1.TextLength != 14)
            {
                MessageBox.Show("Invalid National ID, National ID must consist of 14 numbers exactly");
            }
            else
            {
                DataTable X = objcontroller.SelectPass(textBox1.Text);

                string Y = X.Rows[0][0].ToString();

                if (Y == textBox2.Text)
                {
                    CitizenFunctions p = new CitizenFunctions();
                    p.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
