
namespace FormularioFabrica
{
    partial class FrmNuevoMueble
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
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.rtxtDetalleModelo = new System.Windows.Forms.RichTextBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.btnFabricar = new System.Windows.Forms.Button();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.cmbTipoMueble = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbModelo
            // 
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(21, 107);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(199, 24);
            this.cmbModelo.TabIndex = 0;
            this.cmbModelo.SelectedIndexChanged += new System.EventHandler(this.cmbModelo_SelectedIndexChanged);
            // 
            // rtxtDetalleModelo
            // 
            this.rtxtDetalleModelo.Location = new System.Drawing.Point(21, 229);
            this.rtxtDetalleModelo.Name = "rtxtDetalleModelo";
            this.rtxtDetalleModelo.Size = new System.Drawing.Size(378, 281);
            this.rtxtDetalleModelo.TabIndex = 1;
            this.rtxtDetalleModelo.Text = "";
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(21, 173);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(199, 24);
            this.cmbColor.TabIndex = 2;
            // 
            // btnFabricar
            // 
            this.btnFabricar.Location = new System.Drawing.Point(21, 530);
            this.btnFabricar.Name = "btnFabricar";
            this.btnFabricar.Size = new System.Drawing.Size(378, 59);
            this.btnFabricar.TabIndex = 3;
            this.btnFabricar.Text = "Fabricar";
            this.btnFabricar.UseVisualStyleBackColor = true;
            this.btnFabricar.Click += new System.EventHandler(this.btnFabricar_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(18, 87);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(54, 17);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(21, 153);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(41, 17);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "Color";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(288, 27);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 17);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(279, 52);
            this.nudCantidad.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 22);
            this.nudCantidad.TabIndex = 7;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbTipoMueble
            // 
            this.cmbTipoMueble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMueble.FormattingEnabled = true;
            this.cmbTipoMueble.Items.AddRange(new object[] {
            "Estanteria",
            "Mesa",
            "Placar",
            "Sillon"});
            this.cmbTipoMueble.Location = new System.Drawing.Point(21, 50);
            this.cmbTipoMueble.Name = "cmbTipoMueble";
            this.cmbTipoMueble.Size = new System.Drawing.Size(199, 24);
            this.cmbTipoMueble.TabIndex = 8;
            this.cmbTipoMueble.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMueble_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(21, 27);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 17);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "Tipo";
            // 
            // FrmNuevoMueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 612);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipoMueble);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.btnFabricar);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.rtxtDetalleModelo);
            this.Controls.Add(this.cmbModelo);
            this.Name = "FrmNuevoMueble";
            this.Text = "FrmNuevoMueble";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNuevoMueble_FormClosing);
            this.Load += new System.EventHandler(this.FrmNuevoMueble_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.RichTextBox rtxtDetalleModelo;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Button btnFabricar;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.ComboBox cmbTipoMueble;
        private System.Windows.Forms.Label lblTipo;
    }
}