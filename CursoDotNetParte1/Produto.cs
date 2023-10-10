using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Reflection.Metadata;
using CursoDeCSharpParteIII;
using CursoDeCSharpParteIII.Parte1;

#pragma warning disable

namespace CursoDeCSharpParteIII.Parte1
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public Produto() { }

        public void ProdutoTeste()
        {
            Console.WriteLine("Digite a quantidade de repetições: ");
            int repeticoes = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double soma = 0.0;

            Produto[] listaDeProdutos = new Produto[repeticoes];

            for (int i = 0; i < repeticoes; i++)
            {
                Console.WriteLine("Digite nome e preço do produto:");
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());

                listaDeProdutos[i] = new Produto(nome, preco);
            }
            for (int i = 0; i < listaDeProdutos.Length; i += 1)
            {
                soma += listaDeProdutos[i].Preco;
            }
            Console.WriteLine($"Média: {soma / repeticoes:c}");
        }
    }
}
