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
    public partial class ejercicio3 : Form
    {
        public ejercicio3()
        {
            InitializeComponent();
        }

        private void ejercicio3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txtPorcentaje1.Clear();
            txtPorcentaje2.Clear();
            txtPorcentaje3.Clear();
            txtTotal.Clear();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCacular_Click(object sender, EventArgs e)
        {
            double calcular = Convert.ToDouble(txt1.Text) + Convert.ToDouble(txt2.Text) + Convert.ToDouble(txt3.Text);
            txtTotal.Text = string.Format("{0:C2}", calcular);
            double porce1, porce2, porce3;
            porce1 = (Convert.ToDouble(txt1.Text) / calcular) * 100;
            txtPorcentaje1.Text = string.Format("{0:N2}%",porce1);
            porce2 = (Convert.ToDouble(txt2.Text) / calcular) * 100;
            txtPorcentaje2.Text = string.Format("{0:N2}%", porce2);
            porce3 = (Convert.ToDouble(txt3.Text) / calcular) * 100;
            txtPorcentaje3.Text = string.Format("{0:N2}%", porce3);
        }
    }
}
