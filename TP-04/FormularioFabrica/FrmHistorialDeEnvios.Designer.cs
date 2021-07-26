
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbOrderBy = new System.Windows.Forms.ComboBox();
            this.cmbOrderType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(448, 21);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(228, 54);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(942, 374);
            this.dataGridView1.TabIndex = 3;
            // 
            // cmbOrderBy
            // 
            this.cmbOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderBy.FormattingEnabled = true;
            this.cmbOrderBy.Location = new System.Drawing.Point(12, 37);
            this.cmbOrderBy.Name = "cmbOrderBy";
            this.cmbOrderBy.Size = new System.Drawing.Size(169, 24);
            this.cmbOrderBy.TabIndex = 4;
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cmbOrderType.Location = new System.Drawing.Point(232, 37);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(171, 24);
            this.cmbOrderType.TabIndex = 5;
            // 
            // FrmHistorialDeEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 550);
            this.Controls.Add(this.cmbOrderType);
            this.Controls.Add(this.cmbOrderBy);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOrdenar);
            this.Name = "FrmHistorialDeEnvios";
            this.Text = "FrmHistorialDeEnvios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHistorialDeEnvios_FormClosing);
            this.Load += new System.EventHandler(this.FrmHistorialDeEnvios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbOrderBy;
        private System.Windows.Forms.ComboBox cmbOrderType;
    }
}