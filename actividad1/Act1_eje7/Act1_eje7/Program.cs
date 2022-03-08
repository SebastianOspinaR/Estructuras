using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act1_eje7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 500;
            int n2 = 200;
            int n3 = 300;
            string Cafe;
            string Chocolate;
            string Leche;

            Console.WriteLine("Consultar valor de articulos Cafe{0}, Chocolate {1}, Leche {2}", n1, n2, n3);

            n1 = int.Parse(System.Console.ReadLine());
            Cafe = Console.ReadLine();

            Console.WriteLine("el precio es {0}", n1);
            Console.WriteLine("el precio es {1}", n2);
            Console.WriteLine("el precio es {2}", n3);
        }
    }
}
