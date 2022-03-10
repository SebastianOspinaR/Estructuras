using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act1_eje3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Asignatura;
            float Nota1, Nota2, Nota3, Nota4, Nota5;
            float mayor, menor;

            Console.Write("Nombre de la asignatura: ");
            Asignatura = Console.ReadLine();

            Console.Write("Ingrese el valor: ");
            Nota1 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor: ");
            Nota2 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor: ");
            Nota3 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor: ");
            Nota4 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor: ");
            Nota5 = float.Parse(Console.ReadLine());

            if (Nota1 > Nota2 && Nota1 > Nota3 && Nota1 > Nota4 && Nota1 > Nota5)
            {
                mayor = Nota1;
                Console.WriteLine("La nota mayor es:" + Nota1);
            }
            else if (Nota1 < Nota2 && Nota1 < Nota3 && Nota1 < Nota4 && Nota1 < Nota5)
            {
                menor = Nota1;
                Console.WriteLine("La nota menor es:" + Nota1);

            }
            if (Nota2 > Nota1 && Nota2 > Nota3 && Nota2 > Nota4 && Nota2 > Nota5)
            {
                mayor = Nota2;
                Console.WriteLine("La nota mayor es:" + Nota2);
            }
            else if (Nota2 < Nota1 && Nota2 < Nota3 && Nota2 < Nota4 && Nota2 < Nota5)
            {
                menor = Nota2;
                Console.WriteLine("La nota menor es:" + Nota2);
            }
            if (Nota3 > Nota1 && Nota3 > Nota2 && Nota3 > Nota4 && Nota3 > Nota5)
            {
                mayor = Nota3;
                Console.WriteLine("La nota mayor es:" + Nota2);
            }
            else if (Nota3 < Nota1 && Nota3 < Nota2 && Nota3 < Nota4 && Nota3 < Nota5)
            {
                menor = Nota3;
                Console.WriteLine("La nota menor es:" + Nota2);
            }
            if (Nota4 > Nota1 && Nota4 > Nota2 && Nota4 > Nota3 && Nota4 > Nota5)
            {
                mayor = Nota4;
                Console.WriteLine("La nota mayor es:" + Nota2);
            }
            else if (Nota4 < Nota1 && Nota4 < Nota2 && Nota4 < Nota3 && Nota4 < Nota5)
            {
                menor = Nota4;
                Console.WriteLine("La nota menor es:" + Nota2);
            }
            if (Nota5 > Nota1 && Nota5 > Nota2 && Nota5 > Nota3 && Nota5 > Nota4)
            {
                mayor = Nota5;
                Console.WriteLine("La nota mayor es:" + Nota5);
            }
            else if (Nota5 < Nota1 && Nota5 < Nota2 && Nota5 < Nota3 && Nota5 < Nota4)
            {
                menor = Nota5;
                Console.WriteLine("La nota menor es:" + Nota5);
            }

            double promedio = (Nota1 + Nota2 + Nota3 + Nota4 + Nota5) / 5;

            Console.WriteLine("El promedio de las calificaciones es:" + promedio.ToString("0"));
            Console.ReadKey();
        }
    }
}
