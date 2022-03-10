using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {

            int Dato;
            int SDescuento, Descuento1, Descuento2, Descuento3;
            int M2 = 50;
            int A1, A2, A3, B1, B2, B3;

            Console.WriteLine("Bienvenido, con esta aplicacion podras saber el costo de tu terreno, en metros cuadrados");
            Console.WriteLine("Ingrese el numero de metros cuadrados de su terreno ");
            Dato = Convert.ToInt32(Console.ReadLine());

            if (Dato < 400)
            {
                SDescuento = (M2 * Dato);
                Console.WriteLine("El valor de su terreno es de "+ SDescuento + "$ sin ningun tipo de descuento");
                Console.WriteLine("El valor de cada metro cuadrado es de 50$");
            }
            else if (Dato >= 400)
            {
                A1 = (M2 * Dato);
                Descuento1 = (A1 * 10 / 100);
                B1 = (A1 - Descuento1);

                Console.WriteLine("El valor de su terreno es de " + B1 + "$ con el 10% de descuento ya que supera los" +
                    " 400 metros cuadrados ");
                Console.WriteLine("El valor de cada metro cuadrado es de 50$");
            }
            else if (Dato >= 500)
            {
                A2 = (M2 * Dato);
                Descuento2 = (A2 * 17 / 100);
                B2 = (A2 - Descuento2);

                Console.WriteLine("El valor de su terreno es de "+ B2 + "$ con el 17% de descuento ya que supera los" +
                    "500 metros cuadrados ");
                Console.WriteLine("El valor de cada metro cuadrado es de 50$");
            }
            else if (Dato >= 1000)
            {
                A3 = (M2 * Dato);
                Descuento3 = (A3 * 25 / 100); 
                B3 = (A3 - Descuento3);

                Console.WriteLine("El valor de su terreno es de "+ B3 + "$ con el 17% de descuento ya que supera los" +
                    "1000 metros cuadrados ");
                Console.WriteLine("El valor de cada metro cuadrado es de 50$");
            }
        }
    }
}
