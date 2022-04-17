﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int alumnos = 0;

            Console.WriteLine("Digite la cantidad de estudiantes: ");
            alumnos = int.Parse(System.Console.ReadLine());

            double[,] matriz1 = new double[alumnos, 3];
            int i = 0;

            while (i < alumnos)
            {

                Console.WriteLine("Estudiante" + i);
                Console.WriteLine("Nota #1: ");
                double n1 = double.Parse(System.Console.ReadLine());

                Console.WriteLine("Nota #2: ");
                double n2 = double.Parse(System.Console.ReadLine());

                Console.WriteLine("Nota #3: ");
                double n3 = double.Parse(System.Console.ReadLine());

                matriz1[i, 0] = n1;
                matriz1[i, 1] = n2;
                matriz1[i, 2] = n3;


                i++;
            }

            int j = 0;
            double suma = 0;

            while (j < alumnos)
            {
                double proalum1 = (matriz1[j, 0] + matriz1[j, 1] + matriz1[j, 2]) / 3;
                Console.WriteLine("El promedio del alumno " + j + " es: " + proalum1);

                suma = suma + proalum1;
                j++;
            }

            double progen = suma / alumnos;
            Console.WriteLine("El promedio general de los alumnos es:" + progen);

        }
    }
}
