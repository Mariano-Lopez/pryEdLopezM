namespace pryEdLopezM
{
    partial class frmBaseDatosRespasoOperaciones
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
            this.lblOp = new System.Windows.Forms.Label();
            this.cmbOperaciones = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblCuadro = new System.Windows.Forms.Label();
            this.dgvBBDD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBBDD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(12, 9);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(353, 24);
            this.lblOp.TabIndex = 0;
            this.lblOp.Text = "Operación a realizar en la base de datos:";
            // 
            // cmbOperaciones
            // 
            this.cmbOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperaciones.FormattingEnabled = true;
            this.cmbOperaciones.Location = new System.Drawing.Point(371, 9);
            this.cmbOperaciones.Name = "cmbOperaciones";
            this.cmbOperaciones.Size = new System.Drawing.Size(304, 28);
            this.cmbOperaciones.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(681, 6);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 33);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblCuadro
            // 
            this.lblCuadro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCuadro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuadro.Location = new System.Drawing.Point(15, 48);
            this.lblCuadro.Name = "lblCuadro";
            this.lblCuadro.Size = new System.Drawing.Size(741, 90);
            this.lblCuadro.TabIndex = 3;
            this.lblCuadro.Text = "Ejemplo";
            // 
            // dgvBBDD
            // 
            this.dgvBBDD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBBDD.Location = new System.Drawing.Point(15, 157);
            this.dgvBBDD.Name = "dgvBBDD";
            this.dgvBBDD.Size = new System.Drawing.Size(743, 281);
            this.dgvBBDD.TabIndex = 4;
            // 
            // frmBaseDatosRespasoOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.dgvBBDD);
            this.Controls.Add(this.lblCuadro);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cmbOperaciones);
            this.Controls.Add(this.lblOp);
            this.Name = "frmBaseDatosRespasoOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repaso de operaciones de base de datos";
            this.Load += new System.EventHandler(this.frmBaseDatosRespasoOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBBDD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.ComboBox cmbOperaciones;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblCuadro;
        private System.Windows.Forms.DataGridView dgvBBDD;
    }
}