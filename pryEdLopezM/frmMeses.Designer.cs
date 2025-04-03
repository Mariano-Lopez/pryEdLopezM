namespace pryEdLopezM
{
    partial class frmMeses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeses));
            this.dgvMes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.lblNumMes = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.numMes = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMes
            // 
            this.dgvMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvMes.Location = new System.Drawing.Point(12, 143);
            this.dgvMes.Name = "dgvMes";
            this.dgvMes.Size = new System.Drawing.Size(244, 150);
            this.dgvMes.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Número";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mes";
            this.Column2.Name = "Column2";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(12, 82);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 20);
            this.txtMes.TabIndex = 2;
            // 
            // lblNumMes
            // 
            this.lblNumMes.AutoSize = true;
            this.lblNumMes.Location = new System.Drawing.Point(12, 19);
            this.lblNumMes.Name = "lblNumMes";
            this.lblNumMes.Size = new System.Drawing.Size(56, 13);
            this.lblNumMes.TabIndex = 3;
            this.lblNumMes.Text = "N° de mes";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(9, 66);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(83, 13);
            this.lblMes.TabIndex = 4;
            this.lblMes.Text = "Nombre del mes";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(12, 114);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 23);
            this.btnGrabar.TabIndex = 5;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // numMes
            // 
            this.numMes.Location = new System.Drawing.Point(15, 35);
            this.numMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMes.Name = "numMes";
            this.numMes.Size = new System.Drawing.Size(97, 20);
            this.numMes.TabIndex = 6;
            this.numMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(286, 327);
            this.Controls.Add(this.numMes);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblNumMes);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.dgvMes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMeses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meses";
            this.Load += new System.EventHandler(this.frmMeses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label lblNumMes;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.NumericUpDown numMes;
    }
}