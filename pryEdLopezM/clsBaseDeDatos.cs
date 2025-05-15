using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdLopezM
{
    internal class clsBaseDeDatos
    {

        OleDbConnection conexion = new OleDbConnection();
        OleDbCommand comando = new OleDbCommand();
        OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private String CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\BBDD\\Libreria.mdb";
        //private String CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Escritorio\\clones\\pryEdLopezM\\BBDD\\Libreria.mdb";
        private String CadenaConexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";

        public void Listar(DataGridView dgv)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;

                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Autor";

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "Autor");
                dgv.DataSource = DS.Tables["Autor"];


                conexion.Close();
            }
            catch(Exception Error)
            {

                conexion.Close();
                MessageBox.Show(Error.Message,"Error");

            }

        }

        public void Listar(string tabla, DataGridView dgv)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;

                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, tabla);
                dgv.DataSource = DS.Tables[tabla];


                conexion.Close();
            }
            catch (Exception Error)
            {

                conexion.Close();
                MessageBox.Show(Error.Message, "Error");

            }

        }

    }
}
