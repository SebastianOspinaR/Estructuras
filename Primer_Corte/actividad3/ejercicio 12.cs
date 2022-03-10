using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema12
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1=0, v2=0, v3=0, voto, max;
            double total, vo1, vo2, vo3;
            string ganador;

            
            Console.WriteLine("Ingrese (1) por el primer participante" +
                "Ingrese (2) por el segundo participante participante" +
                "Ingrese (3) por el tercer participante" +
                "Ingrese (4) para salir");
            do
            {
                Console.WriteLine("Ingrese su voto");
                voto = int.Parse(Console.ReadLine());
                if (voto==1)
                {
                    v1 = v1 + 1;
                }
                else if(voto == 2)
                {
                    v2 = v2 + 1;
                }
                else if (voto == 3)
                {
                    v3 = v3 + 1;
                }
            } while (voto !=4);
            total = v1 + v2 + v3;

            Console.WriteLine("El total de votos del primer participante son: " + v1);
            Console.WriteLine("El total de votos del segundo participante son: " + v2);
            Console.WriteLine("El total de votos del tercer participante son: " + v3);

            max = v1;
            ganador = "Participante 1";
            if (v2>max)
            {
                ganador = "Participante 2";
            }
            if (v3 > max)
            {
                ganador = "Participante 3";
            }
            Console.WriteLine("Felicidades {0}",ganador);
            Console.ReadLine();
        }
    }
}
