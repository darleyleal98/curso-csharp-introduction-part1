using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPratica3
{
    public static class ExtesionMethodLambda
    {
        public static IEnumerable<T> MultiplicaPorEnumerable<T>(this IEnumerable<T> origem,
                                                                IEnumerable<T> vetor2, Func<IEnumerable<T>,
                                                                IEnumerable<T>, IEnumerable<T>> funcaoMultiplicar)
        {
            return funcaoMultiplicar(origem, vetor2);
        }
    }
}
