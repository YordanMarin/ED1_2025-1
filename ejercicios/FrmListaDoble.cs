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
    public partial class FrmListaDoble : Form
    {
        clases.ListaDoble ld = new clases.ListaDoble();
        public FrmListaDoble()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            listNumeros.Items.Clear();
            ld.insertar(int.Parse(textNumero.Text));
            ld.mostrar(listNumeros);
            textNumero.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ld.eliminar(int.Parse(textNumero.Text));
            listNumeros.Items.Clear();
            ld.mostrar(listNumeros);
            textNumero.Clear();
        }
    }
}
