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
            this.dgvBBDD = new System.Windows.Forms.DataGridView();
            this.mrcOpPro = new System.Windows.Forms.GroupBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnProMulti = new System.Windows.Forms.Button();
            this.btnProS = new System.Windows.Forms.Button();
            this.mrcOpSelect = new System.Windows.Forms.GroupBox();
            this.btnOpSConvo = new System.Windows.Forms.Button();
            this.btnSelecM = new System.Windows.Forms.Button();
            this.btnSelecS = new System.Windows.Forms.Button();
            this.mrcOpAlg = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInter = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBBDD)).BeginInit();
            this.mrcOpPro.SuspendLayout();
            this.mrcOpSelect.SuspendLayout();
            this.mrcOpAlg.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBBDD
            // 
            this.dgvBBDD.AllowUserToAddRows = false;
            this.dgvBBDD.AllowUserToDeleteRows = false;
            this.dgvBBDD.AllowUserToResizeColumns = false;
            this.dgvBBDD.AllowUserToResizeRows = false;
            this.dgvBBDD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBBDD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBBDD.Location = new System.Drawing.Point(12, 12);
            this.dgvBBDD.MultiSelect = false;
            this.dgvBBDD.Name = "dgvBBDD";
            this.dgvBBDD.ReadOnly = true;
            this.dgvBBDD.RowHeadersVisible = false;
            this.dgvBBDD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBBDD.Size = new System.Drawing.Size(755, 263);
            this.dgvBBDD.TabIndex = 0;
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
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(6, 77);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(235, 23);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // btnProMulti
            // 
            this.btnProMulti.Location = new System.Drawing.Point(6, 48);
            this.btnProMulti.Name = "btnProMulti";
            this.btnProMulti.Size = new System.Drawing.Size(235, 23);
            this.btnProMulti.TabIndex = 1;
            this.btnProMulti.Text = "Proyrcción multiatributo";
            this.btnProMulti.UseVisualStyleBackColor = true;
            this.btnProMulti.Click += new System.EventHandler(this.btnProMulti_Click);
            // 
            // btnProS
            // 
            this.btnProS.Location = new System.Drawing.Point(6, 19);
            this.btnProS.Name = "btnProS";
            this.btnProS.Size = new System.Drawing.Size(235, 23);
            this.btnProS.TabIndex = 0;
            this.btnProS.Text = "Proyección simple";
            this.btnProS.UseVisualStyleBackColor = true;
            this.btnProS.Click += new System.EventHandler(this.btnProS_Click);
            // 
            // mrcOpSelect
            // 
            this.mrcOpSelect.Controls.Add(this.btnOpSConvo);
            this.mrcOpSelect.Controls.Add(this.btnSelecM);
            this.mrcOpSelect.Controls.Add(this.btnSelecS);
            this.mrcOpSelect.Location = new System.Drawing.Point(267, 291);
            this.mrcOpSelect.Name = "mrcOpSelect";
            this.mrcOpSelect.Size = new System.Drawing.Size(247, 110);
            this.mrcOpSelect.TabIndex = 3;
            this.mrcOpSelect.TabStop = false;
            this.mrcOpSelect.Text = "Operaciones de selección - WHERE";
            // 
            // btnOpSConvo
            // 
            this.btnOpSConvo.Location = new System.Drawing.Point(6, 77);
            this.btnOpSConvo.Name = "btnOpSConvo";
            this.btnOpSConvo.Size = new System.Drawing.Size(235, 23);
            this.btnOpSConvo.TabIndex = 2;
            this.btnOpSConvo.Text = "Selección por convolución";
            this.btnOpSConvo.UseVisualStyleBackColor = true;
            this.btnOpSConvo.Click += new System.EventHandler(this.btnOpSConvo_Click);
            // 
            // btnSelecM
            // 
            this.btnSelecM.Location = new System.Drawing.Point(6, 48);
            this.btnSelecM.Name = "btnSelecM";
            this.btnSelecM.Size = new System.Drawing.Size(235, 23);
            this.btnSelecM.TabIndex = 1;
            this.btnSelecM.Text = "Selección multiatributo";
            this.btnSelecM.UseVisualStyleBackColor = true;
            this.btnSelecM.Click += new System.EventHandler(this.btnSelecM_Click);
            // 
            // btnSelecS
            // 
            this.btnSelecS.Location = new System.Drawing.Point(6, 19);
            this.btnSelecS.Name = "btnSelecS";
            this.btnSelecS.Size = new System.Drawing.Size(235, 23);
            this.btnSelecS.TabIndex = 0;
            this.btnSelecS.Text = "Selección simple";
            this.btnSelecS.UseVisualStyleBackColor = true;
            this.btnSelecS.Click += new System.EventHandler(this.btnSelecS_Click);
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
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // btnInter
            // 
            this.btnInter.Location = new System.Drawing.Point(6, 48);
            this.btnInter.Name = "btnInter";
            this.btnInter.Size = new System.Drawing.Size(235, 23);
            this.btnInter.TabIndex = 1;
            this.btnInter.Text = "Intersección";
            this.btnInter.UseVisualStyleBackColor = true;
            this.btnInter.Click += new System.EventHandler(this.btnInter_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(6, 19);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(235, 23);
            this.btnUnion.TabIndex = 0;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // frmBaseDatosOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(779, 415);
            this.Controls.Add(this.mrcOpSelect);
            this.Controls.Add(this.mrcOpAlg);
            this.Controls.Add(this.mrcOpPro);
            this.Controls.Add(this.dgvBBDD);
            this.Name = "frmBaseDatosOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de datos";
            this.Load += new System.EventHandler(this.frmBaseDatosOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBBDD)).EndInit();
            this.mrcOpPro.ResumeLayout(false);
            this.mrcOpSelect.ResumeLayout(false);
            this.mrcOpAlg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBBDD;
        private System.Windows.Forms.GroupBox mrcOpPro;
        private System.Windows.Forms.Button btnProS;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProMulti;
        private System.Windows.Forms.GroupBox mrcOpSelect;
        private System.Windows.Forms.Button btnOpSConvo;
        private System.Windows.Forms.Button btnSelecM;
        private System.Windows.Forms.Button btnSelecS;
        private System.Windows.Forms.GroupBox mrcOpAlg;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInter;
        private System.Windows.Forms.Button btnUnion;
    }
}