using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Academia;
            int CANTIDAD_FILAS = 3;
            int CANTIDAD_COLUMNAS = 4;

            Academia = new int[CANTIDAD_FILAS, CANTIDAD_COLUMNAS];

            for (int f = 0; f < CANTIDAD_FILAS; f++)
            {
                for (int c = 0; c < CANTIDAD_COLUMNAS; c++)
                {
                    Console.WriteLine("Digite la cantidad de estudiantes: ");
                    Academia[f, c] = int.Parse(Console.ReadLine());
                }

            }
        }
    }
}
