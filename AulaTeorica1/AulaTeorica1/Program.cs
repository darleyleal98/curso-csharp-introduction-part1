using AulaTeorica2;
using System;

namespace AulaPratica2
{
    class Program
    {
        static void Main()
        {
            PraticaComArrays exercicio = new PraticaComArrays();
            exercicio.Exercicio1();
            exercicio.Exercicio2();

            Console.WriteLine();
            PraticaComFilasBoxing exercicio2 = new PraticaComFilasBoxing();
            exercicio2.ExercicioBoxingFilas();
            PraticaManipulandoCollections exercicio3 = new PraticaManipulandoCollections();
            exercicio3.Exercicio();
        }
    }
}