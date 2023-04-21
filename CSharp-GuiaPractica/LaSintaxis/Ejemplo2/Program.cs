using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //      Condicionales
            int a, b;
            Console.WriteLine("INGRESE UN NUMERO: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE UN OTRO: ");
            b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("LOS NUMEROS INGRESADOS SON IGUALES");
               
            }
            else{  
                Console.WriteLine("LOS NUMEROS INGRESADOS SON DIFERENTES");
               
            }
            
            Console.WriteLine("MOSTRAME DATOS LA CONCHA DE TU MADRE PUTAAA");
            Console.ReadKey();







        }
    }
}
