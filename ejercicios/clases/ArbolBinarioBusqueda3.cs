using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios.clases
{
    class ArbolBinarioBusqueda3
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

        public int minimo(NodoAB actual)
        {
            while(actual.izquierda != null)
            {
                actual = actual.izquierda;
            }
            return actual.numero;
        }

        public int maximo(NodoAB actual)
        {
            while (actual.derecho != null)
            {
                actual = actual.derecho;
            }
            return actual.numero;
        }

        public int balanceo(NodoAB actual)
        {
            if (actual == null) return 0;
            int alturaIzq = balanceo(actual.izquierda);
            if (alturaIzq == -1) return -1;

            int alturaDer = balanceo(actual.derecho);
            if (alturaDer == -1) return -1;

            if (Math.Abs(alturaIzq - alturaDer) > 1)
                return -1;

            return Math.Max(alturaIzq, alturaDer)+1;
        }

        public int sumaHojas(NodoAB actual)
        {
            if (actual == null) return 0;

            if (actual.izquierda == null & actual.derecho == null)
                return actual.numero;

            return sumaHojas(actual.izquierda) + sumaHojas(actual.derecho);
        }

    }
}
