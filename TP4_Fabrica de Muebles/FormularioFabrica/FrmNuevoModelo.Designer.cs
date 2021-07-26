
namespace FormularioFabrica
{
    partial class FrmNuevoModelo
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
            this.lblAlto = new System.Windows.Forms.Label();
            this.lblProfundidad = new System.Windows.Forms.Label();
            this.lblAncho = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTipoModelo = new System.Windows.Forms.Label();
            this.lblCajones = new System.Windows.Forms.Label();
            this.lblAlmohadones = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProfundidad = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtAlto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblColoresModelo = new System.Windows.Forms.Label();
            this.nudCajones = new System.Windows.Forms.NumericUpDown();
            this.nudAlmohadones = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarMaterial = new System.Windows.Forms.Button();
            this.lblMaterialesModelo = new System.Windows.Forms.Label();
            this.lblClaseMueble = new System.Windows.Forms.Label();
            this.cmbClaseDeMueble = new System.Windows.Forms.ComboBox();
            this.btnBorrarMateriales = new System.Windows.Forms.Button();
            this.rtbMaterialesDetalle2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCajones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlmohadones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlto
            // 
            this.lblAlto.AutoSize = true;
            this.lblAlto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlto.Location = new System.Drawing.Point(6, 29);
            this.lblAlto.Name = "lblAlto";
            this.lblAlto.Size = new System.Drawing.Size(71, 18);
            this.lblAlto.TabIndex = 0;
            this.lblAlto.Text = "Alto (CM)";
            // 
            // lblProfundidad
            // 
            this.lblProfundidad.AutoSize = true;
            this.lblProfundidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfundidad.Location = new System.Drawing.Point(336, 29);
            this.lblProfundidad.Name = "lblProfundidad";
            this.lblProfundidad.Size = new System.Drawing.Size(125, 18);
            this.lblProfundidad.TabIndex = 1;
            this.lblProfundidad.Text = "Profundidad (CM)";
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAncho.Location = new System.Drawing.Point(167, 29);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(88, 18);
            this.lblAncho.TabIndex = 2;
            this.lblAncho.Text = "Ancho (CM)";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(19, 206);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 18);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblTipoModelo
            // 
            this.lblTipoModelo.AutoSize = true;
            this.lblTipoModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoModelo.Location = new System.Drawing.Point(312, 290);
            this.lblTipoModelo.Name = "lblTipoModelo";
            this.lblTipoModelo.Size = new System.Drawing.Size(37, 18);
            this.lblTipoModelo.TabIndex = 6;
            this.lblTipoModelo.Text = "Tipo";
            // 
            // lblCajones
            // 
            this.lblCajones.AutoSize = true;
            this.lblCajones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajones.Location = new System.Drawing.Point(312, 361);
            this.lblCajones.Name = "lblCajones";
            this.lblCajones.Size = new System.Drawing.Size(142, 18);
            this.lblCajones.TabIndex = 7;
            this.lblCajones.Text = "Cantidad de cajones";
            // 
            // lblAlmohadones
            // 
            this.lblAlmohadones.AutoSize = true;
            this.lblAlmohadones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmohadones.Location = new System.Drawing.Point(314, 422);
            this.lblAlmohadones.Name = "lblAlmohadones";
            this.lblAlmohadones.Size = new System.Drawing.Size(181, 18);
            this.lblAlmohadones.TabIndex = 8;
            this.lblAlmohadones.Text = "Cantidad de Almohadones";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(315, 312);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(173, 24);
            this.cmbTipo.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProfundidad);
            this.groupBox1.Controls.Add(this.txtAncho);
            this.groupBox1.Controls.Add(this.txtAlto);
            this.groupBox1.Controls.Add(this.lblAlto);
            this.groupBox1.Controls.Add(this.lblAncho);
            this.groupBox1.Controls.Add(this.lblProfundidad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(13, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 82);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dimensiones";
            // 
            // txtProfundidad
            // 
            this.txtProfundidad.Location = new System.Drawing.Point(339, 50);
            this.txtProfundidad.Name = "txtProfundidad";
            this.txtProfundidad.Size = new System.Drawing.Size(114, 24);
            this.txtProfundidad.TabIndex = 4;
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(170, 50);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(100, 24);
            this.txtAncho.TabIndex = 3;
            // 
            // txtAlto
            // 
            this.txtAlto.Location = new System.Drawing.Point(9, 50);
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Size = new System.Drawing.Size(100, 24);
            this.txtAlto.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(22, 237);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(466, 22);
            this.txtDescripcion.TabIndex = 11;
            // 
            // lblColoresModelo
            // 
            this.lblColoresModelo.AutoSize = true;
            this.lblColoresModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColoresModelo.Location = new System.Drawing.Point(559, 12);
            this.lblColoresModelo.Name = "lblColoresModelo";
            this.lblColoresModelo.Size = new System.Drawing.Size(142, 18);
            this.lblColoresModelo.TabIndex = 4;
            this.lblColoresModelo.Text = "Colores Disponibles";
            // 
            // nudCajones
            // 
            this.nudCajones.Location = new System.Drawing.Point(317, 382);
            this.nudCajones.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudCajones.Name = "nudCajones";
            this.nudCajones.Size = new System.Drawing.Size(120, 22);
            this.nudCajones.TabIndex = 13;
            // 
            // nudAlmohadones
            // 
            this.nudAlmohadones.Location = new System.Drawing.Point(315, 443);
            this.nudAlmohadones.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudAlmohadones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAlmohadones.Name = "nudAlmohadones";
            this.nudAlmohadones.Size = new System.Drawing.Size(121, 22);
            this.nudAlmohadones.TabIndex = 14;
            this.nudAlmohadones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(288, 687);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(207, 51);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar y Salir";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(520, 687);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(203, 51);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregarMaterial
            // 
            this.btnAgregarMaterial.Location = new System.Drawing.Point(23, 547);
            this.btnAgregarMaterial.Name = "btnAgregarMaterial";
            this.btnAgregarMaterial.Size = new System.Drawing.Size(241, 47);
            this.btnAgregarMaterial.TabIndex = 17;
            this.btnAgregarMaterial.Text = "Agregar Materiales";
            this.btnAgregarMaterial.UseVisualStyleBackColor = true;
            this.btnAgregarMaterial.Click += new System.EventHandler(this.btnAgregarMaterial_Click);
            // 
            // lblMaterialesModelo
            // 
            this.lblMaterialesModelo.AutoSize = true;
            this.lblMaterialesModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialesModelo.Location = new System.Drawing.Point(19, 290);
            this.lblMaterialesModelo.Name = "lblMaterialesModelo";
            this.lblMaterialesModelo.Size = new System.Drawing.Size(156, 18);
            this.lblMaterialesModelo.TabIndex = 5;
            this.lblMaterialesModelo.Text = "Materiales Necesarios";
            // 
            // lblClaseMueble
            // 
            this.lblClaseMueble.AutoSize = true;
            this.lblClaseMueble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblClaseMueble.Location = new System.Drawing.Point(20, 14);
            this.lblClaseMueble.Name = "lblClaseMueble";
            this.lblClaseMueble.Size = new System.Drawing.Size(209, 18);
            this.lblClaseMueble.TabIndex = 18;
            this.lblClaseMueble.Text = "CLASIFICACION DE MUEBLE";
            // 
            // cmbClaseDeMueble
            // 
            this.cmbClaseDeMueble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClaseDeMueble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbClaseDeMueble.FormattingEnabled = true;
            this.cmbClaseDeMueble.Items.AddRange(new object[] {
            "Estanteria",
            "Mesa",
            "Placar",
            "Sillon"});
            this.cmbClaseDeMueble.Location = new System.Drawing.Point(23, 49);
            this.cmbClaseDeMueble.Name = "cmbClaseDeMueble";
            this.cmbClaseDeMueble.Size = new System.Drawing.Size(206, 26);
            this.cmbClaseDeMueble.TabIndex = 19;
            this.cmbClaseDeMueble.SelectedIndexChanged += new System.EventHandler(this.cmbClaseDeMueble_SelectedIndexChanged);
            // 
            // btnBorrarMateriales
            // 
            this.btnBorrarMateriales.Location = new System.Drawing.Point(23, 602);
            this.btnBorrarMateriales.Name = "btnBorrarMateriales";
            this.btnBorrarMateriales.Size = new System.Drawing.Size(241, 51);
            this.btnBorrarMateriales.TabIndex = 20;
            this.btnBorrarMateriales.Text = "Borrar Materiales";
            this.btnBorrarMateriales.UseVisualStyleBackColor = true;
            this.btnBorrarMateriales.Click += new System.EventHandler(this.btnBorrarMateriales_Click);
            // 
            // rtbMaterialesDetalle2
            // 
            this.rtbMaterialesDetalle2.Location = new System.Drawing.Point(22, 312);
            this.rtbMaterialesDetalle2.Name = "rtbMaterialesDetalle2";
            this.rtbMaterialesDetalle2.ReadOnly = true;
            this.rtbMaterialesDetalle2.Size = new System.Drawing.Size(242, 229);
            this.rtbMaterialesDetalle2.TabIndex = 21;
            this.rtbMaterialesDetalle2.Text = "";
            // 
            // FrmNuevoModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 750);
            this.Controls.Add(this.rtbMaterialesDetalle2);
            this.Controls.Add(this.btnBorrarMateriales);
            this.Controls.Add(this.cmbClaseDeMueble);
            this.Controls.Add(this.lblClaseMueble);
            this.Controls.Add(this.btnAgregarMaterial);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.nudAlmohadones);
            this.Controls.Add(this.nudCajones);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblAlmohadones);
            this.Controls.Add(this.lblCajones);
            this.Controls.Add(this.lblTipoModelo);
            this.Controls.Add(this.lblMaterialesModelo);
            this.Controls.Add(this.lblColoresModelo);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "FrmNuevoModelo";
            this.Text = "Nuevo Modelo";
            this.Load += new System.EventHandler(this.AM_Modelos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCajones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlmohadones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlto;
        private System.Windows.Forms.Label lblProfundidad;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTipoModelo;
        private System.Windows.Forms.Label lblCajones;
        private System.Windows.Forms.Label lblAlmohadones;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProfundidad;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblColoresModelo;
        private System.Windows.Forms.NumericUpDown nudCajones;
        private System.Windows.Forms.NumericUpDown nudAlmohadones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarMaterial;
        private System.Windows.Forms.Label lblMaterialesModelo;
        private System.Windows.Forms.Label lblClaseMueble;
        private System.Windows.Forms.ComboBox cmbClaseDeMueble;
        private System.Windows.Forms.Button btnBorrarMateriales;
        private System.Windows.Forms.RichTextBox rtbMaterialesDetalle2;
    }
}