namespace pryEdLopezM
{
    partial class frmListaSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaSimple));
            this.mrcLstDgv = new System.Windows.Forms.GroupBox();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcEliminarElemento = new System.Windows.Forms.GroupBox();
            this.cmbEListaSimple = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.imgListaSimple = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.imgListaSimple)).BeginInit();
            this.mrcNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcLstDgv
            // 
            this.mrcLstDgv.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mrcLstDgv.Controls.Add(this.lstDatos);
            this.mrcLstDgv.Controls.Add(this.dgvDatos);
            this.mrcLstDgv.Location = new System.Drawing.Point(14, 201);
            this.mrcLstDgv.Name = "mrcLstDgv";
            this.mrcLstDgv.Size = new System.Drawing.Size(548, 291);
            this.mrcLstDgv.TabIndex = 16;
            this.mrcLstDgv.TabStop = false;
            this.mrcLstDgv.Text = "Listado en una Lista y una Grilla";
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(12, 31);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(185, 238);
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
            this.dgvDatos.Size = new System.Drawing.Size(329, 241);
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
            this.mrcEliminarElemento.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mrcEliminarElemento.Controls.Add(this.cmbEListaSimple);
            this.mrcEliminarElemento.Controls.Add(this.btnEliminar);
            this.mrcEliminarElemento.Controls.Add(this.label3);
            this.mrcEliminarElemento.Location = new System.Drawing.Point(389, 12);
            this.mrcEliminarElemento.Name = "mrcEliminarElemento";
            this.mrcEliminarElemento.Size = new System.Drawing.Size(173, 166);
            this.mrcEliminarElemento.TabIndex = 15;
            this.mrcEliminarElemento.TabStop = false;
            this.mrcEliminarElemento.Text = "Elemento Eliminado";
            // 
            // cmbEListaSimple
            // 
            this.cmbEListaSimple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEListaSimple.FormattingEnabled = true;
            this.cmbEListaSimple.Location = new System.Drawing.Point(53, 25);
            this.cmbEListaSimple.Name = "cmbEListaSimple";
            this.cmbEListaSimple.Size = new System.Drawing.Size(108, 21);
            this.cmbEListaSimple.TabIndex = 7;
            this.cmbEListaSimple.SelectedIndexChanged += new System.EventHandler(this.cmbEListaSimple_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(15, 62);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            // imgListaSimple
            // 
            this.imgListaSimple.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.imgListaSimple.Image = ((System.Drawing.Image)(resources.GetObject("imgListaSimple.Image")));
            this.imgListaSimple.Location = new System.Drawing.Point(14, 12);
            this.imgListaSimple.Name = "imgListaSimple";
            this.imgListaSimple.Size = new System.Drawing.Size(158, 166);
            this.imgListaSimple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgListaSimple.TabIndex = 14;
            this.imgListaSimple.TabStop = false;
            // 
            // mrcNuevoElemento
            // 
            this.mrcNuevoElemento.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mrcNuevoElemento.Controls.Add(this.btnAgregar);
            this.mrcNuevoElemento.Controls.Add(this.txtTraN);
            this.mrcNuevoElemento.Controls.Add(this.txtNomN);
            this.mrcNuevoElemento.Controls.Add(this.txtCodN);
            this.mrcNuevoElemento.Controls.Add(this.lblTra);
            this.mrcNuevoElemento.Controls.Add(this.lblNom);
            this.mrcNuevoElemento.Controls.Add(this.lblCod);
            this.mrcNuevoElemento.Location = new System.Drawing.Point(195, 12);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(173, 166);
            this.mrcNuevoElemento.TabIndex = 13;
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
            this.txtTraN.TextChanged += new System.EventHandler(this.txtTraN_TextChanged);
            // 
            // txtNomN
            // 
            this.txtNomN.Location = new System.Drawing.Point(61, 59);
            this.txtNomN.Name = "txtNomN";
            this.txtNomN.Size = new System.Drawing.Size(100, 20);
            this.txtNomN.TabIndex = 4;
            this.txtNomN.TextChanged += new System.EventHandler(this.txtNomN_TextChanged);
            // 
            // txtCodN
            // 
            this.txtCodN.Location = new System.Drawing.Point(61, 25);
            this.txtCodN.Name = "txtCodN";
            this.txtCodN.Size = new System.Drawing.Size(100, 20);
            this.txtCodN.TabIndex = 3;
            this.txtCodN.TextChanged += new System.EventHandler(this.txtCodN_TextChanged);
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
            // frmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(575, 504);
            this.Controls.Add(this.mrcLstDgv);
            this.Controls.Add(this.mrcEliminarElemento);
            this.Controls.Add(this.imgListaSimple);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Name = "frmListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura lineal dinamica Lista Simple";
            this.Load += new System.EventHandler(this.frmListaSimple_Load);
            this.mrcLstDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.mrcEliminarElemento.ResumeLayout(false);
            this.mrcEliminarElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgListaSimple)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox imgListaSimple;
        private System.Windows.Forms.GroupBox mrcNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTraN;
        private System.Windows.Forms.TextBox txtNomN;
        private System.Windows.Forms.TextBox txtCodN;
        private System.Windows.Forms.Label lblTra;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.ComboBox cmbEListaSimple;
    }
}