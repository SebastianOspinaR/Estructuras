using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
         static void Mostrar(ArrayList Arreglo)
        {
            foreach (float n in Arreglo)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("--------------");
        }
        static void Main(string[] args)
        {
            ArrayList Lista1 = new ArrayList();
            ArrayList Lista2 = new ArrayList();
            Console.Write("Digite el tamaño del arraylist: ");
            int m = int.Parse(Console.ReadLine());
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Digite el elemento {j + 1}: ");
                float Valor = float.Parse(Console.ReadLine());
                Lista1.Insert(j, Valor);
                Lista2.Insert(j, Valor); 
            }
            Console.WriteLine("La lista #1 es: ");
            Mostrar(Lista1);
            Console.WriteLine("La lista #2 es: ");
            Lista2.Reverse();
            Mostrar(Lista2);
            Console.WriteLine("La lista #1 nueva es: ");
            Lista1.Clear();
            Mostrar(Lista1);
        }
    }
}
