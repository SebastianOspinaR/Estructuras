using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero1 = 0;
            int Numero2 = 0;
            double Resultado = 0;
            bool n = true;

            while (true)
            {
                Console.WriteLine("Selecciona 1 para el area del triangulo o 2 circulo");

                int m = int.Parse(Console.ReadLine());
                switch (m)
                {
                    case 1:
                        Console.Write("Dame el primer valor por favor: ");
                        Numero1 = int.Parse(System.Console.ReadLine());
                        Console.Write("Dame el segundo valor por favor: ");
                        Numero2 = int.Parse(System.Console.ReadLine());

                        Resultado = Numero1 * Numero2 / 2;
                        Console.WriteLine("El area es: " + Resultado);
                        break;
                    case 2:
                        Console.Write("Dame el primer valor por favor: ");
                        Numero1 = int.Parse(System.Console.ReadLine());
                        Console.Write("Dame el segundo valor por favor: ");
                        Numero2 = int.Parse(System.Console.ReadLine());

                        Resultado = Numero1 * Numero1 * Math.PI;
                        Console.WriteLine("El area es: " + Resultado);
                        break;
                    default:
                        Console.WriteLine("El dato no es valido");
                        break;
                }
            }
        }
    }
}
