using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
 class Program
 {
 static void Main(string[] args)
 {
 int F = 0;
 int C = 0;
 int N = 0;
 int MAY = 0;
 int MEN = 0;
 string linea;

 Console.Write("TAMAÑO DE LA MATRIZ:");
 Random rnd = new Random();
 linea = Console.ReadLine();
 N = int.Parse(linea);
 int[,] MAT = new int[N + 1, N + 1];
 for (F = 1; F <= N; F++)
 {
 for (C = 1; C <= N; C++)
 {
 MAT[F, C] = rnd.Next(0, 99);
Console.SetCursorPosition(C * 4, F + 1);
Console.Write(MAT[F, C]);
 }
 }
 }