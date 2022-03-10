using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prooblema10
{
    class Program
    {
        static void Main(string[] args)
        {
            int vacunas1 = 0;
            int vacunas2 = 0;
            int vacunas3 = 0;
            int cantidad1, cantidad2, cantidad3;
            string historialvacunas1 = " vacunas: ";//1
            string historialvacunas2 = " vacunas: ";//2
            string historialvacunas3 = " vacunas: ";//3

            Console.WriteLine("Ingresa la cantidad a de vacunas utilizadas en el punto 1"); 
            cantidad1 = int.Parse(Console.ReadLine());
            vacunas1 = vacunas1 + cantidad1;

            Console.WriteLine("Ingresa la cantidad a de vacunas utilizadas en el punto 2");
            cantidad2 = int.Parse(Console.ReadLine());
            vacunas2 = vacunas2 + cantidad2;

            Console.WriteLine("Ingresa la cantidad a de vacunas utilizadas en el punto 3");
            cantidad3 = int.Parse(Console.ReadLine());
            vacunas3 = vacunas3 + cantidad3;



            bool bandera = true;

            while (bandera)
            {
                Console.WriteLine("Ingresa el numero del punto (1,2,3) para ver su historial \n" +
                    "Ingresa t para ver el historial de todos los puntos \n" +
                    "Ingresa s para salir del menu");
                string q = Console.ReadLine();
                switch (q)
                {
                    case "1":
                        historialvacunas1 = historialvacunas1 + "," + vacunas1;
                        Console.WriteLine("Historial del punto 1 " + historialvacunas1);
                        break;
                    case "2":
                        historialvacunas2 = historialvacunas2 + "," + vacunas2;
                        Console.WriteLine("Historial del punto 2 " + historialvacunas2);
                        break;
                    case "3":
                        historialvacunas3 = historialvacunas3 + "," + vacunas3;
                        Console.WriteLine("Historial del punto 3 " + historialvacunas3);
                        break;
                    case "t":
                        Console.WriteLine("Historial del punto 1" + historialvacunas1);
                        Console.WriteLine("Historial del punto 2" + historialvacunas2);
                        Console.WriteLine("Historial del punto 3" + historialvacunas3);
                        break;
                    case "s":
                        bandera = false;
                        break;
                    default:
                        Console.WriteLine("EL punto ingresado no esta en la lista");
                        break;
                }
            }
        }
    }
}
