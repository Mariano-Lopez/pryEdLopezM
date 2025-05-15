namespace pryEdLopezM
{
    partial class frmConsultaTabla
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
            this.dgvBBDD = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.cmbTablaLista = new System.Windows.Forms.ComboBox();
            this.lblDescr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBBDD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBBDD
            // 
            this.dgvBBDD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBBDD.Location = new System.Drawing.Point(12, 22);
            this.dgvBBDD.Name = "dgvBBDD";
            this.dgvBBDD.Size = new System.Drawing.Size(895, 454);
            this.dgvBBDD.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(805, 501);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(102, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // cmbTablaLista
            // 
            this.cmbTablaLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTablaLista.FormattingEnabled = true;
            this.cmbTablaLista.Items.AddRange(new object[] {
            "Autor",
            "Libro",
            "Pais",
            "Idioma"});
            this.cmbTablaLista.Location = new System.Drawing.Point(638, 500);
            this.cmbTablaLista.Name = "cmbTablaLista";
            this.cmbTablaLista.Size = new System.Drawing.Size(161, 21);
            this.cmbTablaLista.TabIndex = 2;
            this.cmbTablaLista.SelectedIndexChanged += new System.EventHandler(this.cmbTablaLista_SelectedIndexChanged);
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescr.Location = new System.Drawing.Point(437, 501);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(195, 16);
            this.lblDescr.TabIndex = 3;
            this.lblDescr.Text = "Tabla de la base de datos:";
            // 
            // frmConsultaBBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 532);
            this.Controls.Add(this.lblDescr);
            this.Controls.Add(this.cmbTablaLista);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvBBDD);
            this.Name = "frmConsultaBBDD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de una tabla";
            this.Load += new System.EventHandler(this.frmConsultaBBDD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBBDD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBBDD;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cmbTablaLista;
        private System.Windows.Forms.Label lblDescr;
    }
}