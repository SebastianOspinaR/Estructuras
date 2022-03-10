using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act1_eje5
{
    class Program
    {
        static void Main(string[] args)
        {
            double Numero = 0;
            Console.WriteLine("digite el numero del Radicando");
            Numero = double.Parse(System.Console.ReadLine());
            double raizCuadrada = Math.Sqrt(Numero);
            Console.WriteLine("La raíz cuadrada de {0} es {1}", Numero, raizCuadrada);
        }
    }
}
