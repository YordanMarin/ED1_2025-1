using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios.clases
{
    internal class ListaDobleAnalisis
    {
        private NodoDoble primero = null;
        private NodoDoble ultimo = null;

        public void insertar(string nom, byte ed)
        {
            NodoDoble nuevo = new NodoDoble();
            nuevo.Nombre = nom;
            nuevo.Edad = ed;

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Atras = ultimo;
                ultimo = nuevo;
            }
        }

        public void mostrar(ListView list)
        {
            NodoDoble actual = primero;

            while(actual != null)
            {
                ListViewItem item = new ListViewItem(actual.Nombre);
                item.SubItems.Add(actual.Edad.ToString());
                //si tienes mas, va agregando subitems
                list.Items.Add(item);
                actual = actual.Siguiente;
            }
        }

        public NodoDoble buscar(string nom)
        {
            NodoDoble actual = primero;

            while(actual != null)
            {
                if(actual.Nombre == nom)
                {
                    return actual;
                }
                actual = actual.Siguiente;
            }
            return null;
        }

        public void modificar(string nomActual, string nomNuevo, byte edNuevo)
        {
            NodoDoble modi = buscar(nomActual);

            if(modi != null)
            {
                modi.Nombre = nomNuevo;
                modi.Edad = edNuevo;
            }
        }

        public void eliminar(string nom)
        {
            NodoDoble eli = buscar(nom);

            if (eli != null)
            {
                if (eli == primero)
                {
                    primero = primero.Siguiente;
                    if (primero != null)
                    {
                        primero.Atras = null;
                    }
                }
                else if (eli == ultimo)
                {
                    ultimo = ultimo.Atras;
                    if (ultimo != null)
                    {
                        ultimo.Siguiente = null;
                    }
                }
                else
                {
                    eli.Atras.Siguiente = eli.Siguiente;
                    eli.Siguiente.Atras = eli.Atras;
                }
            }
        }
    }
}
