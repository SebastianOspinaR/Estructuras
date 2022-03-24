using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] ciudades = new string[5, 4];
            string[,] Pais = new string[5, 4];

            for (int i = 0; i < Pais.Length; i++)
            {
                for (int c = 0; c < ciudades.Length; c++)
                {
                    Console.Write($"Ingrese la ciudad del pais {c + 1}");
                    ciudades[c] = Console.ReadLine();
                }
                Console.Write($"Ingrese el pais {i + 1}");
                Pais[i] = Console.ReadLine();
            }
        }
    }
}
