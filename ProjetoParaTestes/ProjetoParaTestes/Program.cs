using System;
using System.Diagnostics;
using System.Threading;

namespace Aula
{
    public class Exemplo
    {
        static void Main(string[] args)
        {
            var cronometros = new Stopwatch[4];
            cronometros[0] = new Stopwatch();
            cronometros[1] = new Stopwatch();
            cronometros[2] = new Stopwatch();
            cronometros[3] = new Stopwatch();

            var task1 = new Task<int>(() =>
            {
                int quantidade = CalcularPrimos(5000);
                cronometros[0].Stop();
                return quantidade;
            });
            var task2 = new Task<int>(() =>
            {
                int quantidade = CalcularPrimos(10000);
                cronometros[1].Stop();
                return quantidade;
            });
            var task3 = new Task<int>(() =>
            {
                int quantidade = CalcularPrimos(15000);
                cronometros[2].Stop();
                return quantidade;
            });
            var task4 = new Task<int>(() =>
            {
                int quantidade = CalcularPrimos(20000);
                cronometros[3].Stop();
                return quantidade;
            });

            cronometros[3].Start();
            task3.Start();
            cronometros[2].Start();
            task2.Start();
            cronometros[1].Start();
            task1.Start();
            
            Task.WhenAll(task1, task2, task3).Wait();
            cronometros[3].Stop();

            Console.WriteLine("Conjunto finalzado em tempo real:" + cronometros[3].Elapsed.TotalSeconds);
            Console.WriteLine($"Tempo da Task1: {cronometros[0].Elapsed.TotalSeconds}, Resultado {task1.Result}");
            Console.WriteLine($"Tempo da Task2: {cronometros[1].Elapsed.TotalSeconds}, Resultado {task2.Result}");
            Console.WriteLine($"Tempo de Task3: {cronometros[2].Elapsed.TotalSeconds}, Resultado {task3.Result}");
        }
        public static int CalcularPrimos(int intervalo)
        {
            var rangeValores = Enumerable.Range(2, intervalo);
            var quantidade = rangeValores.Count(v => Enumerable.Range(2, (int)Math.Sqrt(v) -
                1).All(i => v % i > 0));
            return quantidade;
        }
    }

    public class ExemploThread
    {
        public void ExemploThread1()
        {
            Thread t1 = new Thread(Worker1);
            t1.Start();

            int contador1 = 0;
            for (int i = 0; i < 10000; i++)
            {
                contador1++;
                Console.WriteLine($"Main {contador1} ");
            }
            Console.WriteLine($"CONTADOR MAIN {contador1}");
        }

        public void Worker1()
        {
            int contador2 = 0;
            for (int i = 0; i < 10000; i++)
            {
                contador2++;
                Console.WriteLine($"C# {contador2}");
            }
            Console.WriteLine($"CONTADOR C# {contador2}");
        }

    }
}