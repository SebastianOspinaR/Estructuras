using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {           
            int filas = 28;
            int columnas = 7;
            int x = 0;
            int y = 0;
            int numero = 1;
            int[,] tabla = new int[columnas, filas];
            string combinar = "";
            int[] operando = new int[6];
            int apuesta = 0;

            do
            {
                Console.WriteLine("Indique el número de apuestas a realizar: ");
                apuesta = comprobar(Console.ReadLine());


                for (int i = 0; i <= 6; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {

                        tabla[j, i] = numero;
                        numero++;
                    }
                }

                for (int i = 0; i <= 6; i++)
                {
                    x = i + 6;
                    for (int j = 0; j < 7; j++)
                    {

                        y = j * 4;
                        Console.SetCursorPosition(y, x);
                        Console.Write(tabla[j, i]);


                    }
                }

                for (int contador = 1; contador <= apuesta; contador++)
                {
                    int n = 0;
                    Console.SetCursorPosition(0, 04);
                    Console.WriteLine("Apuesta {0}: ", contador);
                    operando[0] = aleatorio.Next(1, 50);
                    operando[1] = aleatorio.Next(1, 50);
                    operando[2] = aleatorio.Next(1, 50);
                    operando[3] = aleatorio.Next(1, 50);
                    operando[4] = aleatorio.Next(1, 50);
                    operando[5] = aleatorio.Next(1, 50);

                    for (int i = 0; i <= 6; i++)
                    {
                        x = i + 6;
                        for (int j = 0; j < 7; j++)
                        {
                            y = j * 4;
                            Console.SetCursorPosition(y, x);
                            n++;
                            Console.Write("{0}", n);
                            if (operando[0] == n || operando[1] == n || operando[2] == n || operando[3] == n || operando[4] == n || operando[5] == n)
                            {
                                Console.Write((" X"), Console.ForegroundColor = ConsoleColor.Green);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ReadLine();
                            }
                        }
                    }
                }

                Console.WriteLine("\n" + "\n" + "¿Generar otra combinación? S/N");
                combinar = (Console.ReadLine());


            } while (combinar == "S" || combinar == "s");
        }
    }
}

