using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[100];

            int suma = 0;
            double media;

            for (int i = 0; i < numeros.length; i++)
            {
                numeros[i] = i + 1;
                suma += numeros[i];
            }

            Console.WriteLine("La suma es " + suma);

            media = (double)suma / numeros.length;

            Console.WriteLine("La media es " + media);

        }
    }
}
