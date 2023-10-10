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
    public class MenuAlunoController : ControllerBase
    {
        private readonly ILogger<MenuAlunoController> _logger;
        public MenuAlunoController(ILogger<MenuAlunoController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public String Get()
        {
            var aluno = new Aluno
            {
                Nome = "Darley Leal",
                RU = 4102341
            };
            return JsonSerializer.Serialize(aluno);
        }
    }
}
