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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        clsPila f = new clsPila();
        private void frmPila_Load(object sender, EventArgs e)
        {
            if (File.Exists("Pila.csv"))
            {

                f.Agregar(); //Leo los datos del archivo

                f.Recorrer(); //Archivo de texto
                f.Recorrer(dgvDatos); //Muestro en grilla
                f.Recorrer(lstDatos); //Muestro en lista
                f.Recorrer(cmbPila);

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodN.Text != "" && txtNomN.Text != "" && txtTraN.Text != "")
            {
                clsNodo Nodo = new clsNodo();

                Nodo.Codigo = Convert.ToInt32(txtCodN.Text);
                Nodo.Nombre = txtNomN.Text;
                Nodo.Tramite = txtTraN.Text;

                f.Agregar(Nodo);

                f.Recorrer(); //Archivo de texto
                f.Recorrer(dgvDatos); //Muestro en grilla
                f.Recorrer(lstDatos); //Muestro en lista
                f.Recorrer(cmbPila);
            }
            else
            {
                MessageBox.Show("No se pueden dejar campos vacíos.","Error de carga");
            }

            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (f.Primero != null)
            {
                lblCodE.Text = f.Primero.Codigo.ToString();
                lblNomE.Text = f.Primero.Nombre;
                lblTraE.Text = f.Primero.Tramite;

                f.eliminar();

                f.Recorrer(); //Archivo de texto
                f.Recorrer(dgvDatos); //Muestro en grilla
                f.Recorrer(lstDatos); //Muestro en lista
                f.Recorrer(cmbPila);

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
