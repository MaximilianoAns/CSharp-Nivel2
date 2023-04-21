using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class frmPerfil : Form
    {
        public frmPerfil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lista = txtNombre.Text;
            listListaColores.Items.Add(lista);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmVentanaDos_Load(object sender, EventArgs e)
        {
            cboColores.Items.Add("Verde");
            cboColores.Items.Add("Rojo");
            cboColores.Items.Add("Azul");
        }

        private void lblColor_Click(object sender, EventArgs e)
        {

        }

        private void numNumeroFav_Click(object sender, EventArgs e)
        {

        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            // COMBO BOX PARA AGREGAR NOMBRES Y/O NUMEROS
            string nombre = txtNombre.Text;
            // CALENDARIO
            DateTime fecha = dtpFechaNac.Value;
            // COMBO BOX - EL QUE ES PARA TILDAR UNA OPC
            //  USAMOS OPERADOR TERNARIO                        PRIMERO VERDADERO Y LUEGO FALSO
            string programa =chkProgramacion.Checked == true ? "Le gusta la programacion" : "NO le gusta la programacion";
            
            //RADIO BUTTON
            string categoria;
            if (rbTraining.Checked)
                categoria = "Trainning";
            else if (rbJunior.Checked)
                categoria = "Junior";
            else
                categoria = "Senior";

            // PARA COLOR FAV COMBO BOX
            string colorFav = cboColores.SelectedItem.ToString();

            // PARA NUMERIC UP DOW - CARGAR UN LISTADO DE NUMERO, DESPEGLANDO
            string numFav = numNumeric.Value.ToString();
            string mensaje = programa + " es: " + categoria + " Su color fav es: " + colorFav + ", " + "Su num favorito es: " + numFav;
            MessageBox.Show("Nombre: " + nombre + "Fecha de Nacimiento: " + fecha + ", " + mensaje);

        }
    }
}
