using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios.clases
{
    class Cola
    {
        private Nodo primero = null;
        private Nodo ultimo = null;
        private int cant = 0;

        public void Enqueue(string nom)//encolar
        {
            Nodo nuevo = new Nodo();
            nuevo.Nombre = nom;

            if (buscar(nom) == null)
            {
                if (primero == null) //cuando esta vacio
                {
                    primero = nuevo;
                    ultimo = nuevo;
                }
                else //cuando hay nodos
                {
                    ultimo.Siguiente = nuevo;
                    ultimo = nuevo;
                }
                cant++;
            }
            else MessageBox.Show($"{nom} ya se encuentra en la cola!");
        }

        public void mostrar(ListBox list)
        {
            Nodo actual = primero;

            while(actual != null)
            {
                list.Items.Add(actual.Nombre);
                actual = actual.Siguiente;
            }
        }

        public string Dequeue() //desencolar
        {
            if (primero == null) return null;

            string nom = primero.Nombre;
            primero = primero.Siguiente;
            cant--;
            return nom;
        }

        public string Peek() //vistazo retona primer valor
        {
            if (primero == null) return null;
            return primero.Nombre;
        }

        public int Count()
        {
            return cant;
        }

        public void Clear()
        {
            primero = null;
            ultimo = null;
        }

        public Nodo buscar(string nom)
        {
            Nodo actual = primero;

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
    }
}
