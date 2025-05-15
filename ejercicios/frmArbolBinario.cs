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
    public partial class frmArbolBinario: Form
    {
        clases.ArbolBinario ab = new clases.ArbolBinario();
        NodoAB raiz;
        NodoAB seleccionado;
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        private void btnInsertarRaiz_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textNumero.Text, out int num))
            {
                raiz = ab.insertar(null, num);
                treeView1.Nodes.Clear();
                ab.mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
                textNumero.Clear();
            }
            else MessageBox.Show("Insertar un número válido!");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            seleccionado = (NodoAB)e.Node.Tag;
        }

        private void btnInsertarRamas_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textNumero.Text, out int num))
            {
                if(seleccionado != null)
                {
                    if(radioIzquierda.Checked ==true || radioDerecha.Checked == true)
                    {
                        if(radioIzquierda.Checked == true)
                            seleccionado.izquierda = ab.insertar(seleccionado.izquierda, num);
                        if (radioDerecha.Checked == true)
                            seleccionado.derecho = ab.insertar(seleccionado.derecho, num);
                        
                        treeView1.Nodes.Clear();
                        ab.mostrar(raiz, treeView1, null);
                        treeView1.ExpandAll();
                        textNumero.Clear();
                    }else MessageBox.Show("Seleccione izquierda o derecha!");

                }
                else MessageBox.Show("Seleccione un número!");
                
            }
            else MessageBox.Show("Insertar un número válido!");
        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            int altura = ab.altura(raiz);

            MessageBox.Show("Altura: " + altura);
        }
    }
}
