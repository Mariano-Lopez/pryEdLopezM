using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdLopezM
{
    public partial class frmProvincias : Form
    {
        public frmProvincias()
        {
            InitializeComponent();
        }

        clsArchivo x = new clsArchivo();
        private void frmProvincias_Load(object sender, EventArgs e)
        {
            x.NombreArchivo = "Provincias.csv";
            if (File.Exists(x.NombreArchivo)) x.Recorrer(dgvGrilla);
            txtCod.Select();
            
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtCod.Text) && !string.IsNullOrWhiteSpace(txtNomProv.Text))
            {
                MessageBox.Show("No se cargaron datos", "Error");
            }
            else
            {
                string Dato = "";
                Dato = txtCod.Text + ";" + txtNomProv.Text;
                x.Grabar(Dato);
                x.Recorrer(dgvGrilla);
                MessageBox.Show("Dato cargado correctamente", "Proceso exitoso");
                txtNomProv.Text = "";
                txtCod.Text = "";
            }
            

        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es número ni tecla de control, se cancela
                e.Handled = true;
            }
        }
    }
}
