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
            if (ab.Raiz != null)
            {
                ab.Equilibrar();
                ab.Recorrer(dgvArbolBinario);
                ab.Recorrer(tvArbol);
            }
            
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(cmbEListaDoble.SelectedIndex != -1)
            {
                ab.Eliminar(Convert.ToInt32(cmbEListaDoble.SelectedItem.ToString()));

                cmbEListaDoble.SelectedIndex = -1;

                if (ab.Raiz != null)
                {
                    ab.Recorrer(tvArbol);
                    ab.Recorrer(cmbEListaDoble);
                    ab.Recorrer(dgvArbolBinario);
                }
                else
                {
                    tvArbol.Nodes.Clear(); cmbEListaDoble.Items.Clear(); dgvArbolBinario.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una opción","Error");
            }
            
            
            
        }

        private void optInOrder_CheckedChanged(object sender, EventArgs e)
        {
            ab.Recorrer(dgvArbolBinario);
        }

        private void optPreOrder_CheckedChanged(object sender, EventArgs e)
        {
            ab.RecorrerPre(dgvArbolBinario);
        }

        private void optPostOrder_CheckedChanged(object sender, EventArgs e)
        {
            ab.RecorrerPost(dgvArbolBinario);
        }
    }
}
