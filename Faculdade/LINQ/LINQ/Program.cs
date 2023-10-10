using System;
using System.Globalization;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var listaValores = new List<int>();

            for (int i = 0; i < 21; i++)
            {
                listaValores.Add(i);
            }
            var listaFiltradaComWhere = listaValores.Where(p => p > 5);
            var elementos = listaValores.First(v => v == 2);
            var elementosDefault = listaValores.FirstOrDefault(v => v > 10);
            if (listaValores.Any())
            {
                var maxValue = listaValores.Max();
            }

            string[] nomes = { "Tom", "Huck", "Harry", "Mary", "Jay" };

            IEnumerable<string> query = nomes.Where(nome => nome.Contains("a"))
                                             .OrderBy(nome => nome.Length)
                                             .Select(nome => nome.ToUpper());

            var primeiroElementoDescrescente = (from nome in nomes
                                      orderby nome descending
                                      select nome).First(); // return Tom

            var primeiroElementoAscendente = (from nome in nomes
                                                orderby nome ascending
                                                select nome).First(); // reurn Harry

            var mixQueries = (from nome in nomes
                              join nomeY in nomes.Where(y => y.Contains("y")) on nome equals nomeY
                              where nome.Count() > 3
                              select nome.ToUpper()).OrderByDescending(x => x);

            foreach (string nome in query)
            {
                Console.WriteLine(nome);
            }

            var queryCulturas = CultureInfo.GetCultures(CultureTypes.AllCultures).Select(culture =>
            new
            {
                Nome = culture.DisplayName,
                NomeTecnico = culture.Name,
                NomeEmIngles = culture.EnglishName,
                HashCode = culture.GetHashCode(),

            });

            foreach (var cultura in queryCulturas)
            {
                Console.WriteLine($"Nome: {cultura.Nome}\n" +
                                  $"Nome técnico: {cultura.NomeTecnico}\n" +
                                  $"Nome em Inglês: {cultura.NomeEmIngles}\n" +
                                  $"HashCode: {cultura.HashCode}\n");
            }
        }
    }
}