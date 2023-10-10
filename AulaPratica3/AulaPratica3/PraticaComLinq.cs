using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPratica3
{
    public class PraticaComLinq
    {
        public void Exercicio1()
        {
            string[] nomes = 
            { "João", "Darley", "Ana", "Maria", "Paulo",
              "Antônio", "Joana", "Matheus", "Alan", "Julia", "Max" 
            };
            string[] materias =
            {
                "Programação I", "Algoritmos II", "Redes",
                "Cálculo II", "Sistemas Operacionais"
            };
            Random randon = new Random();
            List<Avaliacao> avaliacoes = new List<Avaliacao>();

            foreach (var nomeEstudante in nomes) 
            { 
                foreach (var materia in materias)
                {
                    var avaliacao = new Avaliacao()
                    {
                        Nome = materia,
                        NomeAluno = nomeEstudante,
                        Nota = decimal.Parse($"{randon.Next(0, 10)}, {randon.Next(0, 10)}")
                    };
                    avaliacoes.Add( avaliacao );
                }
            }
            var queryEstudantes = from nome in nomes
                                  let avaliacoesEstudantes = (from avaliacao in avaliacoes
                                                              where avaliacao.Nome == nome
                                                              select avaliacao).ToList()
                                  select new Estudante()
                                  {
                                      Avaliacoes = avaliacoesEstudantes,
                                      Nome = nome,
                                      Media = avaliacoesEstudantes.Average(x => x.Nota)
                                  };

            var estudantesList = queryEstudantes.ToList();
            var estudanteMaiorNota = estudantesList.SelectMany(e => e.Avaliacoes)
                                                   .Where(a => a.Nome == "Programação I")
                                                   .OrderByDescending(x => x.Nota)
                                                   .Select(a => a.NomeAluno);
        }
    }
}
