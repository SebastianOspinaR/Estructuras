using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act1_eje2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoy en el videoclub gran promoción!! lleva 3 peliculas al precio de las 2 más baratas, aprovecha!");

            double Pelicula1;
            double Pelicula2;
            double Pelicula3;
            double Precio;

            Console.WriteLine("Digite el precio pelicula 1");
            Pelicula1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el precio de pelicula 2");
            Pelicula2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el precio de pelicula 3");
            Pelicula3 = double.Parse(Console.ReadLine());

            if (Pelicula1 > Pelicula2 && Pelicula1 > Pelicula3)
            {
                Precio = Pelicula2 + Pelicula3;
                Console.WriteLine("El precio por las peliculas es " + Precio);
            }

            else if (Pelicula2 > Pelicula1 && Pelicula2 > Pelicula3)
            {
                Precio = Pelicula1 + Pelicula2;
                Console.WriteLine("El precio por las peliculas es " + Precio);
            }

            else
            {
                Precio = Pelicula1 + Pelicula2;
                Console.WriteLine("El precio por las pelicula es " + Precio);
            }

            Console.WriteLine("Vuelva pronto :)");
        }
    }
}
