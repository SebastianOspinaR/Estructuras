using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act1_eje1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Por favor ingresar un numero");
            numero = int.Parse(Console.ReadLine());

            {
                if (numero > 0) ;

                else
                    Console.Write("El numero es:" + numero + " y su valor absoluto es:" + Math.Abs(numero));

            }
        }
    }
}
