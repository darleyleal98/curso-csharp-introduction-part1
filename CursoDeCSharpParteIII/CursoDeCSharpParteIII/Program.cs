using CursoDeCSharpParteIII;
using System;

namespace CursoDeCSharpeParteIII
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[,] data = new double[2, 6];

            Console.WriteLine(data.Rank);
            Console.WriteLine(data.Length);
        }
    }
}