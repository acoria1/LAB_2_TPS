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
using Entidades.Excepciones;
using Entidades.Modelos;

namespace FormularioFabrica
{
    public partial class FrmNuevoModelo : Form
    {
        Modelo modelo;
        List<Material> materialesDeModelo;
        List<EColor> coloresSeleccionados;
        public FrmNuevoModelo()
        {
            InitializeComponent();
            this.nudCajones.Visible = false;
            this.nudAlmohadones.Visible = false;
            this.materialesDeModelo = new List<Material>();
            this.coloresSeleccionados = new List<EColor>();
            this.DialogResult = DialogResult.Cancel;
        }

        public Modelo Modelo
        {
            get
            {
                return this.modelo;
            }
        }
        
        private void AM_Modelos_Load(object sender, EventArgs e)
        {
            int i = 0;
            CheckBox box;
            foreach (var item in Enum.GetValues(typeof(EColor)))
            {
                box = new CheckBox();
                box.Name = "cb" + item.ToString();
                box.Tag = i;
                box.Text = item.ToString();
                box.AutoSize = true;
                box.Location = new Point(400, 40 + i * 25);
                box.CheckedChanged += CheckBox_CheckedChanged;
                this.Controls.Add(box);
                i++;
            }
            this.cmbClaseDeMueble.SelectedIndex = 0;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {            
            foreach (EColor color in Enum.GetValues(typeof(EColor)))
            {
                if (this.ActiveControl.Text == color.ToString())
                {
                    if (this.coloresSeleccionados.Contains(color))
                    {
                        this.coloresSeleccionados.Remove(color);
                    } else
                    {
                        this.coloresSeleccionados.Add(color);
                    }                   
                }
            }
        }

        private void btnAgregarMaterial_Click(object sender, EventArgs e)
        {
            FrmAgregarMateriales frmAgregarMateriales = new FrmAgregarMateriales();
            frmAgregarMateriales.ShowDialog();
            bool materialYaEstaba = false;
            if (frmAgregarMateriales.DialogResult == DialogResult.OK)
            {
                this.rtbMaterialesDetalle2.Text = string.Empty;
                foreach (Material materialNuevo in frmAgregarMateriales.MaterialesAgregados)
                {
                    foreach (Material material in this.materialesDeModelo)
                    {
                        if (material.Equals(materialNuevo))
                        {
                            material.AgregarPeso(materialNuevo.PesoEnKG);
                            materialYaEstaba = true;
                        }
                    }
                    if (!materialYaEstaba)
                    {
                        this.materialesDeModelo.Add(materialNuevo);
                    }
                }
                foreach (Material item in this.materialesDeModelo)
                {
                    this.rtbMaterialesDetalle2.Text += $"{item.Key.PadRight(25, ' ')}: {item.PesoEnKG} Kg.\n";
                }
            }
        }

        private void cmbClaseDeMueble_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cmbClaseDeMueble.Text)
            {
                case "Estanteria":
                    this.cmbTipo.Items.Clear();
                    foreach (string item in Enum.GetNames(typeof(EEstanteria)))
                    {
                        this.cmbTipo.Items.Add(item);
                    }
                    this.nudCajones.Visible = true;
                    this.lblCajones.Visible = true;
                    this.nudAlmohadones.Visible = false;
                    this.lblAlmohadones.Visible = false;
                    this.cmbTipo.SelectedIndex = 0;
                    break;
                case "Mesa":
                    this.cmbTipo.Items.Clear();
                    foreach (string item in Enum.GetNames(typeof(EEspacio)))
                    {
                        this.cmbTipo.Items.Add(item);
                    }
                    this.cmbTipo.SelectedIndex = 0;
                    this.nudCajones.Visible = false;
                    this.lblCajones.Visible = false;
                    this.nudAlmohadones.Visible = false;
                    this.lblAlmohadones.Visible = false;
                    break;
                case "Placar":
                    this.cmbTipo.Items.Clear();
                    this.cmbTipo.Text = string.Empty;
                    this.nudCajones.Visible = true;
                    this.lblCajones.Visible = true;
                    this.nudAlmohadones.Visible = false;
                    this.lblAlmohadones.Visible = false;
                    break;
                case "Sillon":
                    this.cmbTipo.Text = string.Empty;
                    this.cmbTipo.Items.Clear();
                    this.nudCajones.Visible = false;
                    this.lblCajones.Visible = false;
                    this.nudAlmohadones.Visible = true;
                    this.lblAlmohadones.Visible = true;
                    break;
            }
        }

        private void btnBorrarMateriales_Click(object sender, EventArgs e)
        {
            this.rtbMaterialesDetalle2.Text = string.Empty;
            this.materialesDeModelo = new List<Material>();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {           
            if (this.ValidarDatos())
            {
                try
                {
                    this.CrearModelo();
                }
                catch (ExceptionDimensionesInvaldas ex)
                {
                    MessageBox.Show(FormPrincipal.LogException(ex));                    
                }
                catch (ExceptionNombreModeloInvalido ex)
                {
                    MessageBox.Show(FormPrincipal.LogException(ex));
                }
            }
            else
            {
                MessageBox.Show("Datos erroneos");
                return;
            }
            if (this.modelo != null && MessageBox.Show(
                this.modelo.Mostrar(),
                "Confrimar alta de Modelo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }            
        }
        private bool ValidarDatos()
        {
            bool modeloValido = false;
            Dimensiones dimensiones = new Dimensiones();

            if (double.TryParse(this.txtAlto.Text, out dimensiones.alto) &&
                double.TryParse(this.txtAncho.Text, out dimensiones.ancho) &&
                double.TryParse(this.txtProfundidad.Text, out dimensiones.profundidad) &&
                this.txtDescripcion.Text != null &&
                this.materialesDeModelo.Count > 0 && 
                this.coloresSeleccionados.Count > 0)
            {
                modeloValido = true;
            }
            return modeloValido;
        }

        private void CrearModelo()
        {
            switch (this.cmbClaseDeMueble.Text)
            {
                case "Estanteria":
                    EEstanteria tipoDeEstanteria;
                    Enum.TryParse<EEstanteria>(this.cmbTipo.Text, out tipoDeEstanteria);
                    this.modelo = new ModeloEstanteria(
                        new Dimensiones(double.Parse(this.txtAlto.Text),
                        double.Parse(this.txtAncho.Text),
                        double.Parse(this.txtProfundidad.Text)),
                        this.txtDescripcion.Text,
                        this.materialesDeModelo,
                        tipoDeEstanteria,
                        this.coloresSeleccionados.ToArray(),
                        (ushort)this.nudCajones.Value);
                    break;
                case "Mesa":
                    EEspacio tipoDeMesa;
                    Enum.TryParse<EEspacio>(this.cmbTipo.Text, out tipoDeMesa);
                    this.modelo = new ModeloMesa(
                        new Dimensiones(double.Parse(this.txtAlto.Text),
                        double.Parse(this.txtAncho.Text),
                        double.Parse(this.txtProfundidad.Text)),
                        this.txtDescripcion.Text,
                        this.materialesDeModelo,
                        tipoDeMesa,
                        this.coloresSeleccionados.ToArray());
                    break;
                case "Placar":
                    this.modelo = new ModeloPlacar(
                        new Dimensiones(double.Parse(this.txtAlto.Text),
                        double.Parse(this.txtAncho.Text),
                        double.Parse(this.txtProfundidad.Text)),
                        this.txtDescripcion.Text,
                        this.materialesDeModelo,
                        this.coloresSeleccionados.ToArray(),
                        (ushort)this.nudCajones.Value);
                    break;
                case "Sillon":
                    this.modelo = new ModeloSillon(
                        new Dimensiones(double.Parse(this.txtAlto.Text),
                        double.Parse(this.txtAncho.Text),
                        double.Parse(this.txtProfundidad.Text)),
                        this.txtDescripcion.Text,
                        this.materialesDeModelo,
                        this.coloresSeleccionados.ToArray(),
                        (ushort)this.nudAlmohadones.Value);
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
