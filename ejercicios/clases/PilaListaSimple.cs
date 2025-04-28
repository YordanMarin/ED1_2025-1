using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios.clases
{
    internal class PilaListaSimple
    {
        Pila p = new Pila();

        public int obtenerPrioridad(string operador)
        {
            if (operador == "*" | operador == "/")
                return 2;
            if(operador == "+" | operador == "-")
                return 1;
            return 0;
        }

        public bool EsOperador(string c)
        {
            return c== "+" || c == "-" || c == "*" || c == "/";
        }

        public string infijaAprefija(string infija)
        {
            StringBuilder prefija = new StringBuilder();

            for (int i = infija.Length - 1; i >= 0; i--)
            {
                string c = infija[i].ToString();

                if (char.IsLetterOrDigit(infija[i]))
                {
                    prefija.Insert(0, c);
                }
                else if (c == ")")
                {
                    p.Push(c);
                }
                else if (c == "(")
                {
                    while (!p.EstaVacio() && p.Peek() != ")")
                    {
                        prefija.Insert(0, p.Pop());
                    }
                    p.Pop();
                }
                else if (EsOperador(c))
                {
                    while (!p.EstaVacio() && obtenerPrioridad(c) < obtenerPrioridad(p.Peek()))
                    {
                        prefija.Insert(0, p.Pop());
                    }
                    p.Push(c);
                }
            }
            while(!p.EstaVacio())
            {
                prefija.Insert(0, p.Pop());
            }
            return prefija.ToString();
        }

        public string infijaApostfija(string infija)
        {
            StringBuilder postfija = new StringBuilder();

            for (int i = 0; i < infija.Length; i++)
            {
                string c = infija[i].ToString();

                if (char.IsLetterOrDigit(infija[i]))
                {
                    postfija.Append(c);
                }
                else if (c == "(")
                {
                    p.Push(c);
                }
                else if (c == ")")
                {
                    while (!p.EstaVacio() && p.Peek() != "(")
                    {
                        postfija.Append(p.Pop());
                    }
                    p.Pop();
                }
                else if (EsOperador(c))
                {
                    while (!p.EstaVacio() && obtenerPrioridad(c) < obtenerPrioridad(p.Peek()))
                    {
                        postfija.Append(p.Pop());
                    }
                    p.Push(c);
                }
            }
            while (!p.EstaVacio())
            {
                postfija.Append(p.Pop());
            }
            return postfija.ToString();
        }

        private Nodo primero = null;
        private Nodo ultimo = null;

        public void insertar(string infija, string prefija, string postfija)
        {
            Nodo nuevo = new Nodo();
            nuevo.Infija = infija;
            nuevo.Prefija = prefija;
            nuevo.Postfija = postfija;
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
            }
        }

        public void mostrar(ListView list)
        {
            Nodo actual = primero;
            while (actual != null)
            {
                ListViewItem item = new ListViewItem(actual.Infija);
                item.SubItems.Add(actual.Prefija);
                item.SubItems.Add(actual.Postfija);
                list.Items.Add(item);
                actual = actual.Siguiente;
            }
        }
    }
}
