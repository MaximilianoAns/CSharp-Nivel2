using System;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void verPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
            //ESTE METODO ES PARA BLOQUEAR LA VENTANA QUE SE USA ACTUALMENTE
            // NOS PERMITE QUE NO SE PUEDA ABRIR OTRA VENTANA HASTA CERRAR LA QUE SE ESTA USANDO
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmPerfil))
                {
                    
                    MessageBox.Show("NO SE PUEDE ABRIR OTRA PESTANIA, PORFAVOR TERMINE O CIERRE LA ACTUAL");
                    return;

                }
            }

            frmPerfil ventana = new frmPerfil();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void operariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void produccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerfil opProd = new frmPerfil();
            opProd.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {       // MUESTRA EL CARTEL DEL PERFIL 
            frmPerfil perfil = new frmPerfil();
            perfil.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPrueba1_Click(object sender, EventArgs e)
            //       CAPTURO Y GUARDO LA FECHA SELECCIONADA EN VARIABLE
        {
            DateTime fecha1;
            fecha1 = dtpFecha.Value;
            MessageBox.Show("La fecha seleccionada es: " + fecha1.ToString("dd/MM/yyyy"));
        }

        private void btnPrueba2_Click(object sender, EventArgs e)
            //  ACA MUESTRO LA FECHA SELECCIONADA CON CALENDARIO
        {
            MessageBox.Show("La fecha es: " + calCalendario.SelectionStart.ToString());
        }
    }
}
