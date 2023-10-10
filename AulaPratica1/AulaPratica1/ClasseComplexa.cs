using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPratica1
{
    public class ClasseComplexa : IImprimirValores
    {
        private int PropInt {  get; set; }
        protected bool PropBool { get; set; }
        public decimal PropDecimal { get; set; }
        protected DateTime dataAtual;
        float floatDecimal;
        public Direcoes Direcao { get; set; }
        public string PropInterface { get; set; }
        public enum Direcoes
        {
            Cima = 1,
            Baixo = 10,
            LadoEsquerdo = 0,
            LadoDireito = 67
        }
    }
}
