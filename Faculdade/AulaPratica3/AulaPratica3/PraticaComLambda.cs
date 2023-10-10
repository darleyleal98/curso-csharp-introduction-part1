using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AulaPratica3
{
    class PraticaComLambda
    {
        public void Exercicio1()
        {
            Action<DateTime> lamda1 = (DateTime data) => Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm:ss"));
            lamda1(new DateTime(2010, 05, 27));
            lamda1(new DateTime(2001, 09, 07, 10, 05, 30));

            Func<int, int> lambda2 = (int valor) =>
            {
                return valor = 1;
            };
            Console.WriteLine(lambda2(5));
            Console.WriteLine(lambda2(10));

            Func<object, object, string> lambda3 = (object elemento, object elemento2) =>
            {
                return $"{elemento}, {elemento2}";
            };
            Console.WriteLine(lambda3("Nota: ", 10));
            Console.WriteLine(lambda3(11, 0.5M));

            var formataSeparacaoExercicios = new string('-', 35);
            Console.WriteLine(formataSeparacaoExercicios);

            var arrayBase = new int[10];
            for (int i = 0; i < arrayBase.Length; i++)
            {
                arrayBase[i] = i;
            }
            IEnumerable<int> enumerable = arrayBase;
            var arrayBase5 = new int[5] { 5, 10, 15, 20, 25 };
            Func<IEnumerable<int>, IEnumerable<int>, IEnumerable<int>> multiplicaValores =
            (IEnumerable<int> vetor1, IEnumerable<int> vetor2) =>
            {
                List<int> result = new List<int>(vetor2.Count());
                foreach (var item in vetor1)
                {
                    result.Add(vetor2.Sum(x => x * item));
                }
                return result;
            };
            var result = multiplicaValores(arrayBase, arrayBase5);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
