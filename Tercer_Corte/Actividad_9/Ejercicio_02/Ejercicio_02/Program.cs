using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    public class Operacion
    {

        protected int v1;
        protected int v2;
        protected int v3;
        protected double v4;
        protected int resultado;

        public int Valor1
        {
            set
            {
                v1 = value;
            }
            get
            {
                return v1;
            }
        }
        public int Valor2
        {
            set
            {
                v2 = value;
            }
            get
            {
                return v2;
            }
        }


        public int Valor3
        {
            set
            {
                v3 = value;
            }
            get
            {
                return v3;
            }
        }
        public double Valor4
        {
            set
            {
                v4 = value;
            }
            get
            {
                return v4;
            }
        }

        public int Resultado
        {
            protected set
            {
                resultado = value;
            }
            get
            {
                return resultado;
            }
        }
    }


    public class Suma : Operacion
    {
        public void Operar()
        {
            Resultado = V1 + V2;
        }
    }


    public class Resta : Operacion
    {
        public void Operar()
        {
            Resultado = V1 - V2;
        }
    }
    public class multiplicacion : Operacion
    {
        public void Operar()
        {
            Resultado = V1 * V2;
        }
    }
    public class division : Operacion
    {
        public void Operar()
        {
            Resultado = V1 / V2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Suma suma1 = new Suma();
            suma1.V1 = 10;
            suma1.V2 = 7;
            suma1.Operar();
            Console.WriteLine("La suma de " + suma1.V1 + " + " + suma1.V2 + " = " + suma1.Resultado);

            Resta resta1 = new Resta();
            resta1.V1 = 8;
            resta1.V2 = 4;
            resta1.Operar();
            Console.WriteLine("La resta de " + resta1.V1 + " - " + resta1.V2 + " = " + resta1.Resultado);

            multiplicacion multiplicacion1 = new multiplicacion();
            multiplicacion1.V1 = 9;
            multiplicacion1.V2 = 78;
            multiplicacion1.Operar();
            Console.WriteLine("La multiplicacion  de " + multiplicacion1.V1 + " * " + multiplicacion1.V2 + " = " + multiplicacion1.Resultado); 

            division division1 = new division();
            division1.V1 = 78;
            division1.V2 = 6;
            division1.Operar();
            Console.WriteLine("La division de " + division1.V1 + " / " + division1.V2 + " = " + division1.Resultado);

            Console.ReadKey();
        }
    }
}
