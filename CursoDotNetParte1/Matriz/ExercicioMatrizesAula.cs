using System;

namespace CursoCSharpUdemy.Matriz
{
    public class ExercicioMatrizesAula
    {
        public void TesteMatrizes()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }
            Console.WriteLine("Main diagonal:");

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        count++;
                    }   

                    Console.Write($"{matriz[i, j]} ");  
                }
            }
            Console.WriteLine($"\nNegative numbers: {count}");
        }
    }
}
