
namespace FormularioFabrica
{
    partial class FrmHistorialDeEnvios
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
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.dgvHistorialEnvios = new System.Windows.Forms.DataGridView();
            this.cmbOrderBy = new System.Windows.Forms.ComboBox();
            this.cmbOrderType = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblOrdenamiento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialEnvios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOrdenar.Location = new System.Drawing.Point(630, 16);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(293, 45);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // dgvHistorialEnvios
            // 
            this.dgvHistorialEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialEnvios.Location = new System.Drawing.Point(12, 87);
            this.dgvHistorialEnvios.Name = "dgvHistorialEnvios";
            this.dgvHistorialEnvios.RowHeadersWidth = 51;
            this.dgvHistorialEnvios.RowTemplate.Height = 24;
            this.dgvHistorialEnvios.Size = new System.Drawing.Size(1320, 451);
            this.dgvHistorialEnvios.TabIndex = 3;
            // 
            // cmbOrderBy
            // 
            this.cmbOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderBy.FormattingEnabled = true;
            this.cmbOrderBy.Location = new System.Drawing.Point(12, 37);
            this.cmbOrderBy.Name = "cmbOrderBy";
            this.cmbOrderBy.Size = new System.Drawing.Size(246, 24);
            this.cmbOrderBy.TabIndex = 4;
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Items.AddRange(new object[] {
            "Ascendiente",
            "Descendiente"});
            this.cmbOrderType.Location = new System.Drawing.Point(324, 37);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(246, 24);
            this.cmbOrderType.TabIndex = 5;
            this.cmbOrderType.SelectedIndexChanged += new System.EventHandler(this.cmbOrderType_SelectedIndexChanged);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCriterio.Location = new System.Drawing.Point(12, 16);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(60, 18);
            this.lblCriterio.TabIndex = 6;
            this.lblCriterio.Text = "Criterio ";
            // 
            // lblOrdenamiento
            // 
            this.lblOrdenamiento.AutoSize = true;
            this.lblOrdenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblOrdenamiento.Location = new System.Drawing.Point(321, 16);
            this.lblOrdenamiento.Name = "lblOrdenamiento";
            this.lblOrdenamiento.Size = new System.Drawing.Size(49, 18);
            this.lblOrdenamiento.TabIndex = 7;
            this.lblOrdenamiento.Text = "Orden";
            // 
            // FrmHistorialDeEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 550);
            this.Controls.Add(this.lblOrdenamiento);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cmbOrderType);
            this.Controls.Add(this.cmbOrderBy);
            this.Controls.Add(this.dgvHistorialEnvios);
            this.Controls.Add(this.btnOrdenar);
            this.Name = "FrmHistorialDeEnvios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Envíos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHistorialDeEnvios_FormClosing);
            this.Load += new System.EventHandler(this.FrmHistorialDeEnvios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialEnvios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.DataGridView dgvHistorialEnvios;
        private System.Windows.Forms.ComboBox cmbOrderBy;
        private System.Windows.Forms.ComboBox cmbOrderType;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblOrdenamiento;
    }
}