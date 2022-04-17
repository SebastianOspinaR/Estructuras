using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(String[] args)
        {
            int TF = 5;
            int TC = 5;

            int[,] matriz1 = new int[TF, TC];
            for (int f1 = 0; f1 < TF; f1++)
            {
                for (int c1 = 0; c1 < TC; c1++)
                {
                    Console.Write($"Ingrese el elemento [{f1 + 1},{c1 + 1}] de la matriz #2: ");
                    matriz1[f1, c1] = int.Parse(Console.ReadLine());
                }
            }
            int[,] matriz2 = new int[TF, TC];
            for (int f2 = 0; f2 < TF; f2++)
            {
                for (int c2 = 0; c2 < TC; c2++)
                {
                    matriz2[f2, c2] = matriz1[c2, f2];
                }
            }
            string resultado = "La matriz resultante #1 es: \n";
            for (int fil2 = 0; fil2 < TF; fil2++)
            {
                for (int col2 = 0; col2 < TC; col2++)
                {
                    resultado = resultado + ("[" + matriz1[fil2, col2] + "] ");
                }
                resultado = resultado + "\n";
            }
            resultado = resultado + " La matriz transpuesta es: \n";
            for (int fil2 = 0; fil2 < TF; fil2++)
            {
                for (int col2 = 0; col2 < TC; col2++)
                {
                    resultado = resultado + ("[" + matriz2[fil2, col2] + "] ");
                }
                resultado = resultado + "\n";
            }
            Console.Write("el resultado es: "+resultado);
            Console.ReadKey();
        }
    }
}
