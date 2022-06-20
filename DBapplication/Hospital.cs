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
    public partial class Hospital : Form
    {
        Controller controllerObj;
        public Hospital()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hosp_StaffMembers p = new Hosp_StaffMembers();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hosp_Services p = new Hosp_Services();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hosp_Patients p = new Hosp_Patients();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hosp_Statistics p = new Hosp_Statistics();
            p.Show();
        }

        private void Hospital_Load(object sender, EventArgs e)
        {

        }

        
    }
}
