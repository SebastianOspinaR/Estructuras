using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        float[] notasEstudiantes;
        string[] nombresEstudiantes;

        public void CargarVectores()
        {
            notasEstudiantes = new float[12];
            nombresEstudiantes = new string[12];

            for (int f = 0; f < nombresEstudiantes.Length; f++)
            {
                Console.Write($"Ingrese el nombre del estudiante {f + 1} : ");
                nombresEstudiantes[f] = Console.ReadLine();

                Console.Write($"Ingrese la nota del estudiante {nombresEstudiantes[f]} : ");
                notasEstudiantes[f] = float.Parse(System.Console.ReadLine());

                if (notasEstudiantes[f] < 5)
                {
                    Console.WriteLine("la nota es insuficiente");
                }
                if (notasEstudiantes[f] < 7)
                {
                    Console.WriteLine("la nota es aceptable");
                }
                if (notasEstudiantes[f] < 9)
                {
                    Console.WriteLine("la nota es sobresaliente");
                }
                if (notasEstudiantes[f] <= 10)
                {
                    Console.WriteLine("la nota es excelente");
                }
                Console.WriteLine("El estudiante" + nombresEstudiantes +"tiene un nora de"+notasEstudiantes);
            }
        }

        static void Main(string[] args)
        {
            Program notas = new Program();
            notas.CargarVectores();

        }
    }
}

