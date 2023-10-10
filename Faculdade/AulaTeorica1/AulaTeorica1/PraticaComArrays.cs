using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaTeorica2
{
    class PraticaComArrays
    {
        public void Exercicio1()
        {
            var separaExerciciosComHifen = new string('-', 35);
            Console.WriteLine(separaExerciciosComHifen);

            int[] arrayIntLinear = new int[100000];
            for (int i = 0; i < arrayIntLinear.Length; i++)
            {
                arrayIntLinear[i] = i;
            }
            int[,] matriz = new int[100, 100];
            var random = new Random();

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    matriz[i, j] = random.Next(1, 300000);
                }
            }
            int countMatch = 0;
            for (int k = 0; k < matriz.GetUpperBound(0); k++)
            {
                for (int j = 0; j < matriz.GetUpperBound(1); j++)
                {
                    var valorMatriz = (int)matriz.GetValue(k, j);
                    for (int x = 0; x < arrayIntLinear.Length; x++)
                    {
                        if (arrayIntLinear[x] == valorMatriz)
                        {
                            countMatch++;
                        }
                    }
                }
            }
            Console.WriteLine($"Houveram: {countMatch} entre os valores" +
                              $" randômicos da matriz e do array");
        }
        public void Exercicio2()
        {
            var separaExerciciosComHifen = new string('-', 35);
            Console.WriteLine(separaExerciciosComHifen);

            char[] alfabetoArray = new char[]
            { 
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
                'J', 'K', 'L', 'M', 'N', 'O', 'P', 'R', 'S',
                'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };

            char[] arrayCharAleatorio = new char[100];
            char[] arrayFinal = new char[100];
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                arrayCharAleatorio[i] = alfabetoArray[random.Next(0, alfabetoArray.Length)];
            }
            int posicaoInicial = 0;
            int posicaoFinal = 0;

            Console.WriteLine("Informe um valor inicial para recortar do Array original: ");
            posicaoInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe um valo inicial (maior que o valor anterior) " +
                              "para recotar do Array: ");
            posicaoFinal = int.Parse(Console.ReadLine());

            for (int i = posicaoInicial; i < posicaoFinal; i++)
            {
                arrayFinal[i] = arrayCharAleatorio[i];
            }
            var stringFinal = new string(arrayFinal);
            Console.WriteLine($"A string final ficou assim: {stringFinal}");
        }
    }
}
