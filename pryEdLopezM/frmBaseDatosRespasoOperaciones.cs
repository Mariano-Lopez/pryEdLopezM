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
    public partial class frmBaseDatosRespasoOperaciones : Form
    {
        public frmBaseDatosRespasoOperaciones()
        {
            InitializeComponent();
        }

        clsBaseDeDatos conexion = new clsBaseDeDatos();
        string querySQL;

        private void frmBaseDatosRespasoOperaciones_Load(object sender, EventArgs e)
        {
            string[] operaciones = new string[] {"Proyección simple", "Proyección Multiatributo", "Juntar",
                                                "Selección simple", "Selección multiatributo", "Selección por convolución",
                                                "Unión", "Intersección", "Diferencia"};

            foreach (string operacion in operaciones)
            {
                cmbOperaciones.Items.Add(operacion);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            querySQL = "SELECT * FROM LIBRO";

            switch (cmbOperaciones.SelectedIndex)
            {
                case 0: //Proyección Simple
                    lblCuadro.Text = $"{cmbOperaciones.Text}: Mostrar el titulo de libros.";
                    querySQL = "SELECT Titulo FROM Libro";
                    break;
                case 1: //Proyección Multiatributo
                    lblCuadro.Text = $"{cmbOperaciones.Text}: Mostrar el Titulo y Año de libros.";
                    querySQL = "SELECT Titulo, Año FROM Libro";
                    break;
                case 2: //Juntar
                    lblCuadro.Text = $"{cmbOperaciones.Text}: Mostrar libros y el Nombre de su respectivo Idioma.";
                    querySQL = "SELECT * FROM Libro, Idioma WHERE Libro.IdIdioma = Idioma.IdIdioma";
                    break;

                case 3: //Selección Simple
                    lblCuadro.Text = $"{cmbOperaciones.Text}: Mostrar todos los libros con una Cantidad menor a 5.";
                    querySQL = "SELECT * FROM Libro WHERE Cantidad < 5";
                    break;
                case 4: //Selección Multiatributo
                    lblCuadro.Text = $"{cmbOperaciones.Text}: Mostrar todos los libros con una Cantidad menor a 5 y con un Precio igual o por encima de 500.";
                    querySQL = "SELECT * FROM Libro WHERE Cantidad < 5 AND Precio >= 500";
                    break;
                case 5: //Selección por Convolución
                    lblCuadro.Text = $"{cmbOperaciones.Text}: Mostrar todos los libros que NO provengan del Pais Reino Unido y que además no tengan Idioma Inglés.";
                    querySQL = "SELECT * FROM (SELECT * FROM Libro as T1 WHERE NOT T1.IdPais = 1) " +
                       "as T2 WHERE NOT T2.IdIdioma = 1";
                    break;

                case 6: //Unión
                    lblCuadro.Text = $"{cmbOperaciones.Text}: Mostrar los libros que provengan de los Paises España, Argentina y México";
                    querySQL = "SELECT * FROM Libro WHERE IdPais = 13 " +
                        "UNION SELECT * FROM Libro WHERE IdPais = 24 " +
                        "UNION SELECT * FROM Libro WHERE IdPais = 35";
                    break;
                case 7: //Intersección
                    lblCuadro.Text = $"{cmbOperaciones.Text}: Libros que estan en idioma Español y que se publicaron en España";
                    querySQL = "SELECT * FROM Libro WHERE IdIdioma = 6 " +
                        "AND IdLibro IN " +
                        "(SELECT IdLibro FROM Libro WHERE IdPais = 13)";
                    break;
                case 8: //Diferencia
                    lblCuadro.Text = $"{cmbOperaciones.Text}: Libros de autores que no son argentinos";
                    querySQL = "SELECT * FROM Libro WHERE IdAutor " +
                        "NOT IN " +
                        "(SELECT IdAutor FROM Libro WHERE IdPais = 24)";
                    break;
            }

            conexion.Listar(dgvBBDD, querySQL);
        }
    }
}
