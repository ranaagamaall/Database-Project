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
    public partial class Provided_Functionalities : Form
    {
       
        public Provided_Functionalities(int a)
        {
            InitializeComponent();
            if (a == 1) 
            {
                this.button1.Enabled = false;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Hosp_Validation v = new Hosp_Validation();
            v.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Citizen p = new Citizen();
            p.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PinCode p = new PinCode();
            p.Show();
        }
    }
}
