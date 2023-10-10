using System;

namespace TrabalhoProgramacaoI
{
    public class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Digite o valor para a letra A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor para a letra B:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor para a letra C:");
            int c = int.Parse(Console.ReadLine());

            double delta = (b * b) - (4 * 4 * c);

            if (a == 0)
            {
                Console.WriteLine("O valor de A precisa ser diferente de 0");
            }
            else if (delta < 0)
            {
                Console.WriteLine("Impossível calcular o valor de delta.");
            }
            else
            {
                double x1 = (- b + (Math.Sqrt(delta)) / (2 * a));
                double x2 = (+ b + (Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine($"Valor de X1: {x1}\nValor de X2: {x2}");
            }
        }
    }
}