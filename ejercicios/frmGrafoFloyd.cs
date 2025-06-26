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
    public partial class frmGrafoFloyd: Form
    {
        clases.GrafoFloyd g;
        public frmGrafoFloyd()
        {
            InitializeComponent();
        }

        private void btnVertices_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textVertices.Text);
            g = new clases.GrafoFloyd(num);

            MessageBox.Show("Número de vertices: "+num);
            listBox1.Items.Clear();
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        private void btnInsertarRaiz_Click(object sender, EventArgs e)
        {
            int o = int.Parse(textOrigen.Text);
            int d = int.Parse(textDestino.Text);
            int c = int.Parse(textCosto.Text);

            g.insertarArista(o,d,c);
            g.imprimirArista(o, d, c, listBox1);
        }

        private void btnMatrizCosto_Click(object sender, EventArgs e)
        {
            if (g != null)
            {
                richTextBox1.Clear();
                g.imprimirMatriz(richTextBox1);
            }
            else
                MessageBox.Show("Defina el número de vertices!");
        }

        private void btnFloyd_Click(object sender, EventArgs e)
        {
            if (g != null)
            {
                richTextBox2.Clear();
                g.floydWarshall(richTextBox2);
            }
            else
                MessageBox.Show("Defina el número de vertices!");
        }
    }
}
