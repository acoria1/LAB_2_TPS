using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Modelos;
using Entidades;
using Entidades.Muebles;
using System.Threading;

namespace FormularioFabrica
{
    public delegate void FabriqueNuevoMueble(Mueble m);
    public delegate void AvisoFormClosing();
    public partial class FrmNuevoMueble : Form
    {
        List<Modelo> modelosDisponibles;
        public event FabriqueNuevoMueble fabriqueNuevoMueble;
        public event AvisoFormClosing avisoFormClosing;
        Modelo currentModel;
        public FrmNuevoMueble(List<Modelo> modelosDeFabrica)
        {
            InitializeComponent();
            modelosDisponibles = new List<Modelo>(modelosDeFabrica);
        }

        private void FrmNuevoMueble_Load(object sender, EventArgs e)
        {
            this.cmbTipoMueble.SelectedIndex = 0;
        }

        private void cmbTipoMueble_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbModelo.Items.Clear();

            switch (this.cmbTipoMueble.Text)
            {
                case "Estanteria":
                    this.UpdateCmbModelos(Globals.prefijoEstanteria);
                    break;
                case "Mesa":
                    this.UpdateCmbModelos(Globals.prefijoMesa);
                    break;
                case "Placar":
                    this.UpdateCmbModelos(Globals.prefijoPlacar);
                    break;
                case "Sillon":
                    this.UpdateCmbModelos(Globals.prefijoSillon);
                    break;
            }
        }

        /// <summary>
        /// // Actualiza combobox con los modelos que corresponden al tipo seleccionado en ComboBox
        // de Tipo de Mueble. 
        /// </summary>
        /// <param name="filter"></param> Cadena de caracteres que todos los modelos de un mismo
        /// tipo comparten.

        private void UpdateCmbModelos(string filter)
        {
            foreach (Modelo item in this.modelosDisponibles)
            {
                if (item.Identificador.Contains(filter))
                    this.cmbModelo.Items.Add(item.Identificador);
            }
            this.cmbModelo.SelectedIndex = 0;
        }

        private void cmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbColor.Items.Clear();
            foreach (Modelo item in this.modelosDisponibles)
            {
                if (item.Identificador == this.cmbModelo.Text)
                {
                    foreach (EColor color in item.coloresDisponibles)
                    {
                        this.cmbColor.Items.Add(color.ToString());
                    }
                    this.rtxtDetalleModelo.Text = item.Mostrar();
                    this.currentModel = item;
                }
            }           
            this.cmbColor.SelectedIndex = 0;
        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {           
            for (int i = 0; i < this.nudCantidad.Value; i++)
            {
                Mueble m = new Mueble(this.currentModel, DateTime.Now, (EColor)Enum.Parse(typeof(EColor), this.cmbColor.Text));
                this.fabriqueNuevoMueble.Invoke(m);
            }
        }

        private void FrmNuevoMueble_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public void ShowDialogNoReturn()
        {
            this.ShowDialog();
            this.avisoFormClosing.Invoke();
        }
    }
}
