using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Ingrese un numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Otro: ");
            b = int.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine("El resultado es: " + c);
            Console.ReadKey();
        }
    }
}
