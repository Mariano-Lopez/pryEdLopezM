using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdLopezM
{
    internal class clsArbolBinario
    {
        private clsNodo PrimerNodo;

        public clsNodo Raiz
        {

            get { return PrimerNodo; }
            set { PrimerNodo = value; }

        }

        public void Agregar(clsNodo Nvo)
        {
            Nvo.Izquierdo = null;
            Nvo.Derecho = null;

            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;

                    if (Nvo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;

                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }

                if (Nvo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nvo;
                }
                else
                {
                    NodoPadre.Derecho = Nvo;
                }
            }
        }

        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;

        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);

        }

        public void Eliminar(Int32 codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, codigo);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        public void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;

            if (ini <= fin)
            {

                Agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }

        private void GrabarVectorInOrden(clsNodo NodoPadre)
        {

            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo);

            }
            Vector[i] = NodoPadre;
            i = i + 1;
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);

            }

        }

        private void GrabarVectorInOrden(clsNodo NodoPadre, Int32 codigo)
        {

            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo, codigo);

            }
            Vector[i] = NodoPadre;
            i = i + 1;
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho, codigo);

            }

        }


        public void Recorrer(ComboBox cmb)
        {
            cmb.Items.Clear();
            InOrdenAsc(cmb, Raiz);

        }

        public void InOrdenAsc(ComboBox cmb, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(cmb, R.Izquierdo);

            cmb.Items.Add(R.Codigo);

            if (R.Derecho != null) InOrdenAsc(cmb, R.Derecho);


        }

        public void Recorrer(ListBox lst)
        {
            lst.Items.Clear();
            InOrdenAsc(lst, Raiz);

        }

        public void InOrdenAsc(ListBox lst, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(lst, R.Izquierdo);

            lst.Items.Add(R.Codigo);

            if (R.Derecho != null) InOrdenAsc(lst, R.Derecho);


        }

        public void Recorrer(DataGridView dgv)
        {
            dgv.Rows.Clear();
            InOrdenAsc(dgv, Raiz);

        }

        public void InOrdenAsc(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(dgv, R.Izquierdo);

            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

            if (R.Derecho != null) InOrdenAsc(dgv, R.Derecho);


        }

        public void InOrdenDesc(ListBox Lst, clsNodo R)
        {
            if (R.Derecho != null)
            {
                InOrdenDesc(Lst, R.Derecho);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                InOrdenDesc(Lst, R.Izquierdo);
            }
        }
        public void PreOrden(ListBox Lst, clsNodo R)
        {
            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                PreOrden(Lst, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PreOrden(Lst, R.Derecho);
            }
        }
        public void PostOrden(ListBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                PostOrden(Lst, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PostOrden(Lst, R.Derecho);
            }
            Lst.Items.Add(R.Codigo);
        }

        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Árbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();
        }


        private void PreOrden(clsNodo R, TreeNode NodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            NodoTreeView.Nodes.Add(NodoPadre);
            if (R.Izquierdo != null) PreOrden(R.Izquierdo, NodoPadre);
            if (R.Derecho != null) PreOrden(R.Derecho, NodoPadre);
        }

        public clsNodo BuscarCodigo(Int32 cod)
        {
            clsNodo aux = Raiz;
            while (aux != null)
            {
                if (cod == aux.Codigo) break;
                if(cod <= aux.Codigo) aux = aux.Izquierdo;
                else aux = aux.Derecho;

            }
            return aux;


        }





    }
}
