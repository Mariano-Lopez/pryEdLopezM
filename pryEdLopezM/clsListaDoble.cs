using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdLopezM
{
    internal class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult;
        
        


        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }

        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo < Primero.Codigo)
                {
                    
                    Nuevo.Siguiente = Primero;
                    Primero.Anterior = Nuevo;
                    Primero = Nuevo;

                }
                else
                {
                    if (Nuevo.Codigo > Ultimo.Codigo)
                    {

                        Ultimo.Siguiente = Nuevo;
                        Nuevo.Anterior = Ultimo;
                        Ultimo = Nuevo;


                    }
                    else 
                    {

                        clsNodo ant = pri;
                        clsNodo aux = pri;

                        while (aux.Codigo < ant.Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }

                        ant.Siguiente = Nuevo;
                        Nuevo.Siguiente = aux;
                        Nuevo.Anterior = ant;
                        aux.Anterior = Nuevo;
                    }
                }
            }
        }

        public void eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;

            }
            else
            {
                if (Primero.Codigo  == Codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;

                }
                else
                {
                    if (Primero.Codigo == Codigo)
                    {
                        Primero = Primero.Siguiente;
                        Primero.Anterior = null;

                    }
                    else
                    {
                        if (Ultimo.Codigo == Codigo)
                        {
                            Ultimo = Ultimo.Anterior;
                            Ultimo.Siguiente = null;
                        }
                        else
                        {
                            clsNodo aux = Primero;
                            clsNodo ant = Primero;
                            while (aux.Codigo != Codigo)
                            {
                                ant = aux;
                                aux = aux.Siguiente;

                            }
                            aux = aux.Siguiente;
                            ant.Siguiente = aux;
                            aux.Anterior = ant;



                        }
                    }
                }
            }

        }

        //Ascendente
        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer()
        {
            clsNodo aux = Primero;

            StreamWriter AD = new StreamWriter("ListaDoble.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();
        }

        public void Agregar()
        {
            StreamReader AD = new StreamReader("ListaDoble.csv");
            string dato = "";
            dato = AD.ReadLine(); //Titulo
            dato = AD.ReadLine(); //Renglon vacio
            dato = AD.ReadLine(); //Titulos de columna
            dato = AD.ReadLine(); //Primera fila con datos

            while (dato != null)
            {
                clsNodo Persona = new clsNodo();
                string[] datos = dato.Split(';');

                Persona.Codigo = Convert.ToInt32(datos[0]);
                Persona.Nombre = datos[1];
                Persona.Tramite = datos[2];

                agregar(Persona);
                dato = AD.ReadLine();
            }

            AD.Close();

        }

        //Descendente

        public void Recorrer1(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }
        }

        public void Recorrer1(ListBox Lista)
        {
            clsNodo aux = Ultimo;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }
        }

        public void Recorrer1(ComboBox Combo)
        {
            clsNodo aux = Ultimo;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }
        }

        public void Recorrer1()
        {
            clsNodo aux = Ultimo;

            StreamWriter AD = new StreamWriter("ListaDoble.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Anterior;
            }
            AD.Close();
        }

        //---------------------------------------------------------------------------------------
        public void Agregar1()
        {
            StreamReader AD = new StreamReader("ListaDoble.csv");
            string dato = "";
            dato = AD.ReadLine(); //Titulo
            dato = AD.ReadLine(); //Renglon vacio
            dato = AD.ReadLine(); //Titulos de columna
            dato = AD.ReadLine(); //Primera fila con datos

            while (dato != null)
            {
                clsNodo Persona = new clsNodo();
                string[] datos = dato.Split(';');

                Persona.Codigo = Convert.ToInt32(datos[0]);
                Persona.Nombre = datos[1];
                Persona.Tramite = datos[2];

                agregar(Persona);
                dato = AD.ReadLine();
            }

            AD.Close();

        }


    }
}
