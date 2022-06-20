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
    public partial class Citizen_Service : Form
    {
        Controller controllerObj;
        public Citizen_Service()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectServiceNames();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "S_Name";

        }

		private void button1_Click(object sender, EventArgs e)
		{
            DataTable X = controllerObj.SelectServiceID(comboBox1.Text);
            string Y = X.Rows[0][0].ToString();

            DataTable F = controllerObj.SelectHospitalID(comboBox2.Text);
            string Z = F.Rows[0][0].ToString();



            if (textBox2.TextLength != 14)
            {
                MessageBox.Show("Invalid National ID, National ID must consist of 14 numbers exactly");
            }
            else
            {
                int r = controllerObj.InsertRequest(textBox2.Text, Y, Z);
                 if (r == 0)
                   MessageBox.Show("Request failed");
                else
                    MessageBox.Show("Request Sucessful");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable X = controllerObj.SelectServiceID(comboBox1.Text);
            string ID = X.Rows[0][0].ToString();

            DataTable dt = controllerObj.SelectHospitalService(ID);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "H_Name";



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
