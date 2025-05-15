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
    public partial class frmConsultaTabla : Form
    {
        public frmConsultaTabla()
        {
            InitializeComponent();
        }

        clsBaseDeDatos BBDD = new clsBaseDeDatos();

        private void frmConsultaBBDD_Load(object sender, EventArgs e)
        {
            cmbTablaLista.SelectedIndex = 0;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            BBDD.Listar(cmbTablaLista.Text, dgvBBDD);
        }

        private void cmbTablaLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnListar.PerformClick(); //Simula un click al botón.
        }
    }
}
