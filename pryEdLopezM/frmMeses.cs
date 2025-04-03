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
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
        }

        clsArchivo x = new clsArchivo();

        private void frmMeses_Load(object sender, EventArgs e)
        {
            x.NombreArchivo = "Meses.csv";

            if (File.Exists(x.NombreArchivo)) x.Recorrer(dgvMes);

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtMes.Text == " " || numMes.Value > 12 || numMes.Value < 1)
            {

                MessageBox.Show("Datos erroneos", "Error de carga");

            }
            else
            {
                string Dato = numMes.Value.ToString() + ";" + txtMes.Text;
                x.Grabar(Dato);

                x.Recorrer(dgvMes);

                MessageBox.Show("Datos cargados exitosamente","Proceso finalizado");

                txtMes.Text = "";

                numMes.Value = numMes.Value + 1;


            }

            



        }
    }
}
