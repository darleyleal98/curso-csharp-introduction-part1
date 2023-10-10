using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;
using CursoDeCSharpeParteIII;
using CursoDeCSharpParteIII.Parte1;

namespace CursoDeCSharpParteIII.Parte1
{
    public class Funcionario
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private double Salario { get; set; }
        private static int contador = 1;
        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public Funcionario() { }

        public void IncrementaValorAoSalario(double valorDaPorcentagem)
        {
            Salario += Salario * (valorDaPorcentagem / 100);
        }

        public override string ToString()
        {
            return $"Id: {Id}\n" +
                   $"Nome: {Nome}\n" +
                   $"Salário: {Salario:c}\n";
        }

        public void FuncionarioTeste()
        {
            Console.WriteLine("Quantos funcionários serão cadastrados?");
            int quantidadeFuncionarios = int.Parse(Console.ReadLine());

            List<Funcionario> listaDeFuncionarios = new List<Funcionario>();

            for (int i = 0; i < quantidadeFuncionarios; i++)
            {
                Console.WriteLine("Digite o ID:");
                int idFuncionario = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Nome:");
                string nomeFuncionario = Console.ReadLine();

                Console.WriteLine("Digite o salário:");
                double salarioFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Verifica se outro funcionário foi registrado com o mesmo ID
                if (listaDeFuncionarios.Any(x => x.Id == idFuncionario))
                {
                    Console.WriteLine("Funcionário com o mesmo ID já existe na lista.");
                }
                else
                {
                    listaDeFuncionarios.Add(new Funcionario(idFuncionario,
                                                            nomeFuncionario,
                                                            salarioFuncionario
                                                            ));
                }
            }
            listaDeFuncionarios.ForEach(funcionario => Console.WriteLine($"Funcionário #{contador++}: \n" +
                                                                         $"{funcionario.ToString()}"));

            Console.WriteLine("Digite o ID do funcionário que receberá o aumento:");
            int id = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a porcentagem do aumento:");
            int valorDaPorcentagem = int.Parse(Console.ReadLine());

            foreach (Funcionario funcionario in listaDeFuncionarios)
            {
                if (funcionario.Id == id)
                {
                    funcionario.IncrementaValorAoSalario(valorDaPorcentagem);
                }
            }

            listaDeFuncionarios.ForEach(funcionario => Console.WriteLine($"Lista de funcionários atualizada: \n" +
                                                                         $"{funcionario.Id}, {funcionario.Nome}, {funcionario.Salario}"));
        }
    }
}
