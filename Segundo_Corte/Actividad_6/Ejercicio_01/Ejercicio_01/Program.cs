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
         int TamañoArrayList = 0;
            int numero = 0;
            Console.WriteLine("lista numero 1");
            TamañoArrayList = int.Parse(Console.ReadLine());
            ArrayList lista = new ArrayList();
            for (int i = 0; i < TamañoArrayList; i++)
            {
                Console.WriteLine( $"digite el elemento {i+1}:");   
                numero=int.Parse(Console.ReadLine());
                if (numero != 0) {
                    lista.Insert(i, numero);
                }
                if(numero == 0){
                    i = TamañoArrayList + 1;
                }

                imprime(lista);
            
                foreach (int n in arreglo)
                    Console.WriteLine("{0},", n);
                Console.WriteLine("\n---------");
                arreglo.Sort();            
        }
    }
}
