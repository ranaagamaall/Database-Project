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
    public partial class Hosp_Services : Form
    {
		Controller controllerObj;
        public Hosp_Services()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectServiceNames();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "S_Name";

        }

        private void Hosp_Services_Load(object sender, EventArgs e)
		{
			controllerObj = new Controller();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DataTable dt = controllerObj.SelectAllServices();
			dataGridView1.DataSource = dt;
			dataGridView1.Refresh();
		}

        private void button1_Click_1(object sender, EventArgs e)
        {
			DataTable dt = controllerObj.SelectAllServices();
			dataGridView1.DataSource = dt;
			dataGridView1.Refresh();
		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable X = controllerObj.SelectServiceID(comboBox1.Text);
            string Y = X.Rows[0][0].ToString();

            int r = controllerObj.InsertOfferedBy(textBox1.Text, Y);
            if (r == 0)
                MessageBox.Show("Service failed to link");
            else
                MessageBox.Show("Service Link to hospital");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int r = controllerObj.DeleteRequest(textBox2.Text);
            if (r == 0)
                MessageBox.Show("Request Not Accepted");
            else
                MessageBox.Show("Request Accepted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectPatientRequest();
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
        }
    }
}
