using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();           
            cmbOperador.SelectedIndex = 0;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            
            if (txtNumero1.Text == "" || txtNumero2.Text == "")
            {
                MessageBox.Show("Ingrese ambos numeros");
            }
            else
            {
                resultado =FormCalculadora.Operar(txtNumero1.Text,txtNumero2.Text, cmbOperador.Text);
                if (resultado == double.MinValue)
                {
                    lblResultado.Text = "Math Error";
                } else
                    lblResultado.Text = resultado.ToString();
                    btnConvertirADecimal.Enabled = true;
                    btnConvertirABinario.Enabled = true;
            }
        }

        private static double Operar(string numero1, string numero2,string operador)
        {
            double resultado;
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            resultado = Calculadora.Operar(num1, num2, operador);
            return resultado;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("¿Seguro que quieres salir?", "Salir", MessageBoxButtons.YesNo);
            if (exit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = string.Empty;
            btnConvertirADecimal.Enabled = true;
            btnConvertirABinario.Enabled = true;
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.DecimalABinario(lblResultado.Text);
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.BinarioADecimal(lblResultado.Text);
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
        }
    }
}
