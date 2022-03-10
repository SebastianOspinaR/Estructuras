using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            int i;            
            int vocales = 0;
            int consonantes = 0;
            int espacio = 0;
            string frase;
            string L;

            Console.Write("por favor ingrese una frase");
            frase = Console.ReadLine();

            for (X = 0; X < frase.Length; X++) ;
            {
                i = frase[X];
                int c = (i);

                if (L == "a" || L == "e" || L == "i" || L == "o" || L == "u")
                { 
                    vocales++;
                }

                else if 
                (L == "a" || L == "b" || L == "c" || L == "d" || L == "e" || L == "f" || L == "g" || L == "h" || L == "i" || L == "j" || L == "k" 
                    || L == "l" || L == "m" || L == "n" || L == "ñ" || L == "o" || L == "p" || L == "q" || L == "r" || L == "s" || L == "t" || L == "u" 
                    || L == "v" || L == "w" || L == "x" || L == "y" || L == "z")
                {
                    consonantes++;
                }

                else if ((L == " ")) ;
                {
                    espacio++;
                }
                
                Console.WriteLine(" La frase tiene " + vocales + " vocales");
                Console.WriteLine(" La frase tiene " + espacio + " espacios");
                Console.WriteLine(" La frase tiene " + consonantes + "consonantes");
                Console.WriteLine(" La frase tiene " + frase.Length + " numeros");
                Console.ReadKey();
            }            
        }
    }
}
