namespace pryEdLopezM
{
    partial class frmArbolBinario
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
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTraN = new System.Windows.Forms.TextBox();
            this.txtNomN = new System.Windows.Forms.TextBox();
            this.txtCodN = new System.Windows.Forms.TextBox();
            this.lblTra = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.mrcEliminarElemento = new System.Windows.Forms.GroupBox();
            this.cmbEListaDoble = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.mrcLstArbol = new System.Windows.Forms.GroupBox();
            this.optPostOrder = new System.Windows.Forms.RadioButton();
            this.optPreOrder = new System.Windows.Forms.RadioButton();
            this.optInOrder = new System.Windows.Forms.RadioButton();
            this.dgvArbolBinario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcNuevoElemento.SuspendLayout();
            this.mrcEliminarElemento.SuspendLayout();
            this.mrcLstArbol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbolBinario)).BeginInit();
            this.SuspendLayout();
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(12, 12);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(223, 166);
            this.tvArbol.TabIndex = 0;
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
            this.mrcNuevoElemento.Location = new System.Drawing.Point(251, 12);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(173, 166);
            this.mrcNuevoElemento.TabIndex = 18;
            this.mrcNuevoElemento.TabStop = false;
            this.mrcNuevoElemento.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(23, 118);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 37);
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
            // mrcEliminarElemento
            // 
            this.mrcEliminarElemento.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mrcEliminarElemento.Controls.Add(this.cmbEListaDoble);
            this.mrcEliminarElemento.Controls.Add(this.btnEliminar);
            this.mrcEliminarElemento.Controls.Add(this.label3);
            this.mrcEliminarElemento.Location = new System.Drawing.Point(440, 12);
            this.mrcEliminarElemento.Name = "mrcEliminarElemento";
            this.mrcEliminarElemento.Size = new System.Drawing.Size(173, 92);
            this.mrcEliminarElemento.TabIndex = 20;
            this.mrcEliminarElemento.TabStop = false;
            this.mrcEliminarElemento.Text = "Elemento Eliminado";
            // 
            // cmbEListaDoble
            // 
            this.cmbEListaDoble.FormattingEnabled = true;
            this.cmbEListaDoble.Location = new System.Drawing.Point(53, 25);
            this.cmbEListaDoble.Name = "cmbEListaDoble";
            this.cmbEListaDoble.Size = new System.Drawing.Size(108, 21);
            this.cmbEListaDoble.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(15, 62);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
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
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(455, 127);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(138, 42);
            this.btnEquilibrar.TabIndex = 8;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            this.btnEquilibrar.Click += new System.EventHandler(this.btnEquilibrar_Click);
            // 
            // mrcLstArbol
            // 
            this.mrcLstArbol.Controls.Add(this.optPostOrder);
            this.mrcLstArbol.Controls.Add(this.optPreOrder);
            this.mrcLstArbol.Controls.Add(this.optInOrder);
            this.mrcLstArbol.Controls.Add(this.dgvArbolBinario);
            this.mrcLstArbol.Location = new System.Drawing.Point(12, 197);
            this.mrcLstArbol.Name = "mrcLstArbol";
            this.mrcLstArbol.Size = new System.Drawing.Size(601, 188);
            this.mrcLstArbol.TabIndex = 21;
            this.mrcLstArbol.TabStop = false;
            this.mrcLstArbol.Text = "Listado del árbol";
            // 
            // optPostOrder
            // 
            this.optPostOrder.AutoSize = true;
            this.optPostOrder.Location = new System.Drawing.Point(17, 98);
            this.optPostOrder.Name = "optPostOrder";
            this.optPostOrder.Size = new System.Drawing.Size(75, 17);
            this.optPostOrder.TabIndex = 3;
            this.optPostOrder.TabStop = true;
            this.optPostOrder.Text = "Post-Order";
            this.optPostOrder.UseVisualStyleBackColor = true;
            // 
            // optPreOrder
            // 
            this.optPreOrder.AutoSize = true;
            this.optPreOrder.Location = new System.Drawing.Point(17, 63);
            this.optPreOrder.Name = "optPreOrder";
            this.optPreOrder.Size = new System.Drawing.Size(70, 17);
            this.optPreOrder.TabIndex = 2;
            this.optPreOrder.TabStop = true;
            this.optPreOrder.Text = "Pre-Order";
            this.optPreOrder.UseVisualStyleBackColor = true;
            // 
            // optInOrder
            // 
            this.optInOrder.AutoSize = true;
            this.optInOrder.Location = new System.Drawing.Point(17, 29);
            this.optInOrder.Name = "optInOrder";
            this.optInOrder.Size = new System.Drawing.Size(63, 17);
            this.optInOrder.TabIndex = 1;
            this.optInOrder.TabStop = true;
            this.optInOrder.Text = "In-Order";
            this.optInOrder.UseVisualStyleBackColor = true;
            // 
            // dgvArbolBinario
            // 
            this.dgvArbolBinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbolBinario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvArbolBinario.Location = new System.Drawing.Point(177, 19);
            this.dgvArbolBinario.Name = "dgvArbolBinario";
            this.dgvArbolBinario.Size = new System.Drawing.Size(404, 150);
            this.dgvArbolBinario.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.Name = "Column3";
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(630, 406);
            this.Controls.Add(this.mrcLstArbol);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.mrcEliminarElemento);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Controls.Add(this.tvArbol);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructur de datos - Arbol binario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            this.mrcEliminarElemento.ResumeLayout(false);
            this.mrcEliminarElemento.PerformLayout();
            this.mrcLstArbol.ResumeLayout(false);
            this.mrcLstArbol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbolBinario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.GroupBox mrcNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTraN;
        private System.Windows.Forms.TextBox txtNomN;
        private System.Windows.Forms.TextBox txtCodN;
        private System.Windows.Forms.Label lblTra;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.GroupBox mrcEliminarElemento;
        private System.Windows.Forms.ComboBox cmbEListaDoble;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.GroupBox mrcLstArbol;
        private System.Windows.Forms.RadioButton optPostOrder;
        private System.Windows.Forms.RadioButton optPreOrder;
        private System.Windows.Forms.RadioButton optInOrder;
        private System.Windows.Forms.DataGridView dgvArbolBinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}