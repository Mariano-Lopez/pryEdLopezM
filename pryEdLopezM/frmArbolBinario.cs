using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdLopezM
{
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario ab = new clsArbolBinario();

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo aux = new clsNodo();

            aux.Codigo = Convert.ToInt32(txtCodN.Text); 
            aux.Nombre = txtNomN.Text;
            aux.Tramite = txtTraN.Text;

            ab.Agregar(aux);

            txtCodN.Text = "";
            txtNomN.Text = "";
            txtTraN.Text = "";

            ab.Recorrer(cmbEListaDoble);
            ab.Recorrer(dgvArbolBinario);
            ab.Recorrer(tvArbol);
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            ab.Equilibrar();
            ab.Recorrer(dgvArbolBinario);
            ab.Recorrer(tvArbol);

        }

        
    }
}
