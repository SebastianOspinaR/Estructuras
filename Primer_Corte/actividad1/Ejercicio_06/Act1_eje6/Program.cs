using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act1_eje6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Segundos = 0;
            float Minutos = 0.0f;
            float Horas = 0.0f;
            float Dias = 0.0f;

            Console.WriteLine("Digite el numero de segundos");

            Segundos = int.Parse(System.Console.ReadLine());

            Minutos = (Segundos * 1) / 60;
            Horas = (Segundos / 3600);
            Dias = (Segundos / 86400);
            Console.WriteLine("El valor en Minutos es {0}", Minutos);
            Console.WriteLine("El valor en Horas es {0}", Horas);
            Console.WriteLine("El valor en Dias es {0}", Dias);
        }
    }
}
