using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] horas = new int[1];
			horas[1] = 24;

			int[] dias = new int[4];
			dias[1] = 31;
			dias[2] = 30;
			dias[3] = 28;

			int[] meses = new int[13];
			meses[1] = dias[1];
			meses[2] = dias[3];
			meses[3] = dias[1];
			meses[4] = dias[2];
			meses[5] = dias[1];
			meses[6] = dias[2];
			meses[7] = dias[1];
			meses[8] = dias[1];
			meses[9] = dias[2];
			meses[10] = dias[1];
			meses[11] = dias[2];
			meses[12] = dias[1];

			int mes = 0;
			Console.WriteLine("escriba el evento que ocurrio");
			meses[mes] = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("El mes número {0} tiene {1} dias y en la hora {2} ocurrio:", meses[mes],horas);
		}
    }
}
