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
    public partial class FrmArbolbinarioBusqueda: Form
    {
        ArbolBinarioBusqueda ab = new ArbolBinarioBusqueda();
        NodoAB raiz;
        public FrmArbolbinarioBusqueda()
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

        private void btnRecorrido_Click(object sender, EventArgs e)
        {
            textPre.Clear();
            textPost.Clear();
            textIn.Clear();

            ab.preorden(raiz, textPre);
            ab.inorden(raiz, textIn);
            ab.postorden(raiz, textPost);
        }
    }
}
