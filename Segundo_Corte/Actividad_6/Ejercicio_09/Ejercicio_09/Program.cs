using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Program
    {
        static void Mostrar(ArrayList Arreglo)
        {
            foreach(int n in Arreglo){
                Console.WriteLine(n);
            }
            Console.WriteLine("--------------");
        }
        static void Main(string[] args)
        {
            ArrayList Lista1=new ArrayList();
            Console.Write("Digite el tamaño del arraylist: ");
            int m=int.Parse(Console.ReadLine());
             for(int j=0;j<m;j++){
                Console.Write($"Digite el elemento {j+1}: ");
                int Valor=int.Parse(Console.ReadLine());
                Lista1.Insert(j,Valor);
            }
            Mostrar(Lista1);
    }
}
