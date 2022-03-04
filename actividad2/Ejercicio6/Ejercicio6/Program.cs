using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero = 0;

            Console.WriteLine("Escriba un numero del 1 A 10 :))");
            Numero = int.Parse(Console.ReadLine());

            switch (Numero)
            {
                case 1:
                    Console.WriteLine("Se lee uno");
                    break;

                case 2:
                    Console.WriteLine("Se lee dos");
                    break;

                case 3:
                    Console.WriteLine("Se lee tres");
                    break;

                case 4:
                    Console.WriteLine("Se lee cuatro");
                    break;

                case 5:
                    Console.WriteLine("Se lee cinco");
                    break;

                case 6:
                    Console.WriteLine("Se lee seis");
                    break;

                case 7:
                    Console.WriteLine("Se lee siete");
                    break;

                case 8:
                    Console.WriteLine("Se lee ocho");
                    break;

                case 9:
                    Console.WriteLine("Se lee nueve");
                    break;

                case 10:
                    Console.WriteLine("Se lee diez");
                    break;

                default:
                    Console.WriteLine("no esta en el rango de 1 A 10 :)");
                    break;
            }
        }
    }
}
