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
        int[,] marco;
        int CF = 5;
        int CC = 15;
        
            Marco = new int[CF, CC];

            for (int f = 0; f < marco.GetLength(0); f++)
            {
                if(f==0 || f==4){
                    for (int c = 0; c < marco.GetLength(1); c++)
                    {
                        Console.Write("1 ");
                    }
                }else{
                    for (int c = 0; c < marco.GetLength(1); c++)
                    {
                        if(c==0 || c==14)
                        {
                        Console.Write("1 ");
                        }
                        else
                        {
                        Console.Write("0 ");
                        }
                    }
                }
                Console.WriteLine();            
        }
    }
}
