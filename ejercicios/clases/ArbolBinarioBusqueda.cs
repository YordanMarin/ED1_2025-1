using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios.clases
{
    class ArbolBinarioBusqueda
    {
        public NodoAB insertar(NodoAB actual, int num)
        {
            NodoAB nuevo = new NodoAB(num);

            if (actual == null) return nuevo;

            if (num < actual.numero)
                actual.izquierda = insertar(actual.izquierda, num);
            else if (num > actual.numero)
                actual.derecho = insertar(actual.derecho, num);
            else MessageBox.Show("No se permiten duplicados!");

            return actual;
        }

        public void mostrar(NodoAB actual, TreeView tree, TreeNode tallo)
        {
            if (actual == null) return;

            TreeNode cabeRaiz = new TreeNode(actual.numero.ToString());

            if (tallo == null) tree.Nodes.Add(cabeRaiz);
            else tallo.Nodes.Add(cabeRaiz);

            mostrar(actual.izquierda, tree, cabeRaiz);
            mostrar(actual.derecho, tree, cabeRaiz);
        }

        public void preorden(NodoAB actual, TextBox text)
        {
            if (actual == null) return;

            text.Text += actual.numero.ToString()+" ";
            preorden(actual.izquierda, text);
            preorden(actual.derecho, text);
        }

        public void inorden(NodoAB actual, TextBox text)
        {
            if (actual == null) return;

            inorden(actual.izquierda, text);
            text.Text += actual.numero.ToString() + " ";
            inorden(actual.derecho, text);
        }

        public void postorden(NodoAB actual, TextBox text)
        {
            if (actual == null) return;

            postorden(actual.izquierda, text);
            postorden(actual.derecho, text);
            text.Text += actual.numero.ToString() + " ";
        }

        public NodoAB buscar(NodoAB actual, int num)
        {
            if (actual == null) return null;

            if (num == actual.numero) return actual;
            else if(num < actual.numero)
                return buscar(actual.izquierda, num);
            else
                return buscar(actual.derecho, num);
        }

        public NodoAB eliminar(NodoAB actual, int num)
        {
            if (actual == null) return null;

            if (num < actual.numero)
                return eliminar(actual.izquierda, num);
            else if (num > actual.numero)
                return eliminar(actual.derecho, num);
            else
            {
                if (actual.izquierda == null) return actual.derecho;
                if (actual.derecho == null) return actual.izquierda;

                NodoAB sucesor = minimo(actual.derecho);

                actual.numero = sucesor.numero;
                actual.derecho = eliminar(actual.derecho, sucesor.numero);
            }
            return actual;
        }

        public NodoAB minimo(NodoAB actual)
        {
            while (actual.izquierda != null)
                actual = actual.izquierda;
            return actual;
        }
    }
}
