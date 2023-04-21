using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaExcepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {       // PRIMER METODO PARA HACER UN PROGRAMA Y PONERLE EXCEPCIONES.
                // METODOS QUE SE UTILIZA PARA NOTIFICAR UN ERROR EN EL PROGRAMA
                //int a, b, r;
                //try
                //{
                //    a = int.Parse(txt1.Text);
                //    b = int.Parse(txt2.Text);
                //    r = a / b;
                //    MessageBox.Show("El resultado es: " + r);
                //    lblResultado.Text = "=" + r;
                //
                //
                //}
                //catch (FormatException ex)
                //{
                //    MessageBox.Show("ERROR, INGRESE SOLAMENTE NUMEROS");
                //
                //    //throw;
                //}
                //    // PUEDO PONER LOS CATCH QUE SEAN NECESARIOS
                //    //EL CATCH SIRVE PARA INFORMAR SOBRE UN ERROR AL USUARIO
                //catch (DivideByZeroException ex)
                //{
                //    MessageBox.Show("NO SE PUEDE DIVIR POR CERO");
                //}+

            //       ESTE METODO HACE QUE DEVUELVA LA FUNCION CREADA APARTE EN PRIVATE
            //      O QUE DEVUELVA EL ERROR ATRA VES DE UNA MENSAJE
            int resultado;
            try
            {
                resultado = calcular();
                lblResultado.Text = "=" + resultado;
            }
            catch (Exception)
            {
                MessageBox.Show("error , contacte a su develope");
                
            }
            

        }
        private int calcular()
        {
            int a, b, r;
            try
            {
                a = int.Parse(txt1.Text);
                b = int.Parse(txt2.Text);
                r = a / b;
                return r;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
        










    }
               

                    
                
}
          






