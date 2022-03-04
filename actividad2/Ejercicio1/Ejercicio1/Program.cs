using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre = "";
            int Nota1, Nota2, Nota3, Nota4;
            bool bandera = true;

            Console.Write("Hola Estudiante, Escribe tu Nombre: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Hola " + Nombre+", ingresa el nombre de la asignatura");

            while (bandera)
            {
                string Notas=Console.ReadLine();
                switch (Notas)
                {
                    case "Matematicas":
                        Console.WriteLine("Ingrese su Nota de Matematicas ");
                        Nota1 = Convert.ToInt32(Console.ReadLine());

                        if (Nota1 < 50)
                        {
                            Console.WriteLine("Su nota es Insuficiente");
                        }
                        else if (Nota1 >= 50)
                        {
                            Console.WriteLine("Su nota es Suficiente");
                        }
                        else if (Nota1 > 59)
                        {
                            Console.WriteLine("Su nota es Bien");
                        }
                        else if (Nota1 > 69)
                        {
                            Console.WriteLine("Su nota es Notable");
                        }
                        else if (Nota1 > 89)
                        {
                            Console.WriteLine("Su nota es Sobresaliente");
                        }
                        break;
                    case "Español":
                        Console.WriteLine("Ingrese su Nota de Español ");
                        Nota2 = Convert.ToInt32(Console.ReadLine());

                        if (Nota2 < 50)
                        {
                            Console.WriteLine("Su nota es Insuficiente");
                        }
                        else if (Nota2 >= 50)
                        {
                            Console.WriteLine("Su nota es Suficiente");
                        }
                        else if (Nota2 > 59)
                        {
                            Console.WriteLine("Su nota es Bien");
                        }
                        else if (Nota2 > 69)
                        {
                            Console.WriteLine("Su nota es Notable");
                        }
                        else if (Nota2 > 89)
                        {
                            Console.WriteLine("Su nota es Sobresaliente");
                        }
                        break;
                    case "Fisica":
                        Console.WriteLine("Ingrese su Nota de Fisica ");
                        Nota3 = Convert.ToInt32(Console.ReadLine());

                        if (Nota3 < 50)
                        {
                            Console.WriteLine("Su nota es Insuficiente");
                        }
                        else if (Nota3 >= 50)
                        {
                            Console.WriteLine("Su nota es Suficiente");
                        }
                        else if (Nota3 > 59)
                        {
                            Console.WriteLine("Su nota es Bien");
                        }
                        else if (Nota3 > 69)
                        {
                            Console.WriteLine("Su nota es Notable");
                        }
                        else if (Nota3 > 89)
                        {
                            Console.WriteLine("Su nota es Sobresaliente");
                        }
                        break;
                    case "Ingles":
                        Console.WriteLine("Ingrese su Nota de Ingles ");
                        Nota4 = Convert.ToInt32(Console.ReadLine());

                        if (Nota4 < 50)
                        {
                            Console.WriteLine("Su nota es Insuficiente");
                        }
                        else if (Nota4 >= 50)
                        {
                            Console.WriteLine("Su nota es Suficiente");
                        }
                        else if (Nota4 > 59)
                        {
                            Console.WriteLine("Su nota es Bien");
                        }
                        else if (Nota4 > 69)
                        {
                            Console.WriteLine("Su nota es Notable");
                        }
                        else if (Nota4 > 89)
                        {
                            Console.WriteLine("Su nota es Sobresaliente");
                        }
                        break;                    
                    default:
                        Console.WriteLine("Dato no valido");
                        break;
                }
            }
        }
    }
}
