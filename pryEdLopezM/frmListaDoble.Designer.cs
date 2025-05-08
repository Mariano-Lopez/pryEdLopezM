namespace pryEdLopezM
{
    partial class frmListaDoble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaDoble));
            this.mrcLstDgv = new System.Windows.Forms.GroupBox();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcEliminarElemento = new System.Windows.Forms.GroupBox();
            this.cmbEListaDoble = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.imgListaDible = new System.Windows.Forms.PictureBox();
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTraN = new System.Windows.Forms.TextBox();
            this.txtNomN = new System.Windows.Forms.TextBox();
            this.txtCodN = new System.Windows.Forms.TextBox();
            this.lblTra = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.mrcListar = new System.Windows.Forms.GroupBox();
            this.optDesc = new System.Windows.Forms.RadioButton();
            this.optAsc = new System.Windows.Forms.RadioButton();
            this.mrcLstDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.mrcEliminarElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgListaDible)).BeginInit();
            this.mrcNuevoElemento.SuspendLayout();
            this.mrcListar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcLstDgv
            // 
            this.mrcLstDgv.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mrcLstDgv.Controls.Add(this.lstDatos);
            this.mrcLstDgv.Controls.Add(this.dgvDatos);
            this.mrcLstDgv.Location = new System.Drawing.Point(9, 201);
            this.mrcLstDgv.Name = "mrcLstDgv";
            this.mrcLstDgv.Size = new System.Drawing.Size(548, 291);
            this.mrcLstDgv.TabIndex = 20;
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
            this.mrcEliminarElemento.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mrcEliminarElemento.Controls.Add(this.cmbEListaDoble);
            this.mrcEliminarElemento.Controls.Add(this.btnEliminar);
            this.mrcEliminarElemento.Controls.Add(this.label3);
            this.mrcEliminarElemento.Location = new System.Drawing.Point(384, 12);
            this.mrcEliminarElemento.Name = "mrcEliminarElemento";
            this.mrcEliminarElemento.Size = new System.Drawing.Size(173, 92);
            this.mrcEliminarElemento.TabIndex = 19;
            this.mrcEliminarElemento.TabStop = false;
            this.mrcEliminarElemento.Text = "Elemento Eliminado";
            // 
            // cmbEListaDoble
            // 
            this.cmbEListaDoble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEListaDoble.FormattingEnabled = true;
            this.cmbEListaDoble.Location = new System.Drawing.Point(53, 25);
            this.cmbEListaDoble.Name = "cmbEListaDoble";
            this.cmbEListaDoble.Size = new System.Drawing.Size(108, 21);
            this.cmbEListaDoble.TabIndex = 7;
            this.cmbEListaDoble.SelectedIndexChanged += new System.EventHandler(this.cmbEListaDoble_SelectedIndexChanged);
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
            // imgListaDible
            // 
            this.imgListaDible.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.imgListaDible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgListaDible.Image = ((System.Drawing.Image)(resources.GetObject("imgListaDible.Image")));
            this.imgListaDible.Location = new System.Drawing.Point(9, 12);
            this.imgListaDible.Name = "imgListaDible";
            this.imgListaDible.Size = new System.Drawing.Size(158, 166);
            this.imgListaDible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgListaDible.TabIndex = 18;
            this.imgListaDible.TabStop = false;
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
            this.mrcNuevoElemento.Location = new System.Drawing.Point(190, 12);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(173, 183);
            this.mrcNuevoElemento.TabIndex = 17;
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
            // mrcListar
            // 
            this.mrcListar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mrcListar.Controls.Add(this.optDesc);
            this.mrcListar.Controls.Add(this.optAsc);
            this.mrcListar.Location = new System.Drawing.Point(384, 110);
            this.mrcListar.Name = "mrcListar";
            this.mrcListar.Size = new System.Drawing.Size(173, 85);
            this.mrcListar.TabIndex = 20;
            this.mrcListar.TabStop = false;
            this.mrcListar.Text = "Listar datos";
            // 
            // optDesc
            // 
            this.optDesc.AutoSize = true;
            this.optDesc.Location = new System.Drawing.Point(15, 48);
            this.optDesc.Name = "optDesc";
            this.optDesc.Size = new System.Drawing.Size(89, 17);
            this.optDesc.TabIndex = 1;
            this.optDesc.Text = "Descendente";
            this.optDesc.UseVisualStyleBackColor = true;
            this.optDesc.CheckedChanged += new System.EventHandler(this.optDesc_CheckedChanged);
            // 
            // optAsc
            // 
            this.optAsc.AutoSize = true;
            this.optAsc.Checked = true;
            this.optAsc.Location = new System.Drawing.Point(15, 19);
            this.optAsc.Name = "optAsc";
            this.optAsc.Size = new System.Drawing.Size(82, 17);
            this.optAsc.TabIndex = 0;
            this.optAsc.TabStop = true;
            this.optAsc.Text = "Ascendente";
            this.optAsc.UseVisualStyleBackColor = true;
            this.optAsc.CheckedChanged += new System.EventHandler(this.optAsc_CheckedChanged);
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(567, 504);
            this.Controls.Add(this.mrcListar);
            this.Controls.Add(this.mrcLstDgv);
            this.Controls.Add(this.mrcEliminarElemento);
            this.Controls.Add(this.imgListaDible);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Name = "frmListaDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura lineal dinamica Lista Doble";
            this.Load += new System.EventHandler(this.frmListaDoble_Load);
            this.mrcLstDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.mrcEliminarElemento.ResumeLayout(false);
            this.mrcEliminarElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgListaDible)).EndInit();
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            this.mrcListar.ResumeLayout(false);
            this.mrcListar.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbEListaDoble;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox imgListaDible;
        private System.Windows.Forms.GroupBox mrcNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTraN;
        private System.Windows.Forms.TextBox txtNomN;
        private System.Windows.Forms.TextBox txtCodN;
        private System.Windows.Forms.Label lblTra;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.GroupBox mrcListar;
        private System.Windows.Forms.RadioButton optDesc;
        private System.Windows.Forms.RadioButton optAsc;
    }
}