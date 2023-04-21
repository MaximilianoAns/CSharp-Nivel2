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
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }
        // CONFIG CARTEL DE BIENVENIDA
        private void App_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a #C");
        }
        //  CONFIG PARA CARTEL AL CERRAR APP
        private void App_FormClosing(object sender, FormClosingEventArgs e)
        {
             MessageBox.Show("Chau chau ...");
        }

        //      CONFIG PARA EL CLICK DEL BOTON ASIGNADO
        private void btn1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("SE DISPARO EL CLICK!, ATENCION");
            //  this.BackColor = Color.Blue;

            if (ControlTxtBox.Text == "")
                ControlTxtBox.BackColor = Color.Red;
            else
                ControlTxtBox.BackColor = System.Drawing.SystemColors.Control;

        }
        //      CONFIGURACION PARA LOS BOTONES DEL MOUSE
        private void App_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("ATENCION!! PRESIONO EL BOTON CLICK IZQUIERDO!");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("ATENCION!! PRESIONO EL BOTON CLICK DERECHO");
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("ATENCION!! PRESIONO EL BOTON CLICK DEL MEDIO");

        }
        // CONFIG PARA CAMBIAR EL COLOR DEL LABEL
        private void lblLabel1_MouseMove(object sender, MouseEventArgs e)
        {
            lblLabel1.BackColor = Color.Cyan;
            lblLabel1.Cursor = Cursors.Hand;
           
        }
        // CON ESTAS DOS JUNTAS , CAMBIAN EL COLOR DE UNO AL OTRO
        private void lblLabel1_MouseLeave(object sender, EventArgs e)
        {
         // lblLabel1.BackColor = System.Drawing.SystemColors.Control;
         // lblLabel1.Cursor = Cursors.Arrow;
        }

        private void lblLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PRESIONASTE ACA");
        }

        
        // CONFIG PARA INGRESAR SOLAMENTE NUMEROS
        private void ControlTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 48 || e.KeyChar > 59 ) && e.KeyChar != 8)
                    e.Handled = true;
        }


        //      CAPTURAMOS Y MOSTRAMOS CUANTOS CARACTERES SE INGRESO
        private void ControlTxtBox2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + ControlTxtBox2.Text.Length + " Caracteres");
        }

        private void ControlTxtBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
