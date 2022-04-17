using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz;
            int Opcion = 0;
            int cantidadcolumnas = 0;
            int cantidadfilas = 0;

            Console.WriteLine("digite tamaño de las columnas");
            cantidadcolumnas = int.Parse(Console.ReadLine());
            Console.WriteLine("digite el tamaño de las filas");
            cantidadfilas = int.Parse(Console.ReadLine());

            Console.WriteLine("Oprima 1 si quiere digitar su numero oprima " +
                "\n 2 si quiere que aparezca de forma aleatoria");
            
            Opcion = int.Parse(Console.ReadLine());

            switch (Opcion)
            {
                case 1:
                    matriz = new int[cantidadfilas, cantidadcolumnas];
                    for (int n = 0; n < cantidadcolumnas; n++)
                    {
                        for (int m = 0; m < cantidadfilas; m++)
                        {
                            Console.WriteLine("digite el numero");
                            matriz[m, n] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    matriz = new int[cantidadcolumnas, cantidadfilas];
                    Random aleatorio = new Random();
                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < matriz.GetLength(1); j++)
                        {
                            matriz[i, j] = (aleatorio.Next(10, 999));
                            Console.WriteLine(matriz[i, j]);
                        }
                        Console.WriteLine(); 
                    }
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
}
