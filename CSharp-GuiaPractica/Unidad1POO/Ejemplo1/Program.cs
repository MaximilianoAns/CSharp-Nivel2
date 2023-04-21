using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Botella b1 = new Botella("rojo", "plastico");
          //Botella b2 = new Botella()
            Persona p1 = new Persona("ROBERTO");
            Console.WriteLine(p1.saludar());
            p1.setEdad(25);     //SET PARA PONER EDAD
            Console.ReadKey();

            Console.WriteLine("LA EDAD DE LA PERSONA ES: " + p1.getEdad());     //GET PARA OBTENER
            Console.ReadKey();

            Console.WriteLine("LA CAP DE LA BOTELLA ES: " + b1.Capacidad);
            Console.WriteLine("LA CAP DE LA BOTELLA ACTUAL ES: " + b1.CapacidadActual);

            b1.recargar();
            Console.WriteLine("LUEGO DE RECARGAR, LA CANTIDAD ACTUAL ES: " + b1.CapacidadActual);
            Console.ReadKey();

            //Articulo a1 = new Articulo();
            //a1.CodigoArticulo = 5; // NUMERO 5 ES UN EJEMPLO PARA DARLE VALOR A ESE ARTICULO, DENTRO DE LOS PARAMETROS QUE PONGO

            //COMO NECESITO CARGAR 10 ARTICULOS, NECESITO UN VECTOR

            //Articulo[] articulos = new Articulo[10];
           // for(int x = 0; x < 10; x++)
           // {
            ///    articulos[x] = new Articulo();
             //   Console.WriteLine("INGRESE DATOS DEL PRODUCTO");
            //    Console.WriteLine("INGRESE CODIGO: ");
             //   articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
             //   Console.WriteLine("INGRESE PRECIO: ");
             //   articulos[x].Precio = float.Parse(Console.ReadLine());
             //   Console.WriteLine("MARCA DE 1 AL 10:");
             //   articulos[x].codigoMarca = int.Parse(Console.ReadLine());
           // }

            //          VENTAS

            //Ventas ventas = new Ventas();   //EN ESTE CASO CARGO 1 SOLA VENTA A LA VEZ UTILIZANDO WHILE, SI NO , NECESITO UN VECTOR

            //Console.WriteLine("ACA CARGAMOS LAS VENTAS");
            //Console.WriteLine("INGRESE CODIGO DE CLIENTE");
           //// ventas.CodigoArticulo = int.Parse(Console.ReadLine());
            //while(ventas.CodigoArticulo != 0)
            //{

            //    Console.WriteLine("CODIGO DE ARTICULO: ");
             //   ventas.CodigoArticulo = int.Parse(Console.ReadLine());
             //   Console.WriteLine("INGRESE LA CANTIDAD: ");
             //   ventas.Cantidad = int.Parse(Console.ReadLine());
             //
             //   Console.WriteLine("INGRESE CODIGO DE CLIENTE o CERO PARA FINALIZAR");
             ///   ventas.CodigoArticulo = int.Parse(Console.ReadLine());

           // }




        }
    }
}
