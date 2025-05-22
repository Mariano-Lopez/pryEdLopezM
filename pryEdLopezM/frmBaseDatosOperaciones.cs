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
    public partial class frmBaseDatosOperaciones : Form
    {
        public frmBaseDatosOperaciones()
        {
            InitializeComponent();
        }

        clsBaseDeDatos BBDD = new clsBaseDeDatos();
        private void btnProS_Click(object sender, EventArgs e)
        {
            //Tomo una sola columna de una sola tabla.
            string SQL = "SELECT IdAutor FROM Libro";

            BBDD.Listar(dgvBBDD, SQL);
        }

        private void btnProMulti_Click(object sender, EventArgs e)
        {
            //Tomo 2 o mas columnas de una tabla
            string SQL = "SELECT IdAutor, Cantidad FROM Libro";

            BBDD.Listar(dgvBBDD, SQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT LIBRO.Titulo, AUTOR.Nombre FROM LIBRO INNER JOIN AUTOR ON LIBRO.IDAutor = AUTOR.IDAutor";
            BBDD.Listar(dgvBBDD, SQL);
        }

        private void btnSelecS_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT* FROM LIBRO WHERE Precio < 200";
            BBDD.Listar(dgvBBDD, SQL);
        }

        private void btnSelecM_Click(object sender, EventArgs e)
        {
            
            string SQL = "SELECT* FROM LIBRO WHERE Precio > 700 AND IdIdioma > 10";
            BBDD.Listar(dgvBBDD, SQL);
        }

        private void btnOpSConvo_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT * FROM LIBRO INNER JOIN IDIOMA ON LIBRO.IdIdioma = IDIOMA.IdIdioma WHERE IDIOMA.Nombre = 'Español'";
            BBDD.Listar(dgvBBDD, SQL);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            string SQL = "SELECT * FROM Autor UNION SELECT * FROM Idioma";
            BBDD.Listar(dgvBBDD, SQL);

        }

        private void btnInter_Click(object sender, EventArgs e)
        {
            string SQL = @"SELECT IdLibro, Titulo FROM Libro WHERE IdAutor > 10
                         INTERSEC
                         SELECT IdLibro, Titulo FROM Libro WHERE IdIdioma > 5";
            ;
            BBDD.Listar(dgvBBDD, SQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {

        }
    }
}
