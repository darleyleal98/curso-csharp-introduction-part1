using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Pessoa
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public char Genero { get; set; }
        public int Idade()
        {
            return DateTime.Today.Year - DataDeNascimento.Year;
        }
        public double Altura { get; set; }
        public string Faculdade { get; set; }

        public Pessoa(int codigo, string nome, char genero, DateTime dataDeNascimento,
                      double altura, string faculdade)
        {
            Codigo = codigo;
            Nome = nome;
            Genero = genero;
            DataDeNascimento = dataDeNascimento;
            Altura = altura;
            Faculdade = faculdade;
        }

        public override string ToString() =>
            $"Código:{Codigo}\nNome: {Nome}\nData de nascimento:{DataDeNascimento}\n" +
            $"Altura:{Altura}\nFaz faculdade de:{Faculdade}";
    }
}
