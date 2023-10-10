using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    public class Generics<T, K>
    {
       public void Compara(T valor1, K valor2)
       {
            bool objeto;
            objeto = valor1.Equals(valor2);
            Console.WriteLine(objeto);
       }
    }
}
