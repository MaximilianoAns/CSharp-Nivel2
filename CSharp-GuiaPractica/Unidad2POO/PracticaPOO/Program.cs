using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Camion c1 = new Camion();
            c1.Motor = "500hp";
            c1.CargaMax = 5000;

            Auto a1 = new Auto();
            a1.Motor = "200hp";

            Moto m1 = new Moto();
            m1.Motor = "2tiempos";
            m1.TipoCasco = "Tipo Enduro";

            Console.WriteLine("El Camion tiene un motor de: " + c1.Motor + " y una carga Max de: " + c1.CargaMax);
            Console.WriteLine("El Auto tiene un motor de : " + a1.Motor);
            Console.WriteLine("La Moto tiene un motor de : " + m1.Motor + " y un casco: " + m1.TipoCasco);
            Console.ReadKey();



        }
    }
}
