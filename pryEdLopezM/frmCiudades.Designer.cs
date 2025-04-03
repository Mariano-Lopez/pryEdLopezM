namespace pryEdLopezM
{
    partial class frmCiudades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCiudades));
            this.lblNomCiu = new System.Windows.Forms.Label();
            this.txtNomCiu = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lstCiudades = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNomCiu
            // 
            this.lblNomCiu.AutoSize = true;
            this.lblNomCiu.Location = new System.Drawing.Point(49, 12);
            this.lblNomCiu.Name = "lblNomCiu";
            this.lblNomCiu.Size = new System.Drawing.Size(47, 13);
            this.lblNomCiu.TabIndex = 0;
            this.lblNomCiu.Text = "Nombre:";
            // 
            // txtNomCiu
            // 
            this.txtNomCiu.Location = new System.Drawing.Point(102, 9);
            this.txtNomCiu.Name = "txtNomCiu";
            this.txtNomCiu.Size = new System.Drawing.Size(100, 20);
            this.txtNomCiu.TabIndex = 1;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(127, 35);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lstCiudades
            // 
            this.lstCiudades.FormattingEnabled = true;
            this.lstCiudades.Location = new System.Drawing.Point(52, 64);
            this.lstCiudades.Name = "lstCiudades";
            this.lstCiudades.Size = new System.Drawing.Size(150, 134);
            this.lstCiudades.TabIndex = 3;
            // 
            // frmCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(243, 233);
            this.Controls.Add(this.lstCiudades);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtNomCiu);
            this.Controls.Add(this.lblNomCiu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCiudades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ciudades";
            this.Load += new System.EventHandler(this.frmCiudades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomCiu;
        private System.Windows.Forms.TextBox txtNomCiu;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ListBox lstCiudades;
    }
}