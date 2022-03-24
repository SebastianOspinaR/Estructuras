using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        int numeroPersonas;
        int[] alturaPersonas;
        int[] media;

        public void Carga()
        {         

            Console.WriteLine("Ingrese la cantidad de personas");
            numeroPersonas = int.Parse(Console.ReadLine());

            alturaPersonas = new int[numeroPersonas];

            for (int f = 0; f < alturaPersonas.Length; f++)
            {
                Console.Write($"Ingrese la altura {f + 1} ");
                alturaPersonas[f] = int.Parse(Console.ReadLine()); 
                
            }
            media = (double)numeroPersonas / alturaPersonas[f];
            Console.WriteLine($"la media de altura es {media}");

            if (alturaPersonas<media)
            {
                Console.WriteLine("la altura esta por debajo de la media");
            }
            else if (alturaPersonas > media)
            {
                Console.WriteLine("la altura esta por encima de la media");
            }
        }
       
        static void Main(string[] args)
        {
            Program altura = new Program();
            altura.Carga();
            
        }
    }
}
