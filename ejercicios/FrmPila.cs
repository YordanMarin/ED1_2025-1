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
    public partial class FrmPila: Form
    {
        clases.Pila p = new clases.Pila();
        public FrmPila()
        {
            InitializeComponent();
        }

        private void btnApilar_Click(object sender, EventArgs e)
        {
            p.Push(textNombre.Text);
            listDatos.Items.Clear();
            p.mostrar(listDatos);
            textNombre.Clear();
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            string nom = p.Pop();

            if (nom != null)
            {
                MessageBox.Show($"{nom} Desapilado correctamente!");
                listDatos.Items.Clear();
                p.mostrar(listDatos);
            }
            else
                MessageBox.Show("Pila vacía!");
        }

        private void btnVistazo_Click(object sender, EventArgs e)
        {
            string nom = p.Peek();

            if (nom != null)
            {
                MessageBox.Show($"Cima: {nom}!");
            }
            else
                MessageBox.Show("Pila vacía!");
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cantidad: " + p.Count());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            p.Clear();
            listDatos.Items.Clear();
            MessageBox.Show("Pila limpia!");
        }
    }
}
