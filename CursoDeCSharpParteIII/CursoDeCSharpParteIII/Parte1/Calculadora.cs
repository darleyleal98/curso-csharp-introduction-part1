using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDeCSharpParteIII;
using CursoDeCSharpParteIII.Parte1;

namespace CursoDeCSharpParteIII.Parte1
{
    public class Calculadora
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            for (int number = 0; number < numbers.Length; number++)
            {
                sum += numbers[number];
            }
            return sum;
        }
        public static int Triple(ref int x)
        {
            return x * 3;
        }
        public static void TripleWithOut(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
