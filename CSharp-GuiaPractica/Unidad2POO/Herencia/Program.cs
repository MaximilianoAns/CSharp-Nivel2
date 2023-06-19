using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Senior s1 = new Senior();
            s1.Legajo = 1024;
            s1.Apellido = "Gonzalez";
            s1.Nombre = "Maria";
            


            Developer deve = new Developer();
            deve.Legajo = 1101;
            deve.Puesto = "Lider";
            deve.Apellido = "Lopez";
            deve.Nombre = "Roberto";

            Tester t1 = new Tester();
            t1.Legajo = 1046;
            t1.Apellido = "Gimenez";
            t1.Nombre = "Cecilia";
        



        }
    }
}
