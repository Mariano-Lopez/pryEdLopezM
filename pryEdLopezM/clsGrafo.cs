using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdLopezM
{
    internal class clsGrafo
    {
        //CAMPOS
        
        //Vector
        String[] Ciudades = new String[5] { "Córdoba", "Buenos Aires", "Mendoza", "Santa fe", "Salta" };
        //Matriz
        Decimal[,] Precio = new Decimal[5,5];

        //Los 3 métodos utilizan ACCESOS DIRECTOS.
        public void Agregar(int f, int c, Decimal p)
        {
            Precio[f,c] = p;
        }

        public void Eliminar(int f, int c)
        {
            Precio[f, c] = 0;
        }

        public Decimal Consultar(int f, int c)
        {
            return Precio[f, c];
        }

        public void MostrarDestinos(Int32 f, DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            //Agregar columnas manualmente.
            dgv.Columns.Add("Col1", "Destino");
            dgv.Columns.Add("Col2", "Precio");
            dgv.Columns[0].Width = 200;
            dgv.Columns[1].Width = 200;
            dgv.Rows.Clear();
            for (int c = 0; c < Ciudades.Length; c++)
            {

                dgv.Rows.Add(Ciudades[c], Precio[f,c]);

            }

        }

        public void MostrarOrigenes(Int32 c, DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            //Agregar columnas manualmente.
            dgv.Columns.Add("Col1", "Origen");
            dgv.Columns.Add("Col2", "Precio");
            dgv.Columns[0].Width = 200;
            dgv.Columns[1].Width = 200;
            dgv.Rows.Clear();
            for (int f = 0; f < Ciudades.Length; f++)
            {
                if (Precio[f, c] > 0)
                {
                    dgv.Rows.Add(Ciudades[f], Precio[f, c]);
                }
                

            }

        }

        public void cargarCiudades(ComboBox cmb)
        {
            for(Int32 i = 0; i < 5; i++){

                cmb.Items.Add(Ciudades[i]);

            }
        }

        public void borrarTodo()
        {
            for(int f = 0; f < Ciudades.Length; f++)
            {
                for (int c = 0; c < Ciudades.Length; c++)
                {
                    Precio[f, c] = 0;
                }
            }
        }


        public void mostrarTodo(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.Columns.Add("NomOrigen","Origen");

            for (int i = 0; i < Ciudades.Length; i++)
            {
                dgv.Columns.Add("Destino" + i.ToString(),Ciudades[i]);

            }
            for (int f = 0; f < Ciudades.Length; f++)
            {
                dgv.Rows.Add(Ciudades[f]);
                for (int c = 0; c < Ciudades.Length; c++)
                {
                    dgv.Rows[f].Cells[c+1].Value = Precio[f, c];
                }
            }

        }





























    }
}
