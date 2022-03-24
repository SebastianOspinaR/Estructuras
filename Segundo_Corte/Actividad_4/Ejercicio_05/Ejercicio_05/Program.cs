using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner sc = new Scanner(System.in);

            char mayusculas[] = new char[26];
            for (int i = 65, j = 0; i <= 90; i++, j++)
            {
                mayusculas[j] = (char)i;
            }

            String cadena = "";
            int eleccion = -1;

            do
            {
                Console.WriteLine("Elija un indice entre 0 y " + (mayusculas.length - 1));
                eleccion = sc.nextInt();

                if (!(eleccion >= 0 && eleccion <= mayusculas.length - 1))
                {
                    Console.WriteLine("Error, inserte otro numero");
                }
                else
                {
                    if (eleccion != -1)
                    {
                        cadena += mayusculas[eleccion];
                    }
                }

            } while (eleccion != -1);

            Console.WriteLine(cadena);

        }
    }
}
