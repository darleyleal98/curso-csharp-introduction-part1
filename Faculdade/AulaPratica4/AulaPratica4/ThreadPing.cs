using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AulaPratica4
{
    public class ThreadPing
    {
        private string endereco = "google.com";
        int countPing = 0;
        bool executePing = false;
        public void StartPing()
        {
            Console.WriteLine("Digite S a qualquer momento para interomper");
            var threadPingger = new Thread(ExecutePing);
            threadPingger.Start();
            executePing = true;
            var comandoSair = "S";
            var comando = string.Empty;
            while (!comandoSair.Equals(comando)) 
            {
                comando = Console.ReadLine();
            }
            executePing = false;
            while (threadPingger.IsAlive)
            {
                Console.WriteLine("Esperando finalizar");
            }
            Console.WriteLine("Thread Finalizada.");
        }
        public void ExecutePing()
        {
            while (executePing)
            {
                Ping pingger = new Ping();
                var pingResponse = pingger.Send(endereco);
                Console.WriteLine($"Ping: {countPing}, Endereço: {endereco} | " +
                                  $"Status: {pingResponse.RoundtripTime} ms");
                countPing++;
                Thread.Sleep(2000);
            }
        }
    }
}
