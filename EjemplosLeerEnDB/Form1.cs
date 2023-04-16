using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplosLeerEnDB
{
    public partial class txt1 : Form
    {
        public txt1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {   // METODO TRY CON EXCEPCIONES 
            // METODOS FINALLY Y THROW
            int resultado;
            try
            {
                resultado = calcular();
                lbl1.Text = " " + resultado;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error inesperado.. contacte a su Developer");
            }
            finally
            {

            }

        }
        private int calcular()
        {
            int a, b, r;
            try
            {
                a = int.Parse(txtUno.Text);
                b = int.Parse(txtDos.Text);
                r = a * b;

                return r;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
