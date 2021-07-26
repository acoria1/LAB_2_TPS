using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Materiales;
using Entidades;
using Entidades.Modelos;

namespace FormularioFabrica
{
    public partial class FrmAgregarMateriales : Form
    {
        List<Material> materialesPorAgregar;
        Material ultimoMaterial;
        public FrmAgregarMateriales()
        {
            InitializeComponent();
            materialesPorAgregar = new List<Material>();
            this.DialogResult = DialogResult.Cancel;
            this.btnDeshacer.Enabled = false;
        }    

        public List<Material>  MaterialesAgregados
        {
            get
            {
                return this.materialesPorAgregar;
            }
        }
        
        private void FrmAgregarMateriales_Load(object sender, EventArgs e)
        {
            this.cmbMaterial.SelectedIndex = 0;
        }

        private void UpdateCmbDetalle(Type enumType)
        {
            foreach (var item in Enum.GetValues(enumType))
            {
                this.cmbMaterialDetalle.Items.Add(item.ToString());
            }
            this.cmbMaterialDetalle.SelectedIndex = 0;
            this.cmbMaterialDetalle.Visible = true;
        }

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbMaterialDetalle.Items.Clear();

            switch (this.cmbMaterial.Text)
            {
                case "Madera":
                    this.UpdateCmbDetalle(typeof(EMadera));
                    break;
                case "Metal":
                    this.UpdateCmbDetalle(typeof(EMetal));
                    break;
                case "Vidrio":
                    this.UpdateCmbDetalle(typeof(EVidrio));
                    break;
                default:
                    this.cmbMaterialDetalle.Visible = false;
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {          
            double peso;
            bool materialYaEstaba = false;
            if (double.TryParse(this.txtPeso.Text,out peso) && peso > 0)
            {
                switch (this.cmbMaterial.Text)
                {
                    case "Ceramica":
                        this.ultimoMaterial = new Ceramica(peso);
                        break;
                    case "Madera":
                        this.ultimoMaterial = new Madera(peso, (EMadera)Enum.Parse(typeof(EMadera), this.cmbMaterialDetalle.Text));
                        break;
                    case "Metal":
                        this.ultimoMaterial = new Metal(peso,(EMetal) Enum.Parse(typeof(EMetal), this.cmbMaterialDetalle.Text));
                        break;
                    case "Plastico":
                        this.ultimoMaterial = new Plastico(peso);
                        break;
                    case "Tela":
                        this.ultimoMaterial = new Tela(peso);
                        break;
                    case "Vidrio":
                        this.ultimoMaterial = new Vidrio(peso, (EVidrio)Enum.Parse(typeof(EVidrio), this.cmbMaterialDetalle.Text));
                        break;
                }
                foreach (Material item in this.materialesPorAgregar)
                {
                    if (item.Equals(this.ultimoMaterial))
                    {
                        item.AgregarPeso(this.ultimoMaterial.PesoEnKG);
                        materialYaEstaba = true;
                    }
                }
                if (!materialYaEstaba)
                {
                    this.materialesPorAgregar.Add(ultimoMaterial);
                }
                this.btnDeshacer.Enabled = true;
                this.ActualizarDetalle();
            }
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            if (this.materialesPorAgregar.Count > 0)
            {
                foreach (Material item in this.materialesPorAgregar)
                {
                    if (item.Equals(this.ultimoMaterial))
                    {
                        item.Gastar(this.ultimoMaterial.PesoEnKG);
                    }
                }
            }
            this.ActualizarDetalle();
            this.btnDeshacer.Enabled = false;
        }

        private void ActualizarDetalle()
        {
            this.rtbDetalleMateriales.Text = string.Empty;
            foreach (Material item in this.materialesPorAgregar)
            {
                this.rtbDetalleMateriales.Text += $"{(item.Key).PadRight(25, ' ')} {item.PesoEnKG} Kg.\n";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
