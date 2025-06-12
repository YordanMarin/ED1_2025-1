using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios.clases
{
    class GrafoMatrizAdyacencia
    {
        private int[,] matrizAdyacenica;
        private int numVertices;

        public GrafoMatrizAdyacencia(int numVertices)
        {
            this.numVertices = numVertices;
            matrizAdyacenica = new int[numVertices, numVertices];
        }

        public void insertar(int origen, int destino)
        {
            if (origen >= 0 && origen < numVertices && destino >= 0 && destino < numVertices)
            {
                matrizAdyacenica[origen, destino] = 1;
            }
            else
                MessageBox.Show("Error: el origen o destino esta fuera del rango");
        }

        public void imprimirArista(int origen, int destino, ListBox list)
        {
            if (origen >= 0 && origen < numVertices && destino >= 0 && destino < numVertices)
                list.Items.Add($"{origen} | {destino}");
        }

        public void imprimirMatriz(RichTextBox rich)
        {
            for(int i = 0; i < numVertices; i++)
            {
                for(int j=0; j<numVertices; j++)
                {
                    rich.Text += matrizAdyacenica[i, j]+"\t";
                }
                rich.Text += "\n";
            }
        }

        public void amplitud(TextBox text)
        {
            int nodoInicio = 0;
            bool[] visitado = new bool[numVertices];
            Queue<int> cola = new Queue<int>();

            visitado[nodoInicio] = true;
            cola.Enqueue(nodoInicio);

            while(cola.Count() != 0)
            {
                int nodoActual = cola.Dequeue();
                text.Text += nodoActual + " ";

                for(int i = 0; i<numVertices; i++)
                {
                    if (matrizAdyacenica[nodoActual, i] == 1 && !visitado[i])
                    {
                        visitado[i] = true;
                        cola.Enqueue(i);
                    }
                }
            }
        }

        public void profundidad(TextBox text)
        {
            int nodoInicio = 0;
            bool[] visitado = new bool[numVertices];
            Stack<int> pila = new Stack<int>();

            pila.Push(nodoInicio);

            while (pila.Count() != 0)
            {
                int nodoActual = pila.Pop();

                if (!visitado[nodoActual])
                {
                    visitado[nodoActual] = true;
                    text.Text += nodoActual + " ";

                    for (int i = numVertices-1; i >= 0; i--)
                    {
                        if (matrizAdyacenica[nodoActual, i] == 1 & !visitado[i])
                        {
                            pila.Push(i);
                        }
                    }
                } 
            }
        }
    }
}
