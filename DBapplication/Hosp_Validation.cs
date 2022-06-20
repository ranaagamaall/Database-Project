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
    public partial class Hosp_Validation : Form
    {
        Controller objcontroller;
        public Hosp_Validation()
        {
            InitializeComponent();
            objcontroller = new Controller();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" )
            {
                MessageBox.Show("Please, Insert all values");
            }

            else
            {
                DataTable X = objcontroller.SelectPassCode(textBox1.Text);

                string Y = X.Rows[0][0].ToString();

                if (Y == textBox2.Text)
                {
                    objcontroller.SetHospital(textBox1.Text);
                    Hospital v = new Hospital();
                    v.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect PassCode");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
