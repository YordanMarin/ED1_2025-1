using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios.clases
{
    class GrafoPrim
    {
        private int[,] matrizCosto;
        private int numVertices;

        public GrafoPrim(int numVertices)
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
            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                    rich.Text += matrizCosto[i, j] + "\t";
                }
                rich.Text += "\n";
            }
        }

        public void Prim(ListBox list)
        {
            List<int[]> arbolExpasionMinima = new List<int[]>();
            HashSet<int> verticesVisitados = new HashSet<int>();

            int verticeInicial = 0;
            int costoTotal = 0;

            verticesVisitados.Add(verticeInicial);

            while (verticesVisitados.Count < numVertices)
            {
                int[] aristaMinima = null;
                int costoMinimo = int.MaxValue;

                foreach(int verticeArbol in verticesVisitados)
                {
                    for(int i=0; i < numVertices; i++)
                    {
                        if(!verticesVisitados.Contains(i) & matrizCosto[verticeArbol, i] != 0)
                        {
                            int costoArista = matrizCosto[verticeArbol, i];
                            if(costoArista < costoMinimo)
                            {
                                aristaMinima = new int[] { verticeArbol, i };
                                costoMinimo = costoArista;
                            }
                        }
                    }
                }
                arbolExpasionMinima.Add(aristaMinima);
                verticesVisitados.Add(aristaMinima[1]);
                costoTotal += costoMinimo;
                list.Items.Add($"Arista: {aristaMinima[0]}, {aristaMinima[1]} : {costoMinimo}");
            }
            list.Items.Add($"Costo total: "+costoTotal);
        }
    }
}
