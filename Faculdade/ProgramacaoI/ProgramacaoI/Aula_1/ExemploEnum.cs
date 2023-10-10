using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Aula1
{
    /// <summary>
    /// Observe que foi setado um valor explícito para cada item do enum
    /// </summary>
    
    public enum Direcoes
    { 
        Cima = 1,
        Baixo = 10,
        LadoEsquerdo = 20,
        LadoDireiro = 67
    }

    public enum Meses
    {
        Janeiro = 31,
        Fevereiro = 28,
        Marco = 31,
        Abril = 30,
        Maio = 31,
        Junho = 30,
        Agosto = 31,
        Setembro = 30,
        Outubro = 31,
        Novembro = 30,
        Dezembro = 31
    }

    public enum DiasDaSemana
    {
        Domingo,
        Segunda,
        Terca,
        Quarta,
        Quinta,
        Sexta,
        Sabado
    }

    public class ExemploEnum
    {
        public void MetodoExemploEnum()
        {
            var direcaoCima = Direcoes.Cima;

            // Usando os enums que eu criei, Darley:
            var mesDoAno = Meses.Dezembro;
            var diaDaSemana = DiasDaSemana.Sabado;
            Console.WriteLine($"{mesDoAno}, {diaDaSemana}");

            if ((int)direcaoCima > 20)
            {
                return;
            }

            switch (direcaoCima)
            {
                case Direcoes.Cima:
                    break;
                case Direcoes.Baixo:
                    break;
                case Direcoes.LadoEsquerdo:
                    break;
                case Direcoes.LadoDireiro:
                    break;
                default:
                    break;
            }
        }
    }
}
