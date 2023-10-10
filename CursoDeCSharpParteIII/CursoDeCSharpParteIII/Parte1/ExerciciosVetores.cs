using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using CursoDeCSharpParteIII;
using CursoDeCSharpParteIII.Parte1;

#pragma warning disable

namespace CursoDeCSharpParteIII.Parte1
{
    public class ExerciciosVetoresI
    {
        public void VetoresTeste()
        {
            Console.WriteLine("Digite a quantidade de repetições: ");

            int numero = int.Parse(Console.ReadLine());

            double soma = 0.0;

            double[] vetor = new double[numero];

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("Digite uma altura: ");
                double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vetor[i] = altura;
            }
            foreach (var valor in vetor)
            {
                soma += valor;
            }
            Console.WriteLine($"A média das alturas é: {(soma / numero).ToString("F2")}");
        }
    }
}
