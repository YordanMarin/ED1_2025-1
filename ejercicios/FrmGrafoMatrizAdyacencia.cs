using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios
{
    public partial class FrmGrafoMatrizAdyacencia: Form
    {
        clases.GrafoMatrizAdyacencia g = new clases.GrafoMatrizAdyacencia(5);
        public FrmGrafoMatrizAdyacencia()
        {
            InitializeComponent();
        }

        private void btnInsertarRaiz_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textOrigen.Text, out int origen) && int.TryParse(textDestino.Text, out int destino)){
                g.insertar(origen, destino);
                g.imprimirArista(origen, destino, listBox1);
            }
            else
            {
                MessageBox.Show("Ingrese números enteros!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            g.imprimirMatriz(richTextBox1);
        }

        private void btnAmplitud_Click(object sender, EventArgs e)
        {
            textAmplitud.Clear();
            g.amplitud(textAmplitud);
        }

        private void btnProfundidad_Click(object sender, EventArgs e)
        {
            textProfundidad.Clear();
            g.profundidad(textProfundidad);
        }
    }
}
