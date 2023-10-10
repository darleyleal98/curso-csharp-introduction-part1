using System;
using CursoDeCSharpParteIII;
using CursoDeCSharpParteIII.Parte1;
#pragma warning disable

namespace CursoDeCSharpParteIII.Parte1
{
    public class Pensionato
    {
        public void PensionatoDeEstudantesTeste()
        {
            Estudante[] pensionato = new Estudante[10];

            Console.WriteLine("Quantos estudantes farão o registro? ");
            int quantidadeRegistroEstudantes = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeRegistroEstudantes; i++)
            {
                Console.WriteLine("Digite seu nome e e-mail:");
                string nomeEstudante = Console.ReadLine();
                string emailEstudante = Console.ReadLine();

                Console.WriteLine("Qual quarto você deseja? 1 - 10");
                int numeroQuartoEstudante = int.Parse(Console.ReadLine());

                if (numeroQuartoEstudante >= 1 && numeroQuartoEstudante <= 10)
                {
                    pensionato[numeroQuartoEstudante - 1] = new Estudante(nomeEstudante, emailEstudante, numeroQuartoEstudante);

                    Console.WriteLine($"Quartos ocupados: \n" +
                                      $"{numeroQuartoEstudante}: " +
                                      $"Nome: {nomeEstudante}," +
                                      $" E-mail: {emailEstudante}");
                }
                else
                {
                    Console.WriteLine("Número de quarto inválido. O quarto deve estar entre 1 e 10.");
                }
            }
            Estudante[] estudantes = pensionato.Where(estudante => estudante != null).ToArray();

            Array.Sort(estudantes, (estudante1, estudante2) => estudante1.Quarto.CompareTo(estudante2.Quarto));
            int contador = 1;
            foreach (var estudante in estudantes)
            {
                Console.WriteLine($"\nRENT #{contador}:" +
                                      $"\n{estudante.ToString()}");
                contador++;
            }
        }
    }
}
