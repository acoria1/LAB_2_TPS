
namespace FormularioFabrica
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabStock1 = new System.Windows.Forms.TabPage();
            this.btnHistorialEnvios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxbMuebleDetails = new System.Windows.Forms.RichTextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblMuebles = new System.Windows.Forms.Label();
            this.dgvStockMuebles = new System.Windows.Forms.DataGridView();
            this.CodigoGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeFabricacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsStockMuebles = new System.Windows.Forms.BindingSource(this.components);
            this.tabProduccion = new System.Windows.Forms.TabPage();
            this.btnPausarReanudar = new System.Windows.Forms.Button();
            this.btnAddMateriales = new System.Windows.Forms.Button();
            this.btnFabricar = new System.Windows.Forms.Button();
            this.dgvQueueMuebles = new System.Windows.Forms.DataGridView();
            this.CodigoQueue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDModeloQueue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorQueue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoQueue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMueblesProduccion = new System.Windows.Forms.BindingSource(this.components);
            this.lblColaProduccion = new System.Windows.Forms.Label();
            this.lblMateriales = new System.Windows.Forms.Label();
            this.dgvMateriales = new System.Windows.Forms.DataGridView();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoEnKG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMateriales = new System.Windows.Forms.BindingSource(this.components);
            this.tabModelos = new System.Windows.Forms.TabPage();
            this.listBoxModelos = new System.Windows.Forms.ListBox();
            this.btnAdminModelos = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabStock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockMuebles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStockMuebles)).BeginInit();
            this.tabProduccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueueMuebles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMueblesProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMateriales)).BeginInit();
            this.tabModelos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabStock1);
            this.tabControl.Controls.Add(this.tabProduccion);
            this.tabControl.Controls.Add(this.tabModelos);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1567, 753);
            this.tabControl.TabIndex = 0;
            // 
            // tabStock1
            // 
            this.tabStock1.Controls.Add(this.btnHistorialEnvios);
            this.tabStock1.Controls.Add(this.label1);
            this.tabStock1.Controls.Add(this.rtxbMuebleDetails);
            this.tabStock1.Controls.Add(this.btnEnviar);
            this.tabStock1.Controls.Add(this.lblMuebles);
            this.tabStock1.Controls.Add(this.dgvStockMuebles);
            this.tabStock1.Location = new System.Drawing.Point(4, 27);
            this.tabStock1.Name = "tabStock1";
            this.tabStock1.Padding = new System.Windows.Forms.Padding(3);
            this.tabStock1.Size = new System.Drawing.Size(1559, 722);
            this.tabStock1.TabIndex = 0;
            this.tabStock1.Text = "STOCK";
            this.tabStock1.UseVisualStyleBackColor = true;
            // 
            // btnHistorialEnvios
            // 
            this.btnHistorialEnvios.Location = new System.Drawing.Point(1054, 552);
            this.btnHistorialEnvios.Name = "btnHistorialEnvios";
            this.btnHistorialEnvios.Size = new System.Drawing.Size(388, 75);
            this.btnHistorialEnvios.TabIndex = 8;
            this.btnHistorialEnvios.Text = "Ver Historial De Envios";
            this.btnHistorialEnvios.UseVisualStyleBackColor = true;
            this.btnHistorialEnvios.Click += new System.EventHandler(this.btnHistorialEnvios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(1050, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "DETALLES";
            // 
            // rtxbMuebleDetails
            // 
            this.rtxbMuebleDetails.Location = new System.Drawing.Point(1049, 48);
            this.rtxbMuebleDetails.Name = "rtxbMuebleDetails";
            this.rtxbMuebleDetails.Size = new System.Drawing.Size(393, 311);
            this.rtxbMuebleDetails.TabIndex = 6;
            this.rtxbMuebleDetails.Text = "";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(1049, 454);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(393, 75);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Realizar Envio";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblMuebles
            // 
            this.lblMuebles.AutoSize = true;
            this.lblMuebles.Location = new System.Drawing.Point(9, 4);
            this.lblMuebles.Name = "lblMuebles";
            this.lblMuebles.Size = new System.Drawing.Size(172, 18);
            this.lblMuebles.TabIndex = 4;
            this.lblMuebles.Text = "INVENTARIO MUEBLES";
            // 
            // dgvStockMuebles
            // 
            this.dgvStockMuebles.AllowUserToAddRows = false;
            this.dgvStockMuebles.AllowUserToDeleteRows = false;
            this.dgvStockMuebles.AutoGenerateColumns = false;
            this.dgvStockMuebles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockMuebles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoGuid,
            this.IDModelo,
            this.FechaDeFabricacion,
            this.Color});
            this.dgvStockMuebles.DataSource = this.bsStockMuebles;
            this.dgvStockMuebles.Location = new System.Drawing.Point(8, 25);
            this.dgvStockMuebles.MultiSelect = false;
            this.dgvStockMuebles.Name = "dgvStockMuebles";
            this.dgvStockMuebles.ReadOnly = true;
            this.dgvStockMuebles.RowHeadersWidth = 51;
            this.dgvStockMuebles.RowTemplate.Height = 24;
            this.dgvStockMuebles.Size = new System.Drawing.Size(1035, 642);
            this.dgvStockMuebles.TabIndex = 2;
            // 
            // CodigoGuid
            // 
            this.CodigoGuid.DataPropertyName = "CodigoGuid";
            this.CodigoGuid.FillWeight = 140.2525F;
            this.CodigoGuid.HeaderText = "Codigo de Mueble";
            this.CodigoGuid.MinimumWidth = 6;
            this.CodigoGuid.Name = "CodigoGuid";
            this.CodigoGuid.ReadOnly = true;
            this.CodigoGuid.Width = 300;
            // 
            // IDModelo
            // 
            this.IDModelo.DataPropertyName = "IDModelo";
            this.IDModelo.FillWeight = 54.35706F;
            this.IDModelo.HeaderText = "ID Modelo";
            this.IDModelo.MinimumWidth = 6;
            this.IDModelo.Name = "IDModelo";
            this.IDModelo.ReadOnly = true;
            this.IDModelo.Width = 78;
            // 
            // FechaDeFabricacion
            // 
            this.FechaDeFabricacion.DataPropertyName = "FechaDeFabricacion";
            this.FechaDeFabricacion.FillWeight = 102.078F;
            this.FechaDeFabricacion.HeaderText = "Fecha de Fabricacion";
            this.FechaDeFabricacion.MinimumWidth = 6;
            this.FechaDeFabricacion.Name = "FechaDeFabricacion";
            this.FechaDeFabricacion.ReadOnly = true;
            this.FechaDeFabricacion.Width = 146;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.FillWeight = 106.0457F;
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 151;
            // 
            // bsStockMuebles
            // 
            this.bsStockMuebles.CurrentChanged += new System.EventHandler(this.bsStockMuebles_CurrentChanged);
            // 
            // tabProduccion
            // 
            this.tabProduccion.Controls.Add(this.btnPausarReanudar);
            this.tabProduccion.Controls.Add(this.btnAddMateriales);
            this.tabProduccion.Controls.Add(this.btnFabricar);
            this.tabProduccion.Controls.Add(this.dgvQueueMuebles);
            this.tabProduccion.Controls.Add(this.lblColaProduccion);
            this.tabProduccion.Controls.Add(this.lblMateriales);
            this.tabProduccion.Controls.Add(this.dgvMateriales);
            this.tabProduccion.Location = new System.Drawing.Point(4, 27);
            this.tabProduccion.Name = "tabProduccion";
            this.tabProduccion.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduccion.Size = new System.Drawing.Size(1559, 722);
            this.tabProduccion.TabIndex = 1;
            this.tabProduccion.Text = "Produccion";
            this.tabProduccion.UseVisualStyleBackColor = true;
            // 
            // btnPausarReanudar
            // 
            this.btnPausarReanudar.Location = new System.Drawing.Point(453, 589);
            this.btnPausarReanudar.Name = "btnPausarReanudar";
            this.btnPausarReanudar.Size = new System.Drawing.Size(446, 73);
            this.btnPausarReanudar.TabIndex = 14;
            this.btnPausarReanudar.Text = "Pausar Produccion";
            this.btnPausarReanudar.UseVisualStyleBackColor = true;
            this.btnPausarReanudar.Click += new System.EventHandler(this.btnPausarReanudar_Click);
            // 
            // btnAddMateriales
            // 
            this.btnAddMateriales.Location = new System.Drawing.Point(963, 589);
            this.btnAddMateriales.Name = "btnAddMateriales";
            this.btnAddMateriales.Size = new System.Drawing.Size(540, 73);
            this.btnAddMateriales.TabIndex = 13;
            this.btnAddMateriales.Text = "Agregar Materiales";
            this.btnAddMateriales.UseVisualStyleBackColor = true;
            this.btnAddMateriales.Click += new System.EventHandler(this.btnAddMateriales_Click);
            // 
            // btnFabricar
            // 
            this.btnFabricar.Location = new System.Drawing.Point(31, 589);
            this.btnFabricar.Name = "btnFabricar";
            this.btnFabricar.Size = new System.Drawing.Size(209, 73);
            this.btnFabricar.TabIndex = 10;
            this.btnFabricar.Text = "Fabricar Nuevo Mueble";
            this.btnFabricar.UseVisualStyleBackColor = true;
            this.btnFabricar.Click += new System.EventHandler(this.btnFabricar_Click);
            // 
            // dgvQueueMuebles
            // 
            this.dgvQueueMuebles.AutoGenerateColumns = false;
            this.dgvQueueMuebles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueueMuebles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoQueue,
            this.IDModeloQueue,
            this.ColorQueue,
            this.EstadoQueue});
            this.dgvQueueMuebles.DataSource = this.bsMueblesProduccion;
            this.dgvQueueMuebles.Location = new System.Drawing.Point(31, 27);
            this.dgvQueueMuebles.Name = "dgvQueueMuebles";
            this.dgvQueueMuebles.ReadOnly = true;
            this.dgvQueueMuebles.RowHeadersWidth = 51;
            this.dgvQueueMuebles.RowTemplate.Height = 24;
            this.dgvQueueMuebles.Size = new System.Drawing.Size(868, 537);
            this.dgvQueueMuebles.TabIndex = 9;
            // 
            // CodigoQueue
            // 
            this.CodigoQueue.DataPropertyName = "CodigoGuid";
            this.CodigoQueue.HeaderText = "Codigo";
            this.CodigoQueue.MinimumWidth = 6;
            this.CodigoQueue.Name = "CodigoQueue";
            this.CodigoQueue.ReadOnly = true;
            this.CodigoQueue.Width = 200;
            // 
            // IDModeloQueue
            // 
            this.IDModeloQueue.DataPropertyName = "IDModelo";
            this.IDModeloQueue.HeaderText = "ID Modelo";
            this.IDModeloQueue.MinimumWidth = 6;
            this.IDModeloQueue.Name = "IDModeloQueue";
            this.IDModeloQueue.ReadOnly = true;
            this.IDModeloQueue.Width = 90;
            // 
            // ColorQueue
            // 
            this.ColorQueue.DataPropertyName = "Color";
            this.ColorQueue.HeaderText = "Color";
            this.ColorQueue.MinimumWidth = 6;
            this.ColorQueue.Name = "ColorQueue";
            this.ColorQueue.ReadOnly = true;
            this.ColorQueue.Width = 125;
            // 
            // EstadoQueue
            // 
            this.EstadoQueue.DataPropertyName = "Estado";
            this.EstadoQueue.HeaderText = "Estado";
            this.EstadoQueue.MinimumWidth = 6;
            this.EstadoQueue.Name = "EstadoQueue";
            this.EstadoQueue.ReadOnly = true;
            this.EstadoQueue.Width = 175;
            // 
            // lblColaProduccion
            // 
            this.lblColaProduccion.AutoSize = true;
            this.lblColaProduccion.Location = new System.Drawing.Point(39, 6);
            this.lblColaProduccion.Name = "lblColaProduccion";
            this.lblColaProduccion.Size = new System.Drawing.Size(180, 18);
            this.lblColaProduccion.TabIndex = 8;
            this.lblColaProduccion.Text = "COLA DE PRODUCCION";
            // 
            // lblMateriales
            // 
            this.lblMateriales.AutoSize = true;
            this.lblMateriales.Location = new System.Drawing.Point(960, 6);
            this.lblMateriales.Name = "lblMateriales";
            this.lblMateriales.Size = new System.Drawing.Size(100, 18);
            this.lblMateriales.TabIndex = 6;
            this.lblMateriales.Text = "MATERIALES";
            // 
            // dgvMateriales
            // 
            this.dgvMateriales.AllowUserToAddRows = false;
            this.dgvMateriales.AllowUserToDeleteRows = false;
            this.dgvMateriales.AllowUserToResizeRows = false;
            this.dgvMateriales.AutoGenerateColumns = false;
            this.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Material,
            this.PesoEnKG});
            this.dgvMateriales.DataSource = this.bsMateriales;
            this.dgvMateriales.Location = new System.Drawing.Point(963, 27);
            this.dgvMateriales.Name = "dgvMateriales";
            this.dgvMateriales.ReadOnly = true;
            this.dgvMateriales.RowHeadersWidth = 51;
            this.dgvMateriales.RowTemplate.Height = 24;
            this.dgvMateriales.Size = new System.Drawing.Size(540, 537);
            this.dgvMateriales.TabIndex = 2;
            // 
            // Material
            // 
            this.Material.DataPropertyName = "Key";
            this.Material.HeaderText = "Material";
            this.Material.MinimumWidth = 6;
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            this.Material.Width = 180;
            // 
            // PesoEnKG
            // 
            this.PesoEnKG.DataPropertyName = "PesoEnKG";
            this.PesoEnKG.HeaderText = "Peso (KG)";
            this.PesoEnKG.MinimumWidth = 6;
            this.PesoEnKG.Name = "PesoEnKG";
            this.PesoEnKG.ReadOnly = true;
            this.PesoEnKG.Width = 150;
            // 
            // tabModelos
            // 
            this.tabModelos.Controls.Add(this.listBoxModelos);
            this.tabModelos.Controls.Add(this.btnAdminModelos);
            this.tabModelos.Location = new System.Drawing.Point(4, 27);
            this.tabModelos.Name = "tabModelos";
            this.tabModelos.Padding = new System.Windows.Forms.Padding(3);
            this.tabModelos.Size = new System.Drawing.Size(1559, 722);
            this.tabModelos.TabIndex = 2;
            this.tabModelos.Text = "Modelos";
            this.tabModelos.UseVisualStyleBackColor = true;
            // 
            // listBoxModelos
            // 
            this.listBoxModelos.Enabled = false;
            this.listBoxModelos.FormattingEnabled = true;
            this.listBoxModelos.ItemHeight = 18;
            this.listBoxModelos.Location = new System.Drawing.Point(9, 16);
            this.listBoxModelos.Name = "listBoxModelos";
            this.listBoxModelos.Size = new System.Drawing.Size(293, 346);
            this.listBoxModelos.TabIndex = 1;
            // 
            // btnAdminModelos
            // 
            this.btnAdminModelos.Location = new System.Drawing.Point(8, 381);
            this.btnAdminModelos.Name = "btnAdminModelos";
            this.btnAdminModelos.Size = new System.Drawing.Size(288, 76);
            this.btnAdminModelos.TabIndex = 0;
            this.btnAdminModelos.Text = "Administrar Modelos";
            this.btnAdminModelos.UseVisualStyleBackColor = true;
            this.btnAdminModelos.Click += new System.EventHandler(this.btnAdminModelos_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 753);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coria.Agustin.2C.TPFinal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.tabControl.ResumeLayout(false);
            this.tabStock1.ResumeLayout(false);
            this.tabStock1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockMuebles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStockMuebles)).EndInit();
            this.tabProduccion.ResumeLayout(false);
            this.tabProduccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueueMuebles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMueblesProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMateriales)).EndInit();
            this.tabModelos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabStock1;
        private System.Windows.Forms.TabPage tabProduccion;
        private System.Windows.Forms.Label lblMuebles;
        private System.Windows.Forms.DataGridView dgvStockMuebles;
        private System.Windows.Forms.Label lblMateriales;
        private System.Windows.Forms.DataGridView dgvMateriales;
        private System.Windows.Forms.RichTextBox rtxbMuebleDetails;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.DataGridView dgvQueueMuebles;
        private System.Windows.Forms.Label lblColaProduccion;
        private System.Windows.Forms.Button btnFabricar;
        private System.Windows.Forms.BindingSource bsStockMuebles;
        private System.Windows.Forms.BindingSource bsMueblesProduccion;
        private System.Windows.Forms.BindingSource bsMateriales;
        private System.Windows.Forms.Button btnAddMateriales;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoQueue;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDModeloQueue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorQueue;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoQueue;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeFabricacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoEnKG;
        private System.Windows.Forms.TabPage tabModelos;
        private System.Windows.Forms.Button btnAdminModelos;
        private System.Windows.Forms.ListBox listBoxModelos;
        private System.Windows.Forms.Button btnPausarReanudar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHistorialEnvios;
    }
}

