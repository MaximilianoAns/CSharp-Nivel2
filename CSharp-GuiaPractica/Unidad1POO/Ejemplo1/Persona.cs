using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Persona
    {   
        private int edad;
        private float sueldo;
        private string nombre;
        

        //      METODO PARA SALUDAR Y/O PRESENTAR
        public Persona (string nombre)
        {
            this.nombre = nombre;
        }
        public string saludar()
        {
            return "Hola soy.." +  nombre;
        }

        public void setEdad(int f)    //PONGO INT E DE EDAD PARA NO PISAR LA VARIABLE de EDAD 
        {
            edad = f;                           //ACA DECLARO LA LETRA
        }

        public int getEdad()
        {
            return edad;                    // ACA DEVUELVE LA EDAD
        }








    }
}
