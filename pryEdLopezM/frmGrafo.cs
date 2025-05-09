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
    public partial class frmGrafo : Form
    {
        public frmGrafo()
        {
            InitializeComponent();
        }

        clsGrafo grafo = new clsGrafo();
        private void frmGrafo_Load(object sender, EventArgs e)
        {
            grafo.cargarCiudades(cmbDestino);
            grafo.cargarCiudades(cmbDestinoD);
            grafo.cargarCiudades(cmbOrigen);
            grafo.cargarCiudades(cmbOrigenD);
            grafo.cargarCiudades(cmbDesde);
            grafo.cargarCiudades(cmbHasta);
            grafo.mostrarTodo(dgvGrafo);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            int x = cmbOrigen.SelectedIndex;
            int y = cmbDestino.SelectedIndex;

            decimal p = Convert.ToDecimal(txtPrecio.Text);
            grafo.Agregar(x, y, p);
            grafo.mostrarTodo(dgvGrafo);
            MessageBox.Show("Proceso finalizado","Precio cargado.");
            txtPrecio.Text = "";
            cmbOrigen.SelectedIndex = -1;
            cmbDestino.SelectedIndex = -1;
        }
    }
}
