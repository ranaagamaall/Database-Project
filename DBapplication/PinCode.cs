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
    public partial class PinCode : Form
    {
        public PinCode()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please insert the Pincode");
            }
            else
            {

                        if (Int16.Parse(textBox1.Text) == 00000)
                        {
                            Government p = new Government();
                            p.Show();
                        }
                        else
                        {
                            MessageBox.Show("Wrong PinCode");
                        }
            }
        }
    }
}
