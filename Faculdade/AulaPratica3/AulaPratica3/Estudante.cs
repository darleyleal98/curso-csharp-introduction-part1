using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPratica3
{
    public class Estudante
    {
        public string Nome { get; set; }
        public decimal Media { get; set; }
        public List<Avaliacao> Avaliacoes { get; set; }
    }
}
