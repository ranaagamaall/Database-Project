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
	public partial class Hosp_Patients : Form
	{
		Controller controllerObj;
		public Hosp_Patients()
		{
			InitializeComponent();
		}

		private void Hosp_Patients_Load(object sender, EventArgs e)
		{
			controllerObj = new Controller();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DataTable dt = controllerObj.SelectAllPatients();
			dataGridView1.DataSource = dt;
			dataGridView1.Refresh();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
				MessageBox.Show("Please enter all requirements.");
			else
			{
				int result = controllerObj.InsertPatient(textBox1.Text, comboBox1.Text, comboBox2.Text, checkBox1.Checked);
				if (result == 0)
					MessageBox.Show("Failed to add patient.");
				else
					MessageBox.Show("Patient Entered Successfully.");
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{



		}

		private void button5_Click(object sender, EventArgs e)
		{
			DataTable dt = controllerObj.SelectACitizen(textBox5.Text);
			dataGridView2.DataSource = dt;
			dataGridView2.Refresh();

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			controllerObj.UpdateAvailability(checkBox1.Checked);
		}

		private void button4_Click_1(object sender, EventArgs e)
		{
			if (textBox2.Text == "")
				MessageBox.Show("Please enter National ID to delete the patient.");
			else
			{
				int result = controllerObj.DeletePatient(textBox2.Text.ToString());
				if (result == 0)
					MessageBox.Show("Failed to delete patient.");
				else
					MessageBox.Show("Patient deleted successfully.");
			}
		}
	}
}
