using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act1_eje9
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal Resultado;
            int EdadPersona;

            Console.WriteLine("digite la edad");
            EdadPersona = int.Parse(System.Console.ReadLine());

            if (EdadPersona > 2)
            {
                Resultado = 21 + (EdadPersona - 2) * 4;
            }
            else
            {
                Resultado = (EdadPersona * 10);
            }
            Console.WriteLine("La edad del perro equivale en años humanos a: " + Resultado);
        }
    }
}
