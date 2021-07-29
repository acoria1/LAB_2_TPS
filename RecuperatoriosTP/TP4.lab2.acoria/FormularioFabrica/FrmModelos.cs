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
using Entidades.Modelos;
using Entidades.Interfaces;

namespace FormularioFabrica
{
    public partial class FrmModelos : Form
    {
        Fabrica miFabrica;
        public FrmModelos(Fabrica fabricaPrincipal)
        {
            InitializeComponent();
            this.miFabrica = fabricaPrincipal;
            this.bindingSourceModelos.DataSource = miFabrica.modelosDisponibles.Values.ToList();
            this.DialogResult = DialogResult.Cancel;
            this.dgvModelos.MultiSelect = false ;
            this.checkBoxCajones.Enabled = false;
        }

        public Dictionary<string, Modelo> Modelos
        {
            get
            {
                return this.miFabrica.modelosDisponibles;
            }
        }

        private void bindingSourceModelos_CurrentChanged(object sender, EventArgs e)
        {
            this.rtxtMatModelo.Text = string.Empty;
            // hace falta esta validacion porque puede no haber ningun item en mi dgv.
            if ((Modelo)this.bindingSourceModelos.Current != null)
            {
                foreach (Material item in ((Modelo)this.bindingSourceModelos.Current).materialesNecesarios)
                {
                    this.rtxtMatModelo.Text += $"{item.Key.PadRight(25, ' ')}{item.PesoEnKG} Kg.\n";
                }
                this.rtxtColores.Text = string.Empty;
                foreach (EColor item in ((Modelo)this.bindingSourceModelos.Current).coloresDisponibles)
                {
                    this.rtxtColores.Text += item.ToString() + '\n';
                }
                if (this.bindingSourceModelos.Current.GetType().GetInterfaces().Contains(typeof(ICajonera)))
                {
                    this.lblCajonesDetail.Text = ((ICajonera)this.bindingSourceModelos.Current).CantidadCajones.ToString();
                } else
                {
                    this.lblCajonesDetail.Text = "";
                }
            }           
        }

        private void FiltrarDataGridPorModelo<T>()  where T : Modelo, new() 
        {
            this.bindingSourceModelos.DataSource = miFabrica.modelosDisponibles.Values.ToList();          
            this.bindingSourceModelos.MoveFirst();
            int i = this.bindingSourceModelos.Count;
            for (int j = 0; j < i ; j++)
            {                            
                if (this.bindingSourceModelos.Current.GetType() != typeof(T))
                {
                    this.bindingSourceModelos.Remove(this.bindingSourceModelos.Current); 
                } else
                {
                    this.bindingSourceModelos.MoveNext();
                }
            }        
        }

        private void FiltrarDataGridPorCajones()
        {
            this.bindingSourceModelos.MoveFirst();
            int i = this.bindingSourceModelos.Count;
            for (int j = 0; j < i; j++)
            {
                if (!((ICajonera)this.bindingSourceModelos.Current).TieneCajones())
                {
                    this.bindingSourceModelos.Remove(this.bindingSourceModelos.Current);
                }
                else
                {
                    this.bindingSourceModelos.MoveNext();
                }
            }
        }

        private void btnNewModelo_Click(object sender, EventArgs e)
        {
            FrmNuevoModelo frmNuevoModelo = new FrmNuevoModelo();
            frmNuevoModelo.ShowDialog();
            if (frmNuevoModelo.DialogResult == DialogResult.OK)
            {
                this.bindingSourceModelos.Add(frmNuevoModelo.Modelo);
                this.miFabrica = this.miFabrica + frmNuevoModelo.Modelo;
                try
                {
                    ModeloDAO.Insert(frmNuevoModelo.Modelo);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al intentar guardar modelo");
                }     
            }
        }

        private void btnDeleteModelo_Click(object sender, EventArgs e)
        {
            string identificador = ((Modelo)this.bindingSourceModelos.Current).Identificador;
            if (MessageBox.Show($"¿ELIMINAR MODELO {identificador} DE LA APLICACIÓN?)",
                "Confirmar baja",
                MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                if (miFabrica - ((Modelo)this.bindingSourceModelos.Current))
                {
                    MessageBox.Show($"Se eliminó el modelo {identificador} de la fabrica");
                }
                this.bindingSourceModelos.Remove(((Modelo)this.bindingSourceModelos.Current));
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtnTodos.Checked)
            this.bindingSourceModelos.DataSource = miFabrica.modelosDisponibles.Values.ToList();
        }

        private void rbtnEstanterias_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtnEstanterias.Checked)
            {
                this.FiltrarDataGridPorModelo<ModeloEstanteria>();
                this.checkBoxCajones.Enabled = true;
            } else
            {
                this.checkBoxCajones.Checked = false;
                this.checkBoxCajones.Enabled = false;
            }
        }

        private void rbtnMesas_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtnMesas.Checked)
                this.FiltrarDataGridPorModelo<ModeloMesa>();
        }

        private void rbtnPlacares_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtnPlacares.Checked)
            {
                this.FiltrarDataGridPorModelo<ModeloPlacar>();
                this.checkBoxCajones.Enabled = true;
            } else
            {
                this.checkBoxCajones.Checked = false;
                this.checkBoxCajones.Enabled = false;
            }               
        }

        private void rbtnSillones_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtnSillones.Checked)
                this.FiltrarDataGridPorModelo<ModeloSillon>();
        }
        private void checkBoxCajones_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxCajones.Checked)
            {
                this.FiltrarDataGridPorCajones();
            } else
            {
                this.rbtnTodos.Checked = true;
            }
        }

        private void FrmModelos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
