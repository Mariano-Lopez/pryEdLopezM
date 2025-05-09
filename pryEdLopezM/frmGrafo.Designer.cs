namespace pryEdLopezM
{
    partial class frmGrafo
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
            this.imgGrafo = new System.Windows.Forms.PictureBox();
            this.mrcConsultarDatos = new System.Windows.Forms.GroupBox();
            this.mrcCargaDeDatos = new System.Windows.Forms.GroupBox();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.lblDestinoC = new System.Windows.Forms.Label();
            this.lblPrecioC = new System.Windows.Forms.Label();
            this.lblOrigenC = new System.Windows.Forms.Label();
            this.mrcListarViajes = new System.Windows.Forms.GroupBox();
            this.btnVerTV = new System.Windows.Forms.Button();
            this.btnOrigenes = new System.Windows.Forms.Button();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnListarDestinos = new System.Windows.Forms.Button();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dgvGrafo = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnCargarD = new System.Windows.Forms.Button();
            this.btnBorrarTodoD = new System.Windows.Forms.Button();
            this.txtPrecioD = new System.Windows.Forms.TextBox();
            this.cmbOrigenD = new System.Windows.Forms.ComboBox();
            this.cmbDestinoD = new System.Windows.Forms.ComboBox();
            this.lblDestinoD = new System.Windows.Forms.Label();
            this.lblPrecioD = new System.Windows.Forms.Label();
            this.lblOrigenD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgGrafo)).BeginInit();
            this.mrcConsultarDatos.SuspendLayout();
            this.mrcCargaDeDatos.SuspendLayout();
            this.mrcListarViajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgGrafo
            // 
            this.imgGrafo.Location = new System.Drawing.Point(31, 28);
            this.imgGrafo.Name = "imgGrafo";
            this.imgGrafo.Size = new System.Drawing.Size(205, 148);
            this.imgGrafo.TabIndex = 0;
            this.imgGrafo.TabStop = false;
            // 
            // mrcConsultarDatos
            // 
            this.mrcConsultarDatos.Controls.Add(this.btnCargarD);
            this.mrcConsultarDatos.Controls.Add(this.btnBorrarTodoD);
            this.mrcConsultarDatos.Controls.Add(this.txtPrecioD);
            this.mrcConsultarDatos.Controls.Add(this.cmbOrigenD);
            this.mrcConsultarDatos.Controls.Add(this.cmbDestinoD);
            this.mrcConsultarDatos.Controls.Add(this.lblDestinoD);
            this.mrcConsultarDatos.Controls.Add(this.lblPrecioD);
            this.mrcConsultarDatos.Controls.Add(this.lblOrigenD);
            this.mrcConsultarDatos.Location = new System.Drawing.Point(552, 28);
            this.mrcConsultarDatos.Name = "mrcConsultarDatos";
            this.mrcConsultarDatos.Size = new System.Drawing.Size(252, 148);
            this.mrcConsultarDatos.TabIndex = 1;
            this.mrcConsultarDatos.TabStop = false;
            this.mrcConsultarDatos.Text = "Consultar datos";
            // 
            // mrcCargaDeDatos
            // 
            this.mrcCargaDeDatos.Controls.Add(this.btnCargar);
            this.mrcCargaDeDatos.Controls.Add(this.btnBorrarTodo);
            this.mrcCargaDeDatos.Controls.Add(this.txtPrecio);
            this.mrcCargaDeDatos.Controls.Add(this.cmbOrigen);
            this.mrcCargaDeDatos.Controls.Add(this.cmbDestino);
            this.mrcCargaDeDatos.Controls.Add(this.lblDestinoC);
            this.mrcCargaDeDatos.Controls.Add(this.lblPrecioC);
            this.mrcCargaDeDatos.Controls.Add(this.lblOrigenC);
            this.mrcCargaDeDatos.Location = new System.Drawing.Point(268, 28);
            this.mrcCargaDeDatos.Name = "mrcCargaDeDatos";
            this.mrcCargaDeDatos.Size = new System.Drawing.Size(252, 148);
            this.mrcCargaDeDatos.TabIndex = 0;
            this.mrcCargaDeDatos.TabStop = false;
            this.mrcCargaDeDatos.Text = "Carga de datos";
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(16, 107);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarTodo.TabIndex = 14;
            this.btnBorrarTodo.Text = "Borrar todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(53, 77);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 13;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(53, 23);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigen.TabIndex = 12;
            // 
            // cmbDestino
            // 
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(53, 50);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbDestino.TabIndex = 11;
            // 
            // lblDestinoC
            // 
            this.lblDestinoC.AutoSize = true;
            this.lblDestinoC.Location = new System.Drawing.Point(9, 53);
            this.lblDestinoC.Name = "lblDestinoC";
            this.lblDestinoC.Size = new System.Drawing.Size(46, 13);
            this.lblDestinoC.TabIndex = 10;
            this.lblDestinoC.Text = "Destino:";
            // 
            // lblPrecioC
            // 
            this.lblPrecioC.AutoSize = true;
            this.lblPrecioC.Location = new System.Drawing.Point(9, 81);
            this.lblPrecioC.Name = "lblPrecioC";
            this.lblPrecioC.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioC.TabIndex = 9;
            this.lblPrecioC.Text = "Precio:";
            // 
            // lblOrigenC
            // 
            this.lblOrigenC.AutoSize = true;
            this.lblOrigenC.Location = new System.Drawing.Point(9, 26);
            this.lblOrigenC.Name = "lblOrigenC";
            this.lblOrigenC.Size = new System.Drawing.Size(41, 13);
            this.lblOrigenC.TabIndex = 8;
            this.lblOrigenC.Text = "Origen:";
            // 
            // mrcListarViajes
            // 
            this.mrcListarViajes.Controls.Add(this.btnVerTV);
            this.mrcListarViajes.Controls.Add(this.btnOrigenes);
            this.mrcListarViajes.Controls.Add(this.cmbHasta);
            this.mrcListarViajes.Controls.Add(this.lblHasta);
            this.mrcListarViajes.Controls.Add(this.btnListarDestinos);
            this.mrcListarViajes.Controls.Add(this.cmbDesde);
            this.mrcListarViajes.Controls.Add(this.lblDesde);
            this.mrcListarViajes.Controls.Add(this.dgvGrafo);
            this.mrcListarViajes.Location = new System.Drawing.Point(31, 192);
            this.mrcListarViajes.Name = "mrcListarViajes";
            this.mrcListarViajes.Size = new System.Drawing.Size(773, 323);
            this.mrcListarViajes.TabIndex = 1;
            this.mrcListarViajes.TabStop = false;
            this.mrcListarViajes.Text = "Listar viajes .....";
            // 
            // btnVerTV
            // 
            this.btnVerTV.Location = new System.Drawing.Point(591, 23);
            this.btnVerTV.Name = "btnVerTV";
            this.btnVerTV.Size = new System.Drawing.Size(120, 23);
            this.btnVerTV.TabIndex = 7;
            this.btnVerTV.Text = "Ver todos los viajes";
            this.btnVerTV.UseVisualStyleBackColor = true;
            // 
            // btnOrigenes
            // 
            this.btnOrigenes.Location = new System.Drawing.Point(474, 23);
            this.btnOrigenes.Name = "btnOrigenes";
            this.btnOrigenes.Size = new System.Drawing.Size(95, 23);
            this.btnOrigenes.TabIndex = 6;
            this.btnOrigenes.Text = "Listar origenes";
            this.btnOrigenes.UseVisualStyleBackColor = true;
            // 
            // cmbHasta
            // 
            this.cmbHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(334, 25);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(121, 21);
            this.cmbHasta.TabIndex = 5;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(290, 28);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 4;
            this.lblHasta.Text = "Hasta:";
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.Location = new System.Drawing.Point(189, 23);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(95, 23);
            this.btnListarDestinos.TabIndex = 3;
            this.btnListarDestinos.Text = "Listar destinos";
            this.btnListarDestinos.UseVisualStyleBackColor = true;
            // 
            // cmbDesde
            // 
            this.cmbDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(53, 25);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(121, 21);
            this.cmbDesde.TabIndex = 2;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(6, 28);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 1;
            this.lblDesde.Text = "Desde:";
            // 
            // dgvGrafo
            // 
            this.dgvGrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafo.Location = new System.Drawing.Point(6, 67);
            this.dgvGrafo.Name = "dgvGrafo";
            this.dgvGrafo.Size = new System.Drawing.Size(761, 250);
            this.dgvGrafo.TabIndex = 0;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(143, 107);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 15;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnCargarD
            // 
            this.btnCargarD.Location = new System.Drawing.Point(156, 105);
            this.btnCargarD.Name = "btnCargarD";
            this.btnCargarD.Size = new System.Drawing.Size(75, 23);
            this.btnCargarD.TabIndex = 23;
            this.btnCargarD.Text = "Cargar";
            this.btnCargarD.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTodoD
            // 
            this.btnBorrarTodoD.Location = new System.Drawing.Point(29, 105);
            this.btnBorrarTodoD.Name = "btnBorrarTodoD";
            this.btnBorrarTodoD.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarTodoD.TabIndex = 22;
            this.btnBorrarTodoD.Text = "Borrar todo";
            this.btnBorrarTodoD.UseVisualStyleBackColor = true;
            // 
            // txtPrecioD
            // 
            this.txtPrecioD.Location = new System.Drawing.Point(66, 75);
            this.txtPrecioD.Name = "txtPrecioD";
            this.txtPrecioD.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioD.TabIndex = 21;
            // 
            // cmbOrigenD
            // 
            this.cmbOrigenD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigenD.FormattingEnabled = true;
            this.cmbOrigenD.Location = new System.Drawing.Point(66, 21);
            this.cmbOrigenD.Name = "cmbOrigenD";
            this.cmbOrigenD.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigenD.TabIndex = 20;
            // 
            // cmbDestinoD
            // 
            this.cmbDestinoD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinoD.FormattingEnabled = true;
            this.cmbDestinoD.Location = new System.Drawing.Point(66, 48);
            this.cmbDestinoD.Name = "cmbDestinoD";
            this.cmbDestinoD.Size = new System.Drawing.Size(121, 21);
            this.cmbDestinoD.TabIndex = 19;
            // 
            // lblDestinoD
            // 
            this.lblDestinoD.AutoSize = true;
            this.lblDestinoD.Location = new System.Drawing.Point(22, 51);
            this.lblDestinoD.Name = "lblDestinoD";
            this.lblDestinoD.Size = new System.Drawing.Size(46, 13);
            this.lblDestinoD.TabIndex = 18;
            this.lblDestinoD.Text = "Destino:";
            // 
            // lblPrecioD
            // 
            this.lblPrecioD.AutoSize = true;
            this.lblPrecioD.Location = new System.Drawing.Point(22, 79);
            this.lblPrecioD.Name = "lblPrecioD";
            this.lblPrecioD.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioD.TabIndex = 17;
            this.lblPrecioD.Text = "Precio:";
            // 
            // lblOrigenD
            // 
            this.lblOrigenD.AutoSize = true;
            this.lblOrigenD.Location = new System.Drawing.Point(22, 24);
            this.lblOrigenD.Name = "lblOrigenD";
            this.lblOrigenD.Size = new System.Drawing.Size(41, 13);
            this.lblOrigenD.TabIndex = 16;
            this.lblOrigenD.Text = "Origen:";
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 527);
            this.Controls.Add(this.mrcListarViajes);
            this.Controls.Add(this.mrcConsultarDatos);
            this.Controls.Add(this.mrcCargaDeDatos);
            this.Controls.Add(this.imgGrafo);
            this.Name = "frmGrafo";
            this.Text = "frmGrafo";
            this.Load += new System.EventHandler(this.frmGrafo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgGrafo)).EndInit();
            this.mrcConsultarDatos.ResumeLayout(false);
            this.mrcConsultarDatos.PerformLayout();
            this.mrcCargaDeDatos.ResumeLayout(false);
            this.mrcCargaDeDatos.PerformLayout();
            this.mrcListarViajes.ResumeLayout(false);
            this.mrcListarViajes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgGrafo;
        private System.Windows.Forms.GroupBox mrcConsultarDatos;
        private System.Windows.Forms.GroupBox mrcCargaDeDatos;
        private System.Windows.Forms.GroupBox mrcListarViajes;
        private System.Windows.Forms.Button btnListarDestinos;
        private System.Windows.Forms.ComboBox cmbDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DataGridView dgvGrafo;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnVerTV;
        private System.Windows.Forms.Button btnOrigenes;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label lblDestinoC;
        private System.Windows.Forms.Label lblPrecioC;
        private System.Windows.Forms.Label lblOrigenC;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnCargarD;
        private System.Windows.Forms.Button btnBorrarTodoD;
        private System.Windows.Forms.TextBox txtPrecioD;
        private System.Windows.Forms.ComboBox cmbOrigenD;
        private System.Windows.Forms.ComboBox cmbDestinoD;
        private System.Windows.Forms.Label lblDestinoD;
        private System.Windows.Forms.Label lblPrecioD;
        private System.Windows.Forms.Label lblOrigenD;
    }
}