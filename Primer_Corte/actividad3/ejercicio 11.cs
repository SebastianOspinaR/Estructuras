using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema10
{
    class Program
    {
        static void Main(string[] args)
        {
            string sueldo;
            int sueldo1, sueldo2, sueldo3, sueldo4, sexo1, sexo2, sexo3, sexo4;
            

            Console.Write("Ingrese el Nombre del trabajador:  ");
            Console.ReadLine();
            Console.Write("Ingrese el documento del trabajador: ");
            Console.ReadLine();
            Console.Write("Ingrese el sueldo del trabajador: ");
            sueldo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el genero del trabajador: ");
            sexo1 = int.Parse(Console.ReadLine());

            Console.Write("-------------------------------------------");
            Console.ReadLine();
            Console.Write("Ingrese el Nombre del trabajador: ");
            Console.ReadLine();
            Console.Write("Ingrese el documento del trabajador: ");
            Console.ReadLine();
            Console.Write("Ingrese el sueldo del trabajador:  ");
            sueldo2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el genero del trabajador: ");
            sexo2 = int.Parse(Console.ReadLine());

            Console.Write("-------------------------------------------");
            Console.ReadLine();
            Console.Write("Ingrese el Nombre del trabajador: ");
            Console.ReadLine();
            Console.Write("Ingrese el documento del trabajador: ");
            Console.ReadLine();
            Console.Write("Ingrese el sueldo del trabajador: ");
            sueldo3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el genero del trabajador: ");
            sexo3 = int.Parse(Console.ReadLine());

            Console.Write("-------------------------------------------");
            Console.ReadLine();
            Console.Write("Ingrese el Nombre del trabajador: ");
            Console.ReadLine();
            Console.Write("Ingrese el documento del trabajador: ");
            Console.ReadLine();
            Console.Write("Ingrese el sueldo del trabajador: ");
            sueldo4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el genero del trabajador: ");
            sexo4 = int.Parse(Console.ReadLine());


            double suma = (sueldo1 + sueldo2 + sueldo3 + sueldo4);

            {
            }

            if (sueldo1 > sueldo2 & sueldo1 > sueldo3 & sueldo1 > sueldo4)
                Console.WriteLine("el sueldo mayor es: " + sueldo1);
            else if (sueldo2 > sueldo1 & sueldo2 > sueldo3 & sueldo2 > sueldo4)
                Console.WriteLine("el sueldo mayor es: " + sueldo2);
            else if (sueldo3 > sueldo1 & sueldo3 > sueldo2 & sueldo3 > sueldo4)
                Console.WriteLine("el sueldo mayor es: " + sueldo3);
            else if (sueldo4 > sueldo1 & sueldo4 > sueldo2 & sueldo4 > sueldo3)
                Console.WriteLine("el sueldo mayor es: " + sueldo4);
            else
            {

            }

            if (sueldo1 < sueldo2 & sueldo1 < sueldo3 & sueldo1 < sueldo4)
                Console.WriteLine("el sueldo menor es: " + sueldo1);
            else if (sueldo2 < sueldo1 & sueldo2 < sueldo3 & sueldo2 < sueldo4)
                Console.WriteLine("el sueldo menor es: " + sueldo2);
            else if (sueldo3 < sueldo1 & sueldo3 < sueldo2 & sueldo3 < sueldo4)
                Console.WriteLine("el sueldo menor es: " + sueldo3);
            else if (sueldo4 < sueldo1 & sueldo4 < sueldo2 & sueldo4 < sueldo3)
                Console.WriteLine("el sueldo menor es: " + sueldo4);
            else
            {

            }
            int Hombres = 0, Mujeres = 0;
            int M = 0, F = 0;
            //persona1
            if (sexo1==1)
                if (sueldo1>1000000)
                {
                    F = F + 1;
                    Mujeres = (Mujeres + sueldo1);                    
                }
                else
                {
                    Mujeres = (Mujeres + sueldo1);
                }
            else
            {
                if (sexo1==2)
                {
                    if (sueldo1<900000)
                    {
                        M = M + 1;
                        Hombres = (Hombres + sueldo1);
                    }
                    else
                    {
                        Hombres = (Hombres + sueldo1);
                    }
                }
            }
            //persona2
            if (sexo1 == 1)
                if (sueldo2 > 1000000)
                {
                    F = F + 1;
                    Mujeres = (Mujeres + sueldo1);
                }
                else
                {
                    Mujeres = (Mujeres + sueldo1);
                }
            else
            {
                if (sexo1 == 2)
                {
                    if (sueldo2 < 900000)
                    {
                        M = M + 1;
                        Hombres = (Hombres + sueldo1);
                    }
                    else
                    {
                        Hombres = (Hombres + sueldo1);
                    }
                }
            }
            //persona3
            if (sexo1 == 1)
                if (sueldo3 > 1000000)
                {
                    F = F + 1;
                    Mujeres = (Mujeres + sueldo1);
                }
                else
                {
                    Mujeres = (Mujeres + sueldo1);
                }
            else
            {
                if (sexo1 == 2)
                {
                    if (sueldo3 < 900000)
                    {
                        M = M + 1;
                        Hombres = (Hombres + sueldo1);
                    }
                    else
                    {
                        Hombres = (Hombres + sueldo1);
                    }
                }
            }
            //persona4
            if (sexo1 == 1)
                if (sueldo4 > 1000000)
                {
                    F = F + 1;
                    Mujeres = (Mujeres + sueldo1);
                }
                else
                {
                    Mujeres = (Mujeres + sueldo1);
                }
            else
            {
                if (sexo1 == 2)
                {
                    if (sueldo4 < 900000)
                    {
                        M = M + 1;
                        Hombres = (Hombres + sueldo1);
                    }
                    else
                    {
                        Hombres = (Hombres + sueldo1);
                    }
                }
            }
            Console.Write("El total de los sueldos de las mujeres es : " + Mujeres);
            Console.Write("El total de los sueldos de las Hombres es : " + Hombres);
            Console.Write("El numero de mujeres que ganan mas de 1.000.000 es: " + F);
            Console.Write("El numero de hombres que ganan menos de 900.000 es: " + M);
            Console.Write("El total de los sueldos es : " + suma);
            Console.ReadLine();

            Console.Write("-------------------------------------------");
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
