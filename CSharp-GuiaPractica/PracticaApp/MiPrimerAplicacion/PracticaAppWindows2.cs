using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    public partial class PracticaAppWindows2 : Form
    {
        public PracticaAppWindows2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string nombre = txtApellido.Text;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string apellido = txtApellido.Text;
            MessageBox.Show("EL APELLIDO INGRESADO ES: " + apellido);

            string nombre = txtNombre.Text;
            MessageBox.Show("EL NOMBRE INGRESADO ES: " + nombre);
            string edad = txtEdad.Text;
            MessageBox.Show("LA EDAD INGRESADA ES: " + edad);
            string direccion = txtDireccion.Text;
            MessageBox.Show("LA DIRECCION INGRESADA ES: " + direccion);
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void richTxtResultado_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void PracticaAppWindows2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

            // BOTON PARA CERRAR PROGRAMA
        private void btnCancelar1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    
}
