using System;

namespace AulaPratica1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world - AULA PRÁTICA 1 - C#");
            var hifen = new string('-', 35);
            Console.WriteLine(hifen);

            int inteiro = 10;
            Console.WriteLine(inteiro);
            decimal valor = 8669985222221148555M;
            Console.WriteLine(valor);

            Console.WriteLine(hifen);
            object obj1 = new object();
            object obj2 = new object();
            var obj3 = new object();

            var obj4 = obj1;
            Console.WriteLine("Comparando o tipo do objeto");
            Console.WriteLine($"{obj1.GetType().Name} - {obj2.GetType()} - {obj3.GetType()} - {obj4.GetType()}");

            Console.WriteLine(hifen);

            var s1 = new string('a', 5);
            string s2 = new string(new char[5] {'a', 'a', 'a', 'a', 'a'});
            Console.WriteLine($"{s1 == s2}");
            string s3 = string.Concat((new char[5] { 'a', 'a', 'a', 'a', 'a' }).AsEnumerable());
            Console.WriteLine(s3 );

            Console.WriteLine(hifen);

            var compareString = new CompareStrings()
            {
                testaComparacao = "1234"
            };
            var compareString2 = new CompareStrings()
            {
                testaComparacao = "1234"
            };
            Console.WriteLine($"{compareString == compareString2}");
            Console.WriteLine($"{compareString.testaComparacao == compareString2.testaComparacao}");
            Console.WriteLine(compareString.Equals(compareString2));

            Console.WriteLine(hifen);
            ClasseComplexa classeComplexa = new ClasseComplexa();
            classeComplexa.PropInterface = "123";
            IImprimirValores interfaceX = classeComplexa;
            Console.WriteLine($"{interfaceX.PropInterface}");
        }
    }
}