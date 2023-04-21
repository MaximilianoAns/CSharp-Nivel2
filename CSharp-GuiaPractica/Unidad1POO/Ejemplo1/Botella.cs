using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Botella
    {
        //CAPACIDAD MAXIMA 100
        //CANTIDAD ACTUAL INICIA EN CERO
        //METODO DE RECARGA: RECARGA AL 100 Y DEVUELVE EL COSTO DE RECARGAR . 50 CADA 100
        // private int capacidad;
        private string color;
        private string material;
        private int capacidad;
        private int capacidadActual;
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            capacidadActual = 0;

        }
        //      METODOS
       public int recargar()
       {
            // A PARTIR DEL IF ES LA LOGICA (PROCESO)
            if(capacidadActual > 0)
            {
                int dif = capacidad - capacidadActual;
                float monto = dif * 50 / 100;
                capacidadActual += dif;
            }
            capacidadActual = 100;
            return 50;

       }
        public int Capacidad
        {
            get { return capacidad; }
        }
        public int CapacidadActual
        {
            get { return capacidadActual; }
        }




        public string Material
        {
            get { return material; }
        }

        //  METODOS






       //     //SOBRECARGAR EL CONSTRUCTOR
       // public  Botella()
       // {

       // }        
        //  CREAMOS UNA PROPIEDAD

        // public int capacidad

    }
}
