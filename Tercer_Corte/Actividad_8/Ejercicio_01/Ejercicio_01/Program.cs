using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{

    class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el nombre del metodo\n Si quieres salir escribe S");

            bool inicio = true;
            while (inicio)
            {
                string b = Console.ReadLine();
                switch (b)
                {
                    case "ToString":
                        int numero = 315;
                        String numero1 = numero.ToString();
                        System.Console.WriteLine(numero1);
                        break;
                    case "DateTime":
                        string fechaActual = DateTime.Now.ToString("dd-MM-yyyy");
                        Console.WriteLine("La fecha actual es {0}", fechaActual);

                        Console.WriteLine("Digite una fecha anterior a hoy");
                        DateTime fechaUsuario = DateTime.Parse(Console.ReadLine());
                        string fechaDigitada = DateTime.Now.ToString("dd-MM-yyyy");

                        DateTime fechaSistema = Convert.ToDateTime(fechaActual);


                        if (fechaUsuario > fechaSistema)
                        {
                            Console.WriteLine("La fecha debe ser menor a hoy");

                        }
                        else
                        {
                            TimeSpan difFechas = fechaSistema - fechaUsuario;
                            int dias = difFechas.Days;
                            Console.WriteLine("La diferencia entre su fecha digitada {0} y fecha de hoy {1} son: {2} dias  ", fechaDigitada, fechaActual, dias);

                            float meses = dias / 30;
                            Console.WriteLine("La diferencia entre su fecha digitada {0} y fecha de hoy {1} son: {2} meses  ", fechaDigitada, fechaActual, meses);

                            float años = dias / 365;
                            Console.WriteLine("La diferencia entre su fecha digitada {0} y fecha de hoy {1} son: {2} años  ", fechaDigitada, fechaActual, años);
                        }
                        break;
                    case "Concat":
                        String cadena1 = "Hola";
                        String cadena2 = "mundo";
                        String ca = String.Concat(cadena1, " ", cadena2);
                        Console.WriteLine(ca);
                        break;
                    case "CompareTo":
                        String caden1 = "Hola";
                        String caden2 = "Hello";

                        String caden3 = "Mundo";
                        String caden4 = "Mundo";

                        Console.WriteLine($"La comparación entre {caden1} y {caden2} es: ");
                        int comparacion1 = caden1.CompareTo(caden2);
                        if (comparacion1 == 0)
                        {
                            Console.WriteLine("Las cadenas son iguales");
                        }
                        else if (comparacion1 == 1)
                        {
                            Console.WriteLine("Las cadenas no son iguales");
                        }

                        Console.WriteLine();
                        Console.WriteLine($"La comparación entre {caden3} y {caden4} es: ");
                        int comparacion2 = caden3.CompareTo(caden4);
                        if (comparacion2 == 0)
                        {
                            Console.WriteLine("Las cadenas son iguales");
                        }
                        else if (comparacion2 == 1)
                        {
                            Console.WriteLine("Las cadenas no son iguales");
                        }
                        break;
                    case "Equals":
                        String c1 = "Hola";
                        String c2 = "Hello";

                        String c3 = "Mundo";
                        String c4 = "Mundo";
                        Console.WriteLine($"La comparación entre {c1} y {c2} es:");
                        Console.WriteLine(c1.Equals(c2));
                        Console.WriteLine();
                        Console.WriteLine($"La comparación entre {c3} y {c4} es:");
                        Console.WriteLine(c3.Equals(c4));
                        break;
                    case "":
                        String Cadena1 = "Hola";
                        Console.Write("¿La palabra Hola contiene la letra H?: ");
                        Console.WriteLine(Cadena1.Contains("H"));

                        Console.WriteLine();

                        String Cadena2 = "Hello";
                        Console.Write("¿La palabra Hello contiene la letra S?: ");
                        Console.WriteLine(Cadena2.Contains("S"));
                        break;
                    case "Substring":
                        string C1 = "este es el ejercicio de substring";
                        Console.WriteLine(C1);
                        string C2 = C1.Substring(0, 4);
                        string C3 = C1.Substring(0, 7);
                        string C4 = C1.Substring(0, 10);
                        string C5 = C1.Substring(0, 21);
                        string C6 = C1.Substring(0, 23);
                        string C7 = C1.Substring(0, 33);

                        Console.WriteLine();

                        Console.WriteLine(C2);
                        Console.WriteLine(C3);
                        Console.WriteLine(C4);
                        Console.WriteLine(C5);
                        Console.WriteLine(C6);
                        Console.WriteLine(C7);
                        Console.WriteLine();
                        break;
                    case "EndsWith":
                        string palabra = "este es el ejercicio de Endswith";

                        Console.WriteLine(palabra);
                        Console.WriteLine(palabra.EndsWith("Endswith"));
                        Console.WriteLine(palabra.EndsWith("Ejercicio"));
                        break;
                    case "Insert":
                        string pa = "Ejercicio con metodo Insert";

                        Console.WriteLine(pa);
                        Console.WriteLine(pa.Insert(12, "**"));
                        Console.WriteLine(pa.Insert(4, "AQUI"));
                        Console.ReadLine();
                        break;
                    case "LastIndexOf":
                        string palabras = "este es el ejercicio de lastlndexof ";

                        Console.WriteLine(palabras);
                        int palabraa = palabras.LastIndexOf("ejercicio");
                        Console.WriteLine("lo encontre esta en la posicion: " + palabraa);
                        break;
                    case "PadLeft":
                        string p = " PadLeft ";

                        Console.WriteLine(p);
                        Console.WriteLine(p.PadLeft(20, '°'));
                        Console.ReadLine();
                        break;
                    case "PadRight":
                        string Algo = "Como estas";
                        char Signo = '?';

                        Console.WriteLine(Algo);
                        Console.WriteLine(Algo.PadRight(15, Signo));
                        Console.WriteLine(Algo.PadRight(20, Signo));
                        break;
                    case "Remove":
                        string a = "Hello my name is Juan, How are you?";

                        Console.WriteLine(a);
                        Console.WriteLine(a.Remove(21));
                        Console.WriteLine(a.Remove(5, 16));
                        break;
                    case "Replace":
                        string A = "Hello my name is Juan. Hello, How are you? Hello";

                        Console.WriteLine(A);
                        Console.WriteLine(A.Replace(' ', '-'));
                        Console.WriteLine(A.Replace("Hello", "Hola"));
                        break;
                    case "Split":
                        string Ag = "Hello, my name is Juan, Hello, How are you?";
                        string[] Vec = Ag.Split(' ');
                        string[] Vec2 = Ag.Split(' ', ',');

                        Console.WriteLine(Ag);
                        foreach (string vec in Vec)
                        {
                            Console.WriteLine(vec);
                        }
                        Console.WriteLine("-------------");
                        foreach (string vec1 in Vec2)
                        {
                            Console.WriteLine(vec1);
                        }
                        break;
                    case "ToLower":
                        string Al = "Hello, My Name Is Juan, Hello, How Are You?";

                        Console.WriteLine(Al + "\n");
                        Console.WriteLine(Al.ToLower());
                        break;
                    case "ToUpper":
                        string Ao = "Hello, my name is Juan, Hello, how are you?";

                        Console.WriteLine(Ao + "\n");
                        Console.WriteLine(Ao.ToUpper());
                        break;
                    case "Trim":
                        string j1 = " ABC";
                        string j2 = " ABC ";


                        Console.WriteLine("Antes");
                        Console.WriteLine(j1);
                        Console.WriteLine(j2);

                        Console.WriteLine("");


                        Console.WriteLine("Despues:");
                        Console.WriteLine(j1.Trim());
                        Console.WriteLine(j2.Trim());
                        break;
                    case "TrimStart":
                        string s1 = "***000000000000abc000****";

                        char[] charsToTrim1 = { '*', '0' };

                        string s2 = "  abc";
                        string s3 = "  -ABC-";

                        Console.WriteLine("Antes:");
                        Console.WriteLine(s1);
                        Console.WriteLine(s2);
                        Console.WriteLine(s3);

                        Console.WriteLine("");

                        Console.WriteLine("Despues:");

                        Console.WriteLine(s1.TrimStart(charsToTrim1));
                        Console.WriteLine(s2.TrimStart());
                        Console.WriteLine(s3.TrimStart('-'));
                        break;
                    case "Append":
                        string CaracterDefinitivo(char caracter, int tiempos)
                        {
                            StringBuilder constructora = new StringBuilder("");

                            for (int counter = 0; counter < tiempos; counter++)

                            {
                                constructora.Append(caracter);
                            }

                            return constructora.ToString();
                        }
                            break;
                    case "WriteLine":
                        StringBuilder ABC = new StringBuilder("Algo de algo");

                        Console.WriteLine("String contiene = " + ABC.ToString());
                        break;
                    case "AppendFormat":
                        break;
                    case "Tostring":
                        StringBuilder abc = new StringBuilder(" 10,20,30,40,50 ");

                        Console.WriteLine(" El string contiene los siguientes datos: " + abc.ToString());
                        Console.WriteLine(" Estos datos son verdaderos ");
                        break;
                    case "s":
                        inicio = false;
                        break;
                    default:
                        Console.WriteLine("No es un nombre de algun metodo");
                        break;
                }
            }

        }
    }
}