using System;

namespace AulaPratica4
{
    public class Pricipal
    {
        static void Main()
        {
            Console.WriteLine("EXERCÍCIO 1, AULA 4 - C#");
            ThreadPing thread = new ThreadPing();
            thread.StartPing();
            thread.ExecutePing();
        }
    }
}