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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        clsListaSimple ls = new clsListaSimple();

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

            if (File.Exists("ListaSimple.csv"))
            {

                ls.Agregar(); //Leo los datos del archivo
                ls.Recorrer(); //Archivo de texto
                ls.Recorrer(dgvDatos); //Muestro en grilla
                ls.Recorrer(lstDatos); //Muestro en lista
                ls.Recorrer(cmbEListaSimple);
                ValidarDatos();
            }            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
                clsNodo Nodo = new clsNodo();

                Nodo.Codigo = Convert.ToInt32(txtCodN.Text);
                Nodo.Nombre = txtNomN.Text;
                Nodo.Tramite = txtTraN.Text;

                ls.agregar(Nodo);

                ls.Recorrer(); //Archivo de texto
                ls.Recorrer(dgvDatos); //Muestro en grilla
                ls.Recorrer(lstDatos); //Muestro en lista
                ls.Recorrer(cmbEListaSimple);

                reseteoComp();
            
            
            

           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbEListaSimple.Text != "")
            {
                
                ls.Eliminar(Convert.ToInt32(cmbEListaSimple.Text));

                ls.Recorrer(); //Archivo de texto
                ls.Recorrer(dgvDatos); //Muestro en grilla
                ls.Recorrer(lstDatos); //Muestro en lista
                ls.Recorrer(cmbEListaSimple);
                cmbEListaSimple.Text = null;
                reseteoComp();
            }
            else
            {
                MessageBox.Show("Seleccione o carge un nuevo elemento", "Error");
            }
        }

        public void ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtCodN.Text) || string.IsNullOrWhiteSpace(txtNomN.Text) || string.IsNullOrWhiteSpace(txtTraN.Text) )
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
            
        }

        private void cmbEListaSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ls.Primero != null)
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

        public void reseteoComp()
        {
            txtCodN.Text = "";
            txtNomN.Text = "";
            txtTraN.Text = "";
        }
    }
}
