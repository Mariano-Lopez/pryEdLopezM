using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdLopezM
{
    public partial class frmCiudades : Form
    {
        public frmCiudades()
        {
            InitializeComponent();
        }

        clsArchivo x = new clsArchivo();

        private void frmCiudades_Load(object sender, EventArgs e)
        {
            x.NombreArchivo = "Ciudades.txt";
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            if (txtNomCiu.Text == "")
            {
                MessageBox.Show("No se encontraron datos", "Error");
            }
            else
            {
                x.Grabar(txtNomCiu.Text);
                x.Recorrer(lstCiudades);
                MessageBox.Show("Dato cargado correctamente", "Proceso exitoso");
                txtNomCiu.Text = "";
            }
           
        }
    }
}
