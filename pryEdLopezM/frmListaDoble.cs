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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        clsListaDoble lstDoble = new clsListaDoble();
        private void frmListaDoble_Load(object sender, EventArgs e)
        {

            if (File.Exists("ListaDoble.csv"))
            {

                lstDoble.Agregar(); //Leo los datos del archivo

                optAsc.Checked = true;
                optAscSelecc();
                
                ValidarDatos();

            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Nodo = new clsNodo();

            Nodo.Codigo = Convert.ToInt32(txtCodN.Text);
            Nodo.Nombre = txtNomN.Text;
            Nodo.Tramite = txtTraN.Text;

            lstDoble.agregar(Nodo);

            optAscSelecc();
            optDescSelecc();

            txtCodN.Text = "";
            txtNomN.Text = "";
            txtTraN.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbEListaDoble.Text != "")
            {

                lstDoble.eliminar(Convert.ToInt32(cmbEListaDoble.Text));

                optAscSelecc();
                optDescSelecc();

                cmbEListaDoble.Text = null;
            }
            else
            {
                MessageBox.Show("Seleccione o carge un nuevo elemento", "Error");
            }
        }

        public void ValidarDatos()
        {
            if (txtCodN.Text == "" || txtNomN.Text == "" || txtTraN.Text == "")
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }

        }

        private void cmbEListaDoble_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDoble.Primero != null)
            {
                btnEliminar.Enabled = true;
            }
        }

        private void txtCodN_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtNomN_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtTraN_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void optAsc_CheckedChanged(object sender, EventArgs e)
        {
            optAscSelecc();
        }

        private void optDesc_CheckedChanged(object sender, EventArgs e)
        {
            optDescSelecc();
        }


        public void optAscSelecc()
        {
            if (optAsc.Checked)
            {
                lstDoble.Recorrer(); //Archivo de texto
                lstDoble.Recorrer(dgvDatos); //Muestro en grilla
                lstDoble.Recorrer(lstDatos); //Muestro en lista
                lstDoble.Recorrer(cmbEListaDoble);
            }
        }

        public void optDescSelecc()
        {
            if (optDesc.Checked)
            {
                lstDoble.Recorrer1(); //Archivo de texto
                lstDoble.Recorrer1(dgvDatos); //Muestro en grilla
                lstDoble.Recorrer1(lstDatos); //Muestro en lista
                lstDoble.Recorrer1(cmbEListaDoble);
            }
        }
    }
}
