namespace pryEdLopezM
{
    partial class frmPila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPila));
            this.mrcLstDgv = new System.Windows.Forms.GroupBox();
            this.cmbPila = new System.Windows.Forms.ComboBox();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
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
            this.imgPila = new System.Windows.Forms.PictureBox();
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTraN = new System.Windows.Forms.TextBox();
            this.txtNomN = new System.Windows.Forms.TextBox();
            this.txtCodN = new System.Windows.Forms.TextBox();
            this.lblTra = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.mrcLstDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.mrcEliminarElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPila)).BeginInit();
            this.mrcNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcLstDgv
            // 
            this.mrcLstDgv.Controls.Add(this.cmbPila);
            this.mrcLstDgv.Controls.Add(this.lstDatos);
            this.mrcLstDgv.Controls.Add(this.dgvDatos);
            this.mrcLstDgv.Location = new System.Drawing.Point(12, 212);
            this.mrcLstDgv.Name = "mrcLstDgv";
            this.mrcLstDgv.Size = new System.Drawing.Size(548, 224);
            this.mrcLstDgv.TabIndex = 12;
            this.mrcLstDgv.TabStop = false;
            this.mrcLstDgv.Text = "Listado en una Lista y una Grilla";
            // 
            // cmbPila
            // 
            this.cmbPila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPila.FormattingEnabled = true;
            this.cmbPila.Location = new System.Drawing.Point(12, 184);
            this.cmbPila.Name = "cmbPila";
            this.cmbPila.Size = new System.Drawing.Size(185, 21);
            this.cmbPila.TabIndex = 9;
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(12, 31);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(185, 134);
            this.lstDatos.TabIndex = 8;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDatos.Location = new System.Drawing.Point(207, 31);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(329, 174);
            this.dgvDatos.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trámite";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
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
            this.mrcEliminarElemento.Location = new System.Drawing.Point(387, 23);
            this.mrcEliminarElemento.Name = "mrcEliminarElemento";
            this.mrcEliminarElemento.Size = new System.Drawing.Size(173, 166);
            this.mrcEliminarElemento.TabIndex = 11;
            this.mrcEliminarElemento.TabStop = false;
            this.mrcEliminarElemento.Text = "Elemento Eliminado";
            // 
            // lblCodE
            // 
            this.lblCodE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodE.Location = new System.Drawing.Point(61, 22);
            this.lblCodE.Name = "lblCodE";
            this.lblCodE.Size = new System.Drawing.Size(100, 23);
            this.lblCodE.TabIndex = 15;
            this.lblCodE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNomE
            // 
            this.lblNomE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNomE.Location = new System.Drawing.Point(61, 59);
            this.lblNomE.Name = "lblNomE";
            this.lblNomE.Size = new System.Drawing.Size(100, 23);
            this.lblNomE.TabIndex = 14;
            this.lblNomE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTraE
            // 
            this.lblTraE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTraE.Location = new System.Drawing.Point(61, 92);
            this.lblTraE.Name = "lblTraE";
            this.lblTraE.Size = new System.Drawing.Size(100, 23);
            this.lblTraE.TabIndex = 13;
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
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            // imgPila
            // 
            this.imgPila.Image = ((System.Drawing.Image)(resources.GetObject("imgPila.Image")));
            this.imgPila.Location = new System.Drawing.Point(12, 23);
            this.imgPila.Name = "imgPila";
            this.imgPila.Size = new System.Drawing.Size(158, 166);
            this.imgPila.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPila.TabIndex = 10;
            this.imgPila.TabStop = false;
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
            this.mrcNuevoElemento.Location = new System.Drawing.Point(193, 23);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(173, 166);
            this.mrcNuevoElemento.TabIndex = 9;
            this.mrcNuevoElemento.TabStop = false;
            this.mrcNuevoElemento.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(23, 132);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.mrcLstDgv);
            this.Controls.Add(this.mrcEliminarElemento);
            this.Controls.Add(this.imgPila);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de datos: Pila";
            this.Load += new System.EventHandler(this.frmPila_Load);
            this.mrcLstDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.mrcEliminarElemento.ResumeLayout(false);
            this.mrcEliminarElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPila)).EndInit();
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcLstDgv;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox mrcEliminarElemento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox imgPila;
        private System.Windows.Forms.GroupBox mrcNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTraN;
        private System.Windows.Forms.TextBox txtNomN;
        private System.Windows.Forms.TextBox txtCodN;
        private System.Windows.Forms.Label lblTra;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.ComboBox cmbPila;
        private System.Windows.Forms.Label lblCodE;
        private System.Windows.Forms.Label lblNomE;
        private System.Windows.Forms.Label lblTraE;
    }
}