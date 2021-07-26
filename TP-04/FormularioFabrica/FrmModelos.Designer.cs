
namespace FormularioFabrica
{
    partial class FrmModelos
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
            this.dgvModelos = new System.Windows.Forms.DataGridView();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoDeFabricacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ancho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profundidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceModelos = new System.Windows.Forms.BindingSource(this.components);
            this.rtxtMatModelo = new System.Windows.Forms.RichTextBox();
            this.rtxtColores = new System.Windows.Forms.RichTextBox();
            this.btnNewModelo = new System.Windows.Forms.Button();
            this.btnDeleteModelo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnTodos = new System.Windows.Forms.RadioButton();
            this.rbtnSillones = new System.Windows.Forms.RadioButton();
            this.rbtnPlacares = new System.Windows.Forms.RadioButton();
            this.rbtnMesas = new System.Windows.Forms.RadioButton();
            this.rbtnEstanterias = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.checkBoxCajones = new System.Windows.Forms.CheckBox();
            this.lblCajonesHeader = new System.Windows.Forms.Label();
            this.lblCajonesDetail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceModelos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvModelos
            // 
            this.dgvModelos.AllowUserToAddRows = false;
            this.dgvModelos.AllowUserToDeleteRows = false;
            this.dgvModelos.AutoGenerateColumns = false;
            this.dgvModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificador,
            this.Nombre,
            this.CostoDeFabricacion,
            this.Alto,
            this.Ancho,
            this.Profundidad});
            this.dgvModelos.DataSource = this.bindingSourceModelos;
            this.dgvModelos.Location = new System.Drawing.Point(12, 55);
            this.dgvModelos.Name = "dgvModelos";
            this.dgvModelos.RowHeadersWidth = 51;
            this.dgvModelos.RowTemplate.Height = 24;
            this.dgvModelos.Size = new System.Drawing.Size(1095, 570);
            this.dgvModelos.TabIndex = 0;
            // 
            // Identificador
            // 
            this.Identificador.DataPropertyName = "Identificador";
            this.Identificador.HeaderText = "ID";
            this.Identificador.MinimumWidth = 6;
            this.Identificador.Name = "Identificador";
            this.Identificador.ReadOnly = true;
            this.Identificador.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Descripcion";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // CostoDeFabricacion
            // 
            this.CostoDeFabricacion.DataPropertyName = "CostoDeFabricacion";
            this.CostoDeFabricacion.HeaderText = "Costo ($)";
            this.CostoDeFabricacion.MinimumWidth = 6;
            this.CostoDeFabricacion.Name = "CostoDeFabricacion";
            this.CostoDeFabricacion.ReadOnly = true;
            this.CostoDeFabricacion.Width = 125;
            // 
            // Alto
            // 
            this.Alto.DataPropertyName = "Alto";
            this.Alto.HeaderText = "Alto";
            this.Alto.MinimumWidth = 6;
            this.Alto.Name = "Alto";
            this.Alto.ReadOnly = true;
            this.Alto.Width = 125;
            // 
            // Ancho
            // 
            this.Ancho.DataPropertyName = "Ancho";
            this.Ancho.HeaderText = "Ancho";
            this.Ancho.MinimumWidth = 6;
            this.Ancho.Name = "Ancho";
            this.Ancho.ReadOnly = true;
            this.Ancho.Width = 125;
            // 
            // Profundidad
            // 
            this.Profundidad.DataPropertyName = "Profundidad";
            this.Profundidad.HeaderText = "Profundidad";
            this.Profundidad.MinimumWidth = 6;
            this.Profundidad.Name = "Profundidad";
            this.Profundidad.ReadOnly = true;
            this.Profundidad.Width = 125;
            // 
            // bindingSourceModelos
            // 
            this.bindingSourceModelos.CurrentChanged += new System.EventHandler(this.bindingSourceModelos_CurrentChanged);
            // 
            // rtxtMatModelo
            // 
            this.rtxtMatModelo.Location = new System.Drawing.Point(1127, 66);
            this.rtxtMatModelo.Name = "rtxtMatModelo";
            this.rtxtMatModelo.ReadOnly = true;
            this.rtxtMatModelo.Size = new System.Drawing.Size(289, 273);
            this.rtxtMatModelo.TabIndex = 1;
            this.rtxtMatModelo.Text = "";
            // 
            // rtxtColores
            // 
            this.rtxtColores.Location = new System.Drawing.Point(1128, 394);
            this.rtxtColores.Name = "rtxtColores";
            this.rtxtColores.ReadOnly = true;
            this.rtxtColores.Size = new System.Drawing.Size(289, 108);
            this.rtxtColores.TabIndex = 2;
            this.rtxtColores.Text = "";
            // 
            // btnNewModelo
            // 
            this.btnNewModelo.Location = new System.Drawing.Point(181, 641);
            this.btnNewModelo.Name = "btnNewModelo";
            this.btnNewModelo.Size = new System.Drawing.Size(195, 55);
            this.btnNewModelo.TabIndex = 3;
            this.btnNewModelo.Text = "Nuevo Modelo";
            this.btnNewModelo.UseVisualStyleBackColor = true;
            this.btnNewModelo.Click += new System.EventHandler(this.btnNewModelo_Click);
            // 
            // btnDeleteModelo
            // 
            this.btnDeleteModelo.Location = new System.Drawing.Point(489, 645);
            this.btnDeleteModelo.Name = "btnDeleteModelo";
            this.btnDeleteModelo.Size = new System.Drawing.Size(258, 51);
            this.btnDeleteModelo.TabIndex = 4;
            this.btnDeleteModelo.Text = "Eliminar";
            this.btnDeleteModelo.UseVisualStyleBackColor = true;
            this.btnDeleteModelo.Click += new System.EventHandler(this.btnDeleteModelo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(1124, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Materiales ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(1124, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Colores";
            // 
            // rbtnTodos
            // 
            this.rbtnTodos.AutoSize = true;
            this.rbtnTodos.Location = new System.Drawing.Point(13, 13);
            this.rbtnTodos.Name = "rbtnTodos";
            this.rbtnTodos.Size = new System.Drawing.Size(69, 21);
            this.rbtnTodos.TabIndex = 7;
            this.rbtnTodos.TabStop = true;
            this.rbtnTodos.Tag = "0";
            this.rbtnTodos.Text = "Todos";
            this.rbtnTodos.UseVisualStyleBackColor = true;
            this.rbtnTodos.CheckedChanged += new System.EventHandler(this.rbtnTodos_CheckedChanged);
            // 
            // rbtnSillones
            // 
            this.rbtnSillones.AutoSize = true;
            this.rbtnSillones.Location = new System.Drawing.Point(574, 14);
            this.rbtnSillones.Name = "rbtnSillones";
            this.rbtnSillones.Size = new System.Drawing.Size(78, 21);
            this.rbtnSillones.TabIndex = 8;
            this.rbtnSillones.TabStop = true;
            this.rbtnSillones.Tag = "SLN";
            this.rbtnSillones.Text = "Sillones";
            this.rbtnSillones.UseVisualStyleBackColor = true;
            this.rbtnSillones.CheckedChanged += new System.EventHandler(this.rbtnSillones_CheckedChanged);
            // 
            // rbtnPlacares
            // 
            this.rbtnPlacares.AutoSize = true;
            this.rbtnPlacares.Location = new System.Drawing.Point(428, 14);
            this.rbtnPlacares.Name = "rbtnPlacares";
            this.rbtnPlacares.Size = new System.Drawing.Size(84, 21);
            this.rbtnPlacares.TabIndex = 9;
            this.rbtnPlacares.TabStop = true;
            this.rbtnPlacares.Tag = "PLC";
            this.rbtnPlacares.Text = "Placares";
            this.rbtnPlacares.UseVisualStyleBackColor = true;
            this.rbtnPlacares.CheckedChanged += new System.EventHandler(this.rbtnPlacares_CheckedChanged);
            // 
            // rbtnMesas
            // 
            this.rbtnMesas.AutoSize = true;
            this.rbtnMesas.Location = new System.Drawing.Point(306, 14);
            this.rbtnMesas.Name = "rbtnMesas";
            this.rbtnMesas.Size = new System.Drawing.Size(70, 21);
            this.rbtnMesas.TabIndex = 10;
            this.rbtnMesas.TabStop = true;
            this.rbtnMesas.Tag = "MES";
            this.rbtnMesas.Text = "Mesas";
            this.rbtnMesas.UseVisualStyleBackColor = true;
            this.rbtnMesas.CheckedChanged += new System.EventHandler(this.rbtnMesas_CheckedChanged);
            // 
            // rbtnEstanterias
            // 
            this.rbtnEstanterias.AutoSize = true;
            this.rbtnEstanterias.Location = new System.Drawing.Point(154, 14);
            this.rbtnEstanterias.Name = "rbtnEstanterias";
            this.rbtnEstanterias.Size = new System.Drawing.Size(100, 21);
            this.rbtnEstanterias.TabIndex = 11;
            this.rbtnEstanterias.TabStop = true;
            this.rbtnEstanterias.Tag = "EST";
            this.rbtnEstanterias.Text = "Estanterias";
            this.rbtnEstanterias.UseVisualStyleBackColor = true;
            this.rbtnEstanterias.CheckedChanged += new System.EventHandler(this.rbtnEstanterias_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(912, 641);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(204, 55);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Guardar y Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // checkBoxCajones
            // 
            this.checkBoxCajones.AutoSize = true;
            this.checkBoxCajones.Location = new System.Drawing.Point(869, 14);
            this.checkBoxCajones.Name = "checkBoxCajones";
            this.checkBoxCajones.Size = new System.Drawing.Size(125, 21);
            this.checkBoxCajones.TabIndex = 13;
            this.checkBoxCajones.Text = "Posee Cajones";
            this.checkBoxCajones.UseVisualStyleBackColor = true;
            this.checkBoxCajones.CheckedChanged += new System.EventHandler(this.checkBoxCajones_CheckedChanged);
            // 
            // lblCajonesHeader
            // 
            this.lblCajonesHeader.AutoSize = true;
            this.lblCajonesHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCajonesHeader.Location = new System.Drawing.Point(1127, 523);
            this.lblCajonesHeader.Name = "lblCajonesHeader";
            this.lblCajonesHeader.Size = new System.Drawing.Size(80, 20);
            this.lblCajonesHeader.TabIndex = 14;
            this.lblCajonesHeader.Text = "Cajones :";
            // 
            // lblCajonesDetail
            // 
            this.lblCajonesDetail.AutoSize = true;
            this.lblCajonesDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCajonesDetail.Location = new System.Drawing.Point(1214, 523);
            this.lblCajonesDetail.Name = "lblCajonesDetail";
            this.lblCajonesDetail.Size = new System.Drawing.Size(18, 20);
            this.lblCajonesDetail.TabIndex = 15;
            this.lblCajonesDetail.Text = "0";
            // 
            // FrmModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 720);
            this.Controls.Add(this.lblCajonesDetail);
            this.Controls.Add(this.lblCajonesHeader);
            this.Controls.Add(this.checkBoxCajones);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rbtnEstanterias);
            this.Controls.Add(this.rbtnMesas);
            this.Controls.Add(this.rbtnPlacares);
            this.Controls.Add(this.rbtnSillones);
            this.Controls.Add(this.rbtnTodos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteModelo);
            this.Controls.Add(this.btnNewModelo);
            this.Controls.Add(this.rtxtColores);
            this.Controls.Add(this.rtxtMatModelo);
            this.Controls.Add(this.dgvModelos);
            this.Name = "FrmModelos";
            this.Text = "Modelos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceModelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvModelos;
        private System.Windows.Forms.BindingSource bindingSourceModelos;
        private System.Windows.Forms.RichTextBox rtxtMatModelo;
        private System.Windows.Forms.RichTextBox rtxtColores;
        private System.Windows.Forms.Button btnNewModelo;
        private System.Windows.Forms.Button btnDeleteModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnTodos;
        private System.Windows.Forms.RadioButton rbtnSillones;
        private System.Windows.Forms.RadioButton rbtnPlacares;
        private System.Windows.Forms.RadioButton rbtnMesas;
        private System.Windows.Forms.RadioButton rbtnEstanterias;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoDeFabricacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ancho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profundidad;
        private System.Windows.Forms.CheckBox checkBoxCajones;
        private System.Windows.Forms.Label lblCajonesHeader;
        private System.Windows.Forms.Label lblCajonesDetail;
    }
}