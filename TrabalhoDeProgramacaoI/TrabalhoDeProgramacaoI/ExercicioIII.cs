using System;
using System.Collections.Generic;
using System.Threading;

namespace TrabalhoDeProgramacaoI.ExercicioIII
{
    public class PrimeNumber
    {
        /// Método EncontraNumeroPrimo() vai receber um valor inteiro como parâmetro,
        /// e fará verificações se esse número é primo, se o valor
        /// for menor que 2 ou o resto da sua divisão por 2 for igual a 0
        /// ele retorna False.
        
        public bool EncontraNumeroPrimo(int numero)
        {
            if (numero < 2)
            {
                return false;
            }
            if (numero == 2)
            {
                return true;
            }
            if (numero % 2 == 0)
            {
                return false;
            }

            // Faz a verificação se o número possui raiz quadrada
            // e será convertido para um número inteiro
            // que será usado como valor limite dentro do laço for.
            // Se o valor incrementado for dividido por numero e seu
            // resto for igual a 0 ele retorna false, senão sai do loop
            // e toda verificação do método é verdadeira, retornando true.

            int raiz = (int)Math.Sqrt(numero);
            for (int i = 3; i <= raiz; i += 2)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

    public class Program
    {
        static void Main()
        {
            // Objeto do tipo PrimeNumber é criado, e será usado
            // quando for necessário usar a função EncontraNumeroPrimo

            var exercicioThreads = new PrimeNumber();

            // 2 últimos números do meu RU: 4102341
            int ru = 41;
            
            // Lista armazenará os números primos
            List<int> primeNumbersList = new List<int>();
            object lockObject = new object();

            // Uma lista será criada para armazenar as Threads.
            List<Thread> threads = new List<Thread>();

            // Será criado uma nova Thread para cada 10 valore e um novo processor será diparado para cada uma delas
            for (int inicio = 2; inicio <= ru; inicio += 10)
            {
                int inicioFaixa = inicio;
                int fimFaixa = Math.Min(inicio + 9, ru);
                
                //Nova Thread é criada
                Thread thread = new Thread(() =>
                {
                    for (int numero = inicioFaixa; numero <= fimFaixa; numero++)
                    {
                        // Se o número passado como parâmetro que foi verificado
                        // pelo método retornar true, ou seja for primo, ele será
                        // adicionado a lista.

                        if (exercicioThreads.EncontraNumeroPrimo(numero))
                        {
                            lock (lockObject)
                            {
                                primeNumbersList.Add(numero);
                            }
                        }
                    }
                });

                // Será adicionado uma nova Thread a lista.
                threads.Add(thread);

                // Método Start inicializa a Thread.
                thread.Start();
            }

            // Espera a execução de uma Thread até que a outra termine.
            foreach (var thread in threads)
            {
                thread.Join();
            }

            // Ordena a lista de números primos.
            primeNumbersList.Sort();

            // Faz a impressão de todos os números primos armazenados na lista até 41.
            Console.WriteLine($"Números primos até {ru}: ");
            foreach (var primeNumber in primeNumbersList)
            {
                Console.Write(primeNumber + " ");
            }
        }
    }
}
