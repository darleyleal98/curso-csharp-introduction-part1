using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDeProgramacaoI.ExercicioII
{
    public class Produto
    {
        /// <summary>
        /// Foram criados 3 atributos privados: _name, _preco e _quantidade
        /// e 3 propriedades públicas, assim consegui atribuir valores às propriedades 
        /// fora da sua classe mãe sem acessar diretamente aos atributos,
        /// usando lambdas para atribuir os dados aos get e set.
        /// </summary>

        private string _nome;
        public string Nome 
        { 
          get => _nome;
          set => _nome = value;
        }
        private double _preco;
        public double Preco
        {
            get => _preco;
            set => _preco = value;
        }
        private int _quantidade;
        public int Quantidade
        {
            get => _quantidade;
            set => _quantidade = value;
        }

        // Sobrescrita do método ToString para imprimir
        // os valores atribuidos aos objetos formatados.

        public override string ToString()
        {
            return $"Nome do produto: {Nome}\n" +
                   $"Preço: {Preco:c} \n" +
                   $"Quantidade: {Quantidade}";
        }

        // Método faz a multiplicação da quantidade pelo valor.
        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        // Adiciona mais unidades ao objeto
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        // Remove unidades do objeto
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
    }
}

namespace TrabalhoDeProgramacaoI.ExercicioII 
{ 
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Darley - RU: 4102341\n");
            
            // Novo objeto estoque do tipo produto é criado,
            // será usado para atribuir valores e manipular os dados.

            var estoque = new Produto();
            estoque.Nome = "TV";
            estoque.Preco = 900.00;
            estoque.Quantidade = 10;

            // 1º Exemplo: Impressão padrão.
            Console.WriteLine($"{estoque.ToString()}");
            Console.WriteLine($"{estoque.Quantidade} unidades");
            Console.WriteLine($"Total: {estoque.ValorTotalEmEstoque():c}\n");

            // 2º Exemplo: Impressão adicionando o último número do meu RU: 1.
            Console.WriteLine("Dados atualizados com último número do RU:");
            estoque.AdicionarProduto(1);
            Console.WriteLine($"{estoque.ToString()}");
            Console.WriteLine($"{estoque.Quantidade} unidades");
            Console.WriteLine($"Total: {estoque.ValorTotalEmEstoque():c}\n");

            // 3º Exemplo: Impressão adicionando mais 4 unidades
            Console.WriteLine("Dados atualizados:");
            estoque.AdicionarProduto(4);
            Console.WriteLine($"{estoque.ToString()}");
            Console.WriteLine($"{estoque.Quantidade} unidades");
            Console.WriteLine($"Total: {estoque.ValorTotalEmEstoque():c}\n");

            // 4º Exemplo: Impressão com remoção de 3 unidades.
            Console.WriteLine("Dados atualizados com remoção de 3 produtos:");
            estoque.RemoverProdutos(3);
            Console.WriteLine($"{estoque.ToString()}");
            Console.WriteLine($"{estoque.Quantidade} unidades");
            Console.WriteLine($"Total: {estoque.ValorTotalEmEstoque():c}\n");
        }
    }
}