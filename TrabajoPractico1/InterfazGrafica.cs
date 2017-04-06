using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace TrabajoPractico1
{
    public partial class InterfazGrafica : Form
    {
        public InterfazGrafica()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.lblResultado.Text = "";
            this.cmbOperacion.Text = "+";
        }           

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numeros n1 = new Numeros(txtNumero1.Text);
            Numeros n2 = new Numeros(txtNumero2.Text);
            double resultado = Calculadora.Operar(n1, n2, Calculadora.ValidarOperador(this.cmbOperacion.Text.ToString()));
            this.lblResultado.Text = resultado.ToString();
        }
    }
}
