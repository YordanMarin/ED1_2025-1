using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios.clases
{
    class GrafoDijsktra
    {
        private int[,] matrizCosto;
        private int numVertices;

        public GrafoDijsktra(int numVertices)
        {
            this.numVertices = numVertices;
            matrizCosto = new int[numVertices, numVertices];
        }

        public void insertar(int o, int d, int c)
        {
            matrizCosto[o, d] = c;
            //matrizCosto[d, o] = c; //matriz no dirigido
        }

        public void imprimirArista(int o, int d, int c, ListBox list)
        {
            list.Items.Add($"({o}, {d}, {c})");
        }

        public void imprimirMatriz(RichTextBox rich)
        {
            for(int i =0; i<numVertices; i++)
            {
                for(int j =0; j<numVertices; j++)
                {
                    rich.Text += matrizCosto[i, j] + "\t";
                }
                rich.Text += "\n";
            }
        }

        public void dijsktra(ListBox list)
        {
            int origen = 0;
            int[] distancias = new int[numVertices];
            bool[] visitados = new bool[numVertices];

            for(int i = 0; i < numVertices; i++)
            {
                distancias[i] = int.MaxValue; //infinito
                visitados[i] = false;
            }

            distancias[origen] = 0;

            for(int i =0; i<numVertices; i++)
            {
                int u = minimaDistancia(distancias, visitados);
                visitados[u] = true;

                for(int v = 0; v < numVertices; v++)
                {
                    if (!visitados[v] && matrizCosto[u,v]!=0 && distancias[u] != int.MaxValue && distancias[u] + matrizCosto[u,v] < distancias[v])
                    {
                        distancias[v] = distancias[u] + matrizCosto[u, v];
                    }
                }
            }

            //imprimir las distancias
            list.Items.Add("Origen\tDestino\tDistancia");
            for(int i = 0; i<numVertices; i++)
            {
                if (distancias[i] == int.MaxValue)
                    list.Items.Add($"{origen}\t{i}\tNo hay ruta");
                else
                    list.Items.Add($"{origen}\t{i}\t{distancias[i]}");
            }
        }

        public int minimaDistancia(int[] distancias, bool[] visitados)
        {
            int min = int.MaxValue;
            int index = -1;

            for(int i=0; i < numVertices; i++)
            {
                if (!visitados[i] & distancias[i] <= min)
                {
                    min = distancias[i];
                    index = i;
                }
            }
            return index;
        }
    }
}
