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
    public partial class frmMostrarDatosBBDD : Form
    {
        public frmMostrarDatosBBDD()
        {
            InitializeComponent();
        }

        clsBaseDeDatos BBDD = new clsBaseDeDatos();

        private void frmMostrarDatosBBDD_Load(object sender, EventArgs e)
        {

            string[] Vectorcmb = new string[4] {"Autor", "Idioma", "Pais", "Libro"};

            foreach (string s in Vectorcmb)
            {
                cmbTablas.Items.Add(s);
            }

            cmbTablas.SelectedIndex = 0;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            BBDD.Listar(cmbTablas.Text, dgvBBDD);
        }
    }
}
