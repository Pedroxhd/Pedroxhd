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
	public partial class ejercicio1 : Form
	{
		public ejercicio1()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void lblExamen1_Click(object sender, EventArgs e)
		{

		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCalcular_Click(object sender, EventArgs e)
		{
			double calcular;
			calcular = (Convert.ToDouble(txtExamen1.Text) + Convert.ToDouble (txtExamen2.Text) + Convert.ToDouble (txtExamen3.Text)) / 3;
			txtPromedio.Text = String.Format ("{0:N2}", calcular);
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtExamen1.Clear();
			txtExamen2.Clear();
			txtExamen3.Clear();
			txtPromedio.Clear();
		}

		private void txtPromedio_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
