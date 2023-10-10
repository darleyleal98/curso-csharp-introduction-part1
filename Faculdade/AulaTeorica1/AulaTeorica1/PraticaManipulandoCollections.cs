using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaTeorica2
{
    class PraticaManipulandoCollections
    {
        public void Exercicio()
        {
            var arrayBase = new int[50];
            for (int i = 0; i < arrayBase.Length; i++)
            {
                arrayBase[i] = i;
            }

            IEnumerable<int> enumerable = arrayBase;
            IList<int> lista = arrayBase;
            ICollection<int> collection = arrayBase;

            foreach (var item in enumerable)
            {
                Console.WriteLine($"Item enumerable: {item}");
            }
            foreach (var item in lista)
            {
                Console.WriteLine($"Item lista: {item}");
            }
            foreach (var item in collection)
            {
                Console.WriteLine($"Item collection: {item}");
            }
            int countAux = 0;
            foreach (var item in enumerable)
            {
                countAux++;
            }
            Console.WriteLine($"Quantidade Enumerable: {countAux}");
            Console.WriteLine($"Quantidade Lista: {lista.Count()}");
            Console.WriteLine($"Quantidade Collection: {collection.Count()}");
            int countAux2 = 0;
            foreach (var item in enumerable)
            {
                if (countAux2 == 30)
                {
                    Console.WriteLine($"Item 30 Enumerable: {item}");
                    break;
                }
                countAux2++;
            }
            Console.WriteLine($"Item 30 da lista: {lista[30]}");
            int countAux3 = 0;
            foreach (var item in collection)
            {
                if (countAux3 == 30)
                {
                    Console.WriteLine($"Item 30 da Collection: {item}");
                    break;
                }
                countAux3++;
            }
        }
    }
}
