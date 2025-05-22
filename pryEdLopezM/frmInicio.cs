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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            
        }

        private void datosDelProgramadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDelProgramador v = new frmDatosDelProgramador();
            v.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCiudades v = new frmCiudades();
            v.ShowDialog();
        }

        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProvincias v = new frmProvincias();
            v.ShowDialog();
        }

        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeses v = new frmMeses();
            v.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola v = new frmCola();
            v.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila v = new frmPila();
            v.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple v = new frmListaSimple();
            v.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble v = new frmListaDoble();
            v.ShowDialog();
        }

        private void árbolBinarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmArbolBinario v = new frmArbolBinario();
            v.ShowDialog();
        }

        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrafo v = new frmGrafo();
            v.ShowDialog();
        }

        private void mostrarUnaTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaTabla v = new frmConsultaTabla();
            v.ShowDialog();
        }

        private void consultaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatosConsultasSQL v  = new frmBaseDatosConsultasSQL();
            v.ShowDialog();
        }

        private void operacionesEnBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatosOperaciones v = new frmBaseDatosOperaciones();
            v.ShowDialog();
        }

        private void consultasVariasConOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatosRespasoOperaciones v = new frmBaseDatosRespasoOperaciones();
            v.ShowDialog();
        }
    }
}
