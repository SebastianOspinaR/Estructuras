using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
        int[,] numeros;
        int CANTIDAD_FILAS = 4;
        int CANTIDAD_COLUMNAS = 5;

            numeros = new int[CANTIDAD_FILAS, CANTIDAD_COLUMNAS];
            int suma = 0;
            int sumacolumnas = 0;
            int sumafilas = 0;

            for (int f = 0; f < CANTIDAD_FILAS; f++)

            {
                for (int c = 0; c < CANTIDAD_COLUMNAS; c++)
                {
                    Console.Write("Digite los datos: ");
                    numeros[f, c] = int.Parse(Console.ReadLine());
                    suma = sumacolumnas + sumafilas;
                    sumacolumnas += numeros[f, c];
                    sumafilas += numeros[f, c];

                }

                Console.WriteLine();
            }

            Console.WriteLine("El total de columnas es: " + sumacolumnas);
            Console.WriteLine("El total de filas es: " + sumafilas);
            Console.WriteLine("El total es: " + suma);
        
        }
    }
}
