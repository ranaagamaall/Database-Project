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
    public partial class Government : Form
    {
        public Government()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gov_AddFacilities p = new Gov_AddFacilities();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gov_Vaccines p = new Gov_Vaccines();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gov_Statistics p = new Gov_Statistics();
            p.Show();
        }
    }
}
