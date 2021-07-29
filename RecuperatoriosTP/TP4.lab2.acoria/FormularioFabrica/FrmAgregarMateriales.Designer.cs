
namespace FormularioFabrica
{
    partial class FrmAgregarMateriales
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
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbMaterialDetalle = new System.Windows.Forms.ComboBox();
            this.rtbDetalleMateriales = new System.Windows.Forms.RichTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMaterial.Location = new System.Drawing.Point(12, 21);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(142, 18);
            this.lblMaterial.TabIndex = 0;
            this.lblMaterial.Text = "Seleccionar Material";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Items.AddRange(new object[] {
            "Ceramica",
            "Madera",
            "Metal",
            "Plastico",
            "Tela",
            "Vidrio"});
            this.cmbMaterial.Location = new System.Drawing.Point(15, 53);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(285, 24);
            this.cmbMaterial.TabIndex = 1;
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPeso.Location = new System.Drawing.Point(30, 153);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(89, 18);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Peso en KG";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(15, 174);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(122, 22);
            this.txtPeso.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 241);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(175, 55);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbMaterialDetalle
            // 
            this.cmbMaterialDetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterialDetalle.FormattingEnabled = true;
            this.cmbMaterialDetalle.Items.AddRange(new object[] {
            "Ceramica",
            "Madera",
            "Metal",
            "Plastico",
            "Tela",
            "Vidrio"});
            this.cmbMaterialDetalle.Location = new System.Drawing.Point(15, 95);
            this.cmbMaterialDetalle.Name = "cmbMaterialDetalle";
            this.cmbMaterialDetalle.Size = new System.Drawing.Size(285, 24);
            this.cmbMaterialDetalle.TabIndex = 5;
            // 
            // rtbDetalleMateriales
            // 
            this.rtbDetalleMateriales.Location = new System.Drawing.Point(328, 20);
            this.rtbDetalleMateriales.Name = "rtbDetalleMateriales";
            this.rtbDetalleMateriales.ReadOnly = true;
            this.rtbDetalleMateriales.Size = new System.Drawing.Size(302, 354);
            this.rtbDetalleMateriales.TabIndex = 6;
            this.rtbDetalleMateriales.Text = "";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(15, 313);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(285, 61);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Guardar y Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.Location = new System.Drawing.Point(202, 241);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(98, 55);
            this.btnDeshacer.TabIndex = 8;
            this.btnDeshacer.Text = "Deshacer";
            this.btnDeshacer.UseVisualStyleBackColor = true;
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // FrmAgregarMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 392);
            this.Controls.Add(this.btnDeshacer);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rtbDetalleMateriales);
            this.Controls.Add(this.cmbMaterialDetalle);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.lblMaterial);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FrmAgregarMateriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Materiales";
            this.Load += new System.EventHandler(this.FrmAgregarMateriales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbMaterialDetalle;
        private System.Windows.Forms.RichTextBox rtbDetalleMateriales;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDeshacer;
    }
}