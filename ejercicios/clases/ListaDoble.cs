using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios.clases
{
    internal class ListaDoble
    {
        private NodoDoble primero;
        private NodoDoble ultimo;

        public void insertar(int num)
        {
            NodoDoble nuevo = new NodoDoble();
            nuevo.Numero = num;

            if(primero == null)
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

        public void mostrar(ListBox list)
        {
            NodoDoble actual = primero;

            while(actual != null)
            {
                list.Items.Add(actual.Numero);
                actual = actual.Siguiente;
            }
        }

        public void eliminar(int num)
        {
            NodoDoble actual = primero;

            while(actual != null)
            {
                if(actual.Numero == num)
                {
                    if(actual == primero)
                    {
                        primero = primero.Siguiente;
                        if(primero != null)
                        {
                            primero.Atras = null;
                        }
                    }
                    else if(actual == ultimo)
                    {
                        ultimo = ultimo.Atras;
                        if(ultimo != null)
                        {
                            ultimo.Siguiente = null;
                        }
                    }
                    else
                    {
                        actual.Atras.Siguiente = actual.Siguiente;
                        actual.Siguiente.Atras = actual.Atras;
                    }
                    return;
                }
                actual = actual.Siguiente;
            }
        }
    }
}
