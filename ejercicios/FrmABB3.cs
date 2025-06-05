using ejercicios.clases;
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
    public partial class FrmABB3: Form
    {
        ArbolBinarioBusqueda3 ab = new ArbolBinarioBusqueda3();
        NodoAB raiz;
        public FrmABB3()
        {
            InitializeComponent();
        }

        private void btnInsertarRaiz_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textNumero.Text, out int num))
            {
                if (raiz == null) raiz = ab.insertar(null, num);
                else ab.insertar(raiz, num);

                treeView1.Nodes.Clear();
                ab.mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
                textNumero.Clear();
            }
            else MessageBox.Show("Solo permiten números enteros");
        }

        private void btnMinimo_Click(object sender, EventArgs e)
        {
            if (raiz != null)
                MessageBox.Show("Mínimo: " + ab.minimo(raiz));
            else
                MessageBox.Show("Árbol vacío!");
        }

        private void btnMaximo_Click(object sender, EventArgs e)
        {
            if (raiz != null)
                MessageBox.Show("Máximo: " + ab.maximo(raiz));
            else
                MessageBox.Show("Árbol vacío!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(raiz!= null)
            {
                if (ab.balanceo(raiz) != -1)
                    MessageBox.Show("El árbol esta balanceado");
                else
                    MessageBox.Show("El árbol no esta balanceado");
            }
            else
                MessageBox.Show("Árbol vacío!");

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            textSuma.Clear();

            int suma = ab.sumaHojas(raiz);

            if (raiz != null)
                textSuma.Text = suma.ToString();
            else
                MessageBox.Show("Árbol vacío!");
        }
    }
}
