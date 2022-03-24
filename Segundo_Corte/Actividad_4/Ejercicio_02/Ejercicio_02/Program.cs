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
            //Indicamos el tamaño
            String texto = Console.WriteLine("Introduce un tamaño");
            int num[] = new int[Integer.parseInt(texto)];

            //Invocamos las funciones
            rellenarNumAleatorioArray(num, 0, 9);

            mostrarArray(num);
        }

        public static void rellenarNumAleatorioArray(int lista[], int a, int b)
        {
            for (int i = 0; i < lista.length; i++)
            {
                //Generamos un número entre los parametros pasados
                lista[i] = ((int)Math.floor(Math.random() * (a - b) + b));
            }
        }

        public static void mostrarArray(int lista[])
        {
            for (int i = 0; i < lista.length; i++)
            {
                Console.Write("En el indice " + i + " esta el valor " + lista[i]);
            }
        }
    }
}
