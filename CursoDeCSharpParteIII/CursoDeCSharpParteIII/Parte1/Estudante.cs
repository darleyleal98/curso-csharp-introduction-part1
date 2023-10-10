using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDeCSharpParteIII;
using CursoDeCSharpParteIII.Parte1;

#pragma warning disable

namespace CursoDeCSharpParteIII.Parte1
{
    public class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Estudante(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString()
        {
            return $"\nQuartos ocupados: \n" +
                   $"{Quarto}: Nome: {Nome}, E-mail: {Email}\n";
        }
    }
}
