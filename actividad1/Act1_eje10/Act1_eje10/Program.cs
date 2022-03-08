using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act1_eje10
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cedula, Contraseña = 123456;
            bool Bandera = true;
            while (Bandera)

            {
                Console.WriteLine("\nIngrese 1 para ingresar al sistema \nIngrese 2  para cancelar \n");
                int eleccion_funcion = Convert.ToInt32(Console.ReadLine());
                switch (eleccion_funcion)
                {
                    case 1:
                        Console.WriteLine("\nIngrese el numero de cedula: \n");
                        Cedula = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nIngrese el numero de contraseña: \n");
                        Contraseña = Convert.ToInt32(Console.ReadLine());

                        if (Cedula.Equals(1) && Contraseña.Equals(123456))
                        {
                            Bandera = false;
                        }
                        else
                        {
                            Console.WriteLine("DOCUMENTO O CODIGO INCORRETO");
                        }
                        break;
                    case 2:
                        Bandera = false;
                        break;
                    default:
                        Console.WriteLine("\nIngrese una opcion valida\n");
                        break;

                }
            }
        }
    }
}
