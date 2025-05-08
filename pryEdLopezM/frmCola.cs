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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsCola f = new clsCola();

        private void frmCola_Load(object sender, EventArgs e)
        {
            if (File.Exists("Cola.csv"))
            {

                f.Agregar(); //Leo los datos del archivo
                f.Recorrer(); //Archivo de texto
                f.Recorrer(dgvCola); //Muestro en grilla
                f.Recorrer(lstCola); //Muestro en lista

            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            clsNodo Nodo = new clsNodo();

            Nodo.Codigo = Convert.ToInt32(txtCodN.Text);
            Nodo.Nombre = txtNomN.Text;
            Nodo.Tramite = txtTraN.Text;

            f.Agregar(Nodo);

            f.Recorrer(); //Archivo de texto
            f.Recorrer(dgvCola); //Muestro en grilla
            f.Recorrer(lstCola); //Muestro en lista
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (f.Primero != null)
            {
                lblCodE.Text = f.Primero.Codigo.ToString();
                lblNomE.Text = f.Primero.Nombre;
                lblTraE.Text = f.Primero.Tramite;

                f.Eliminar();

                f.Recorrer(); //Archivo de texto
                f.Recorrer(dgvCola); //Muestro en grilla
                f.Recorrer(lstCola); //Muestro en lista

            }
            else
            {
                lblCodE.Text = "";
                lblNomE.Text = "";
                lblTraE.Text = "";
            }
        }

    }
}
