namespace pryEdLopezM
{
    partial class frmCola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCola));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCola = new System.Windows.Forms.ComboBox();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcEliminarElemento = new System.Windows.Forms.GroupBox();
            this.lblCodE = new System.Windows.Forms.Label();
            this.lblNomE = new System.Windows.Forms.Label();
            this.lblTraE = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imgCola = new System.Windows.Forms.PictureBox();
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTraN = new System.Windows.Forms.TextBox();
            this.txtNomN = new System.Windows.Forms.TextBox();
            this.txtCodN = new System.Windows.Forms.TextBox();
            this.lblTra = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.mrcEliminarElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCola)).BeginInit();
            this.mrcNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCola);
            this.groupBox1.Controls.Add(this.lstCola);
            this.groupBox1.Controls.Add(this.dgvCola);
            this.groupBox1.Location = new System.Drawing.Point(12, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 224);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado en una Lista y una Grilla";
            // 
            // cmbCola
            // 
            this.cmbCola.FormattingEnabled = true;
            this.cmbCola.Location = new System.Drawing.Point(12, 184);
            this.cmbCola.Name = "cmbCola";
            this.cmbCola.Size = new System.Drawing.Size(185, 21);
            this.cmbCola.TabIndex = 9;
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(12, 31);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(185, 147);
            this.lstCola.TabIndex = 8;
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvCola.Location = new System.Drawing.Point(207, 31);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.Size = new System.Drawing.Size(329, 174);
            this.dgvCola.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trámite";
            this.Column3.Name = "Column3";
            // 
            // mrcEliminarElemento
            // 
            this.mrcEliminarElemento.Controls.Add(this.lblCodE);
            this.mrcEliminarElemento.Controls.Add(this.lblNomE);
            this.mrcEliminarElemento.Controls.Add(this.lblTraE);
            this.mrcEliminarElemento.Controls.Add(this.btnEliminar);
            this.mrcEliminarElemento.Controls.Add(this.label1);
            this.mrcEliminarElemento.Controls.Add(this.label2);
            this.mrcEliminarElemento.Controls.Add(this.label3);
            this.mrcEliminarElemento.Location = new System.Drawing.Point(387, 12);
            this.mrcEliminarElemento.Name = "mrcEliminarElemento";
            this.mrcEliminarElemento.Size = new System.Drawing.Size(173, 166);
            this.mrcEliminarElemento.TabIndex = 11;
            this.mrcEliminarElemento.TabStop = false;
            this.mrcEliminarElemento.Text = "Elemento Eliminado";
            // 
            // lblCodE
            // 
            this.lblCodE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodE.Location = new System.Drawing.Point(61, 25);
            this.lblCodE.Name = "lblCodE";
            this.lblCodE.Size = new System.Drawing.Size(100, 23);
            this.lblCodE.TabIndex = 9;
            this.lblCodE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNomE
            // 
            this.lblNomE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNomE.Location = new System.Drawing.Point(61, 56);
            this.lblNomE.Name = "lblNomE";
            this.lblNomE.Size = new System.Drawing.Size(100, 23);
            this.lblNomE.TabIndex = 10;
            this.lblNomE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTraE
            // 
            this.lblTraE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTraE.Location = new System.Drawing.Point(61, 89);
            this.lblTraE.Name = "lblTraE";
            this.lblTraE.Size = new System.Drawing.Size(100, 23);
            this.lblTraE.TabIndex = 11;
            this.lblTraE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(23, 132);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trámite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código:";
            // 
            // imgCola
            // 
            this.imgCola.Image = ((System.Drawing.Image)(resources.GetObject("imgCola.Image")));
            this.imgCola.Location = new System.Drawing.Point(12, 12);
            this.imgCola.Name = "imgCola";
            this.imgCola.Size = new System.Drawing.Size(158, 166);
            this.imgCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCola.TabIndex = 10;
            this.imgCola.TabStop = false;
            // 
            // mrcNuevoElemento
            // 
            this.mrcNuevoElemento.Controls.Add(this.btnAgregar);
            this.mrcNuevoElemento.Controls.Add(this.txtTraN);
            this.mrcNuevoElemento.Controls.Add(this.txtNomN);
            this.mrcNuevoElemento.Controls.Add(this.txtCodN);
            this.mrcNuevoElemento.Controls.Add(this.lblTra);
            this.mrcNuevoElemento.Controls.Add(this.lblNom);
            this.mrcNuevoElemento.Controls.Add(this.lblCod);
            this.mrcNuevoElemento.Location = new System.Drawing.Point(193, 12);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(173, 166);
            this.mrcNuevoElemento.TabIndex = 9;
            this.mrcNuevoElemento.TabStop = false;
            this.mrcNuevoElemento.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(15, 132);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(146, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // txtTraN
            // 
            this.txtTraN.Location = new System.Drawing.Point(61, 92);
            this.txtTraN.Name = "txtTraN";
            this.txtTraN.Size = new System.Drawing.Size(100, 20);
            this.txtTraN.TabIndex = 5;
            // 
            // txtNomN
            // 
            this.txtNomN.Location = new System.Drawing.Point(61, 59);
            this.txtNomN.Name = "txtNomN";
            this.txtNomN.Size = new System.Drawing.Size(100, 20);
            this.txtNomN.TabIndex = 4;
            // 
            // txtCodN
            // 
            this.txtCodN.Location = new System.Drawing.Point(61, 25);
            this.txtCodN.Name = "txtCodN";
            this.txtCodN.Size = new System.Drawing.Size(100, 20);
            this.txtCodN.TabIndex = 3;
            // 
            // lblTra
            // 
            this.lblTra.AutoSize = true;
            this.lblTra.Location = new System.Drawing.Point(12, 95);
            this.lblTra.Name = "lblTra";
            this.lblTra.Size = new System.Drawing.Size(45, 13);
            this.lblTra.TabIndex = 2;
            this.lblTra.Text = "Trámite:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 62);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(47, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nombre:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(12, 28);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código:";
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(571, 436);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mrcEliminarElemento);
            this.Controls.Add(this.imgCola);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de datos - Cola";
            this.Load += new System.EventHandler(this.frmCola_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.mrcEliminarElemento.ResumeLayout(false);
            this.mrcEliminarElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCola)).EndInit();
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCola;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox mrcEliminarElemento;
        private System.Windows.Forms.Label lblCodE;
        private System.Windows.Forms.Label lblNomE;
        private System.Windows.Forms.Label lblTraE;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox imgCola;
        private System.Windows.Forms.GroupBox mrcNuevoElemento;
        private System.Windows.Forms.TextBox txtTraN;
        private System.Windows.Forms.TextBox txtNomN;
        private System.Windows.Forms.TextBox txtCodN;
        private System.Windows.Forms.Label lblTra;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btnAgregar;
    }
}