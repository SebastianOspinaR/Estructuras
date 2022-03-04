
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema7
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, menor, mayor;
            int i, cont = 0;

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

            Console.Write("ingrese p para par o i para impar ");

            string Eleccion = Console.ReadLine();
            switch (Eleccion)
            {
                case "p":
                    for (i = (int)menor + 1; i < mayor; i++)
                    {
                        Console.Write("\n\n{0}|", i);
                        cont++;
                        if (i % 2 == 0)
                            
                        Console.Write("\n\n los numeros pares son", i);
                    }
                 break;
                case "i":
                    for (i = (int)menor + 1; i < mayor; i++)
                    {
                        Console.Write("{0}|", i);
                        cont++;
                        if (i%2 != 0)
                            
                        Console.Write("\n\n los numeros impares son", i);
                    }
                    break;
                default:
                    break;
            }

            Console.Read();
        }
    }
}
