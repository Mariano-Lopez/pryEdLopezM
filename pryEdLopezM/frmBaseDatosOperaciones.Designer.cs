namespace pryEdLopezM
{
    partial class frmBaseDatosOperaciones
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mrcOpPro = new System.Windows.Forms.GroupBox();
            this.btnProS = new System.Windows.Forms.Button();
            this.btnProMulti = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.mrcOpSelect = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSelecM = new System.Windows.Forms.Button();
            this.btnSelecS = new System.Windows.Forms.Button();
            this.mrcOpAlg = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInter = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.mrcOpPro.SuspendLayout();
            this.mrcOpSelect.SuspendLayout();
            this.mrcOpAlg.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // mrcOpPro
            // 
            this.mrcOpPro.Controls.Add(this.btnJuntar);
            this.mrcOpPro.Controls.Add(this.btnProMulti);
            this.mrcOpPro.Controls.Add(this.btnProS);
            this.mrcOpPro.Location = new System.Drawing.Point(14, 291);
            this.mrcOpPro.Name = "mrcOpPro";
            this.mrcOpPro.Size = new System.Drawing.Size(247, 110);
            this.mrcOpPro.TabIndex = 1;
            this.mrcOpPro.TabStop = false;
            this.mrcOpPro.Text = "Operaciones de proyección - SELECT";
            // 
            // btnProS
            // 
            this.btnProS.Location = new System.Drawing.Point(6, 19);
            this.btnProS.Name = "btnProS";
            this.btnProS.Size = new System.Drawing.Size(235, 23);
            this.btnProS.TabIndex = 0;
            this.btnProS.Text = "Proyección simple";
            this.btnProS.UseVisualStyleBackColor = true;
            // 
            // btnProMulti
            // 
            this.btnProMulti.Location = new System.Drawing.Point(6, 48);
            this.btnProMulti.Name = "btnProMulti";
            this.btnProMulti.Size = new System.Drawing.Size(235, 23);
            this.btnProMulti.TabIndex = 1;
            this.btnProMulti.Text = "Proyrcción multiatributo";
            this.btnProMulti.UseVisualStyleBackColor = true;
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(6, 77);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(235, 23);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // mrcOpSelect
            // 
            this.mrcOpSelect.Controls.Add(this.button4);
            this.mrcOpSelect.Controls.Add(this.btnSelecM);
            this.mrcOpSelect.Controls.Add(this.btnSelecS);
            this.mrcOpSelect.Location = new System.Drawing.Point(267, 291);
            this.mrcOpSelect.Name = "mrcOpSelect";
            this.mrcOpSelect.Size = new System.Drawing.Size(247, 110);
            this.mrcOpSelect.TabIndex = 3;
            this.mrcOpSelect.TabStop = false;
            this.mrcOpSelect.Text = "Operaciones de selección - SELECT";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Selección por convolución";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnSelecM
            // 
            this.btnSelecM.Location = new System.Drawing.Point(6, 48);
            this.btnSelecM.Name = "btnSelecM";
            this.btnSelecM.Size = new System.Drawing.Size(235, 23);
            this.btnSelecM.TabIndex = 1;
            this.btnSelecM.Text = "Selección multiatributo";
            this.btnSelecM.UseVisualStyleBackColor = true;
            // 
            // btnSelecS
            // 
            this.btnSelecS.Location = new System.Drawing.Point(6, 19);
            this.btnSelecS.Name = "btnSelecS";
            this.btnSelecS.Size = new System.Drawing.Size(235, 23);
            this.btnSelecS.TabIndex = 0;
            this.btnSelecS.Text = "Selección simple";
            this.btnSelecS.UseVisualStyleBackColor = true;
            // 
            // mrcOpAlg
            // 
            this.mrcOpAlg.Controls.Add(this.btnDiferencia);
            this.mrcOpAlg.Controls.Add(this.btnInter);
            this.mrcOpAlg.Controls.Add(this.btnUnion);
            this.mrcOpAlg.Location = new System.Drawing.Point(520, 291);
            this.mrcOpAlg.Name = "mrcOpAlg";
            this.mrcOpAlg.Size = new System.Drawing.Size(247, 110);
            this.mrcOpAlg.TabIndex = 3;
            this.mrcOpAlg.TabStop = false;
            this.mrcOpAlg.Text = "Operaciones Algebraicas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(6, 77);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(235, 23);
            this.btnDiferencia.TabIndex = 2;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            // 
            // btnInter
            // 
            this.btnInter.Location = new System.Drawing.Point(6, 48);
            this.btnInter.Name = "btnInter";
            this.btnInter.Size = new System.Drawing.Size(235, 23);
            this.btnInter.TabIndex = 1;
            this.btnInter.Text = "Intersección";
            this.btnInter.UseVisualStyleBackColor = true;
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(6, 19);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(235, 23);
            this.btnUnion.TabIndex = 0;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // frmBaseDatosOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 415);
            this.Controls.Add(this.mrcOpSelect);
            this.Controls.Add(this.mrcOpAlg);
            this.Controls.Add(this.mrcOpPro);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBaseDatosOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de datos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.mrcOpPro.ResumeLayout(false);
            this.mrcOpSelect.ResumeLayout(false);
            this.mrcOpAlg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox mrcOpPro;
        private System.Windows.Forms.Button btnProS;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProMulti;
        private System.Windows.Forms.GroupBox mrcOpSelect;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSelecM;
        private System.Windows.Forms.Button btnSelecS;
        private System.Windows.Forms.GroupBox mrcOpAlg;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInter;
        private System.Windows.Forms.Button btnUnion;
    }
}