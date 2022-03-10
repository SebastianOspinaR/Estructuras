using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, menor, mayor;
            int i, cont = 0, contpar = 0;

            do
            {
                Console.Write("ingrese el primer valor: ");
                numero1 = float.Parse(Console.ReadLine());
                Console.Write("ingrese el segundo valor: ");
                numero2 = float.Parse(Console.ReadLine());
            }
            while (numero1 == numero2);
            if (numero1 < numero2)
            {
                menor = numero1;
                mayor = numero2;
            }
            else
            {
                menor = numero2;
                mayor = numero1;
            }

            for (i = (int)menor + 1; i < mayor; i++)
            {
                Console.Write("{0}|", i);
                cont++;
                if (i % 2 == 0)
                    contpar++;
            }
            double suma = menor + mayor + cont + contpar;
            Console.Write("el total de numeros  " + suma);
            Console.Write("\n\nEntre {0} y {1} el total de numeros pares son {3} ", menor, mayor, cont, contpar);
            Console.Read();
        }
    }
}
