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
    public partial class FrmGrafoDijsktra: Form
    {
        clases.GrafoDijsktra g;
        public FrmGrafoDijsktra()
        {
            InitializeComponent();
        }

        private void btnVertices_Click(object sender, EventArgs e)
        {
            int numvertices = int.Parse(textVertices.Text);
            g = new clases.GrafoDijsktra(numvertices);
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            richTextBox1.Clear();
        }

        private void btnInsertarRaiz_Click(object sender, EventArgs e)
        {
            int o = int.Parse(textOrigen.Text);
            int d = int.Parse(textDestino.Text);
            int c = int.Parse(textCosto.Text);
            g.insertar(o, d, c);
            g.imprimirArista(o, d, c, listBox1);
            textOrigen.Clear();
            textDestino.Clear();
            textCosto.Clear();
        }

        private void btnMatrizCosto_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            g.imprimirMatriz(richTextBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            g.dijsktra(listBox2);
        }
    }
}
