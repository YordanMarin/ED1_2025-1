using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios.clases
{
    class GrafoFloyd
    {
        private int[,] matrizCosto;
        private int numVertices;

        public GrafoFloyd(int numVertices)
        {
            this.numVertices = numVertices;
            matrizCosto = new int[numVertices, numVertices];
        }

        public void insertarArista(int o, int d, int c)
        {
            matrizCosto[o, d] = c;
            //matrizCosto[d, o] = c; // no dirigido
        }

        public void imprimirArista(int o, int d, int c, ListBox list)
        {
            list.Items.Add($"( {o}, {d}, {c} )");
        }

        public void imprimirMatriz(RichTextBox rich)
        {
            for(int i = 0; i < numVertices; i++)
            {
                for(int j=0; j < numVertices; j++)
                {
                    rich.Text += matrizCosto[i, j] + "\t";
                }
                rich.Text += "\n";
            }
        }

        public void floydWarshall(RichTextBox rich)
        {
            int[,] matrizFloyd = new int[numVertices, numVertices];

            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                    if (matrizCosto[i, j] != 0)
                        matrizFloyd[i, j] = matrizCosto[i, j];
                    else
                        matrizFloyd[i, j] = int.MaxValue;
                }
            }

            //implementando floyd
            for(int k=0; k < numVertices; k++)
            {
                for( int i=0; i<numVertices; i++)
                {
                    for(int j=0; j < numVertices; j++)
                    {
                        if (matrizFloyd[i, k] != int.MaxValue && matrizFloyd[k, j] != int.MaxValue)
                        {
                            int nuevoCosto = matrizFloyd[i, k] + matrizFloyd[k, j];

                            if(nuevoCosto < matrizFloyd[i, j])
                            {
                                matrizFloyd[i, j] = nuevoCosto;
                            }
                        }
                    }
                }
            }

            //imprimir l matriz flod
            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                    if (matrizFloyd[i, j] != int.MaxValue)
                        rich.Text += matrizCosto[i, j] + "\t";
                    else if (i == j)
                        rich.Text += 0 + "\t";
                    else
                        rich.Text += "∞" + "\t";
                }
                rich.Text += "\n";
            }
        }
    }
}
