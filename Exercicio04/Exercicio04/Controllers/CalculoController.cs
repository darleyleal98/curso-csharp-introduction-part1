using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Encodings.Web;
using System.Text.Json;
using System;
using System.Threading.Tasks;
using System.Text.Unicode;

namespace ExercicioIV.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculoController : ControllerBase
    {
        private readonly ILogger<CalculoController> _logger;

        public CalculoController(ILogger<CalculoController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        // Inicio do método que efetuará o cálculo
        public string Post(string ru)
        {
            if (string.IsNullOrEmpty(ru) || ru.Length < 2)
            {
                return "A entrada não é válida.";
            }

            // Extrai os dois primeiros dígitos do meu RU: '41'02341
            int b = int.Parse(ru.Substring(0, 1)); // Primeiro valor
            int c = int.Parse(ru.Substring(1, 1)); // Segundo valor

            // Calcula o valor de "A" usando o Teorema de Pitágoras
            double a = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2));

            //Imprime valor de A de acordo com o Cálculo e efetua um if ternário, onde se a primeira
            //for verdadeira imprime é um triângulo Pitagórico, senão nega a resposta.
            string retorno = $"O valor de A na Equação de Pitágoras é: {a} e " +
                             (a * a == b * b + c * c ? "é um triângulo Pitagórico!" : "não é um triângulo Pitagórico!");

            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true
            };

            // Serializa a mensagem de retorno (triângulo Pitagórico ou não) em formato JSON.
            return JsonSerializer.Serialize(retorno, options);
        }
    }
}
