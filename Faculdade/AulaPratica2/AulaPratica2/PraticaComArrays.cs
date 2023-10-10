using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPratica2
{
    class PraticaComArrays
    {
        public void ExercicioUsandoArrays()
        {
            int[] arrayIntLinear = new int[100000];
            foreach(int array in  arrayIntLinear)
            {
                arrayIntLinear[array] = array;
            }

            int[,] matriz = new int[100, 100];
            var random = new Random();
            foreach(int i in matriz)
            {
                foreach (int j in matriz)
                {
                    matriz[i, j] = random.Next(1, 300000);
                }
            }

            int countMatch = 0;
            for (int i = 0; i < matriz.GetUpperBound(0); i++) 
            { 
                for (int k = 0; i < matriz.GetUpperBound(1); k++)
                {
                    var valorMatriz = matriz.GetValue(i, k);
                    for (int x = 0; x < arrayIntLinear.Length; x++)
                    {
                        if (arrayIntLinear[x].Equals(valorMatriz))
                        {
                            countMatch++;
                        }
                    }
                }
            }
            Console.WriteLine($"Houveram: {countMatch} entre os valores do Random da matriz" +
                              $"e do array.");
        }
    }
}
