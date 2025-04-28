using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios.clases
{
    class Nodo
    {
        private int numero;
        private string nombre; //esto utilizamos para pila
        private string infija;      //Para pila y lista
        private string prefija;     //Para pila y lista
        private string postfija;    //Para pila y lista
        private Nodo siguiente;

        public int Numero { get => numero; set => numero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Infija { get => infija; set => infija = value; }
        public string Prefija { get => prefija; set => prefija = value; }
        public string Postfija { get => postfija; set => postfija = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
    }
}
