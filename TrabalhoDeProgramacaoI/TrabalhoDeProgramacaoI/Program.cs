using System;

namespace TrabalhoDeProgramacaoI
{
    public class ExercicioI
    {
        static void Main(string[] args)
        {
            // Darley, RU: 4102341

            //Exercício I - Equação de Bhaskara

            // Será pedido 3 valores de entrada ao usuário,
            // que serão armazenados nas váriaveis A, B e C

            Console.WriteLine("Digite o primeiro número do seu RU");
            double a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número do seu RU");
            double b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número do seu RU");
            double c = int.Parse(Console.ReadLine());

            // delta recebe o resultado da equação
            double delta = (b * b) - (4 * a * c);

            if (a == 0) // O valor de A precisa ser diferente de 0
            {
                Console.WriteLine($"O valor de A não pode ser igual a 0");
            }
            else if (delta < 0) // Delta não pode ter o seu valor menor que 0
            {
                Console.WriteLine("Valor impossível de calcular");
            }
            else
            {
                // Se todos os parâmetros estiverem corretos é efetuado o cálculo de X1 e X2
                // Função Math.Sqrt() efetua o cálculo da raiz quadrada,
                // no caso do exemplo recebe delta como parâmetro

                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"X1: {x1}, X2: {x2}"); // Impresão do resultado da equação
            }
        }
    }
}