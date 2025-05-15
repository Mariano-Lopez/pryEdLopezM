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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblCuadro = new System.Windows.Forms.Label();
            this.dgvBBDD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBBDD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(12, 9);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(200, 13);
            this.lblOp.TabIndex = 0;
            this.lblOp.Text = "Operación a realizar en la base de datos:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(218, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(446, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(681, 4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // lblCuadro
            // 
            this.lblCuadro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCuadro.Location = new System.Drawing.Point(15, 30);
            this.lblCuadro.Name = "lblCuadro";
            this.lblCuadro.Size = new System.Drawing.Size(741, 90);
            this.lblCuadro.TabIndex = 3;
            // 
            // dgvBBDD
            // 
            this.dgvBBDD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBBDD.Location = new System.Drawing.Point(15, 135);
            this.dgvBBDD.Name = "dgvBBDD";
            this.dgvBBDD.Size = new System.Drawing.Size(743, 303);
            this.dgvBBDD.TabIndex = 4;
            // 
            // frmBaseDatosRespasoOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.dgvBBDD);
            this.Controls.Add(this.lblCuadro);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblOp);
            this.Name = "frmBaseDatosRespasoOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repaso de operaciones de base de datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBBDD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblCuadro;
        private System.Windows.Forms.DataGridView dgvBBDD;
    }
}