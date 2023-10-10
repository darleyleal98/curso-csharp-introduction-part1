using System;
using System.Globalization;
using System.Collections.Generic;

namespace PrimeiroProjeto
{
    public class Program
    {
        static void Main(string[] args)
        {
            Generics<int, int> generics = new Generics<int, int>();

            int numero = 2;
            int numero2 = 3;

            generics.Compara(numero2, numero);
        }
    }
}
