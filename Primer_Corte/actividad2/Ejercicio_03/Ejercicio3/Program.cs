using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Num1, Num2;
            int Num;

            Console.WriteLine("Ingrese un Numero mayor a 100");
            Num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Segundo numero ");
            Num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese 1 = Suma, 2 = Resta, 3 = Multiplicacion, 4 = Division");
            Num = int.Parse(Console.ReadLine());
            switch (Num)
            {
                case 1:
                    Console.WriteLine(Num1 + Num2);
                    break;
                case 2:
                    Console.WriteLine(Num1 - Num2);
                    break;
                case 3:
                    Console.WriteLine(Num1 * Num2);
                    break;
                case 4:
                    Console.WriteLine(Num1 / Num2);
                    break;
            }
        }
    }
}
