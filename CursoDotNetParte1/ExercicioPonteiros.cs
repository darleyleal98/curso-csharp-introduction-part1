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
    public struct ExercicioPonteiros
    {
        public double x;
        public double y;

        public override string ToString()
        {
            return $"X: {x}, Y: {y}";
        }

        public void PonteiroTeste()
        {
            // Método para testes na aula

            ExercicioPonteiros point;

            point.x = 10;
            point.y = 20;

            Console.WriteLine(point);

            double? x = null;
            double? y = null;

            Console.WriteLine(x.GetValueOrDefault());

            double a = x ?? 5;
            double b = y ?? 60;

            Console.WriteLine($"{a}, {b}");

        }
    }
}
