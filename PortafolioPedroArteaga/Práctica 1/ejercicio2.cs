using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace práctica_1_pa
{
	public partial class ejercicio2 : Form
	{
		public ejercicio2()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			txtBinario.Text = Convert.ToString(Convert.ToInt32(txtDecimal.Text), 2);
			txtOctal.Text = Convert.ToString(Convert.ToInt32(txtDecimal.Text), 8);
			txtHexadecimal.Text = Convert.ToString(Convert.ToInt32(txtDecimal.Text), 16);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			txtDecimal.Clear();
			txtBinario.Clear();
			txtOctal.Clear();
			txtHexadecimal.Clear();
		}

		private void lblHexadecimal_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
