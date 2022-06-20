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
    public partial class CitizenFunctions : Form
    {
        public CitizenFunctions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Citizen_Service p = new Citizen_Service();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Citizen_Patient p = new Citizen_Patient();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Citizen_UpdateInfo p = new Citizen_UpdateInfo();
            p.Show();
        }
    }
}
