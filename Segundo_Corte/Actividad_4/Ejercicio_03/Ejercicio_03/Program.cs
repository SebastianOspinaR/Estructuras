﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = Console.WriteLine("Introduce un tamaño");
            int num[] = new int[Integer.parseInt(texto)];

            rellenarNumPrimosAleatorioArray(num, 1, 100);

            mostrarArray(num);

            int primoMayor = mayor(num);
            Console.WriteLine("El primo más grande es el " + primoMayor);
        }

        public static void rellenarNumPrimosAleatorioArray(int lista[], int a, int b)
        {

            int i = 0;

            while (i < lista.length)
            {
                int num = ((int)Math.floor(Math.random() * (a - b) + b));
                if (esPrimo(num))
                {
                    lista[i] = num;
                    i++;
                }
            }
        }
        private static boolean esPrimo(int num)
        {

            if (num <= 1)
            {
                return false;
            }
            else
            {

                int prueba;
                int contador = 0;
                prueba = (int)Math.sqrt(num);
                for (; prueba > 1; prueba--)
                {
                    if (num % prueba == 0)
                    {
                        contador += 1;
                    }
                }
                return contador < 1;
            }
        }

        public static void mostrarArray(int lista[])
        {
            for (int i = 0; i < lista.length; i++)
            {
                Console.WriteLine("En el indice " + i + " esta el valor " + lista[i]);
            }
        }

        public static int mayor(int lista[])
        {
            int mayor = 0;
            for (int i = 0; i < lista.length; i++)
            {
                if (lista[i] > mayor)
                {
                    mayor = lista[i];
                }
            }

            return mayor;
        }
    }
}
