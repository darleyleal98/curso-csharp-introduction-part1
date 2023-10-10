using System;

namespace CursoCSharpUdemy.Matriz
{
    public class Matriz
    {
        private string Position { get; set; }
        private int Left { get; set; }
        private int Right { get; set; }
        private int Down { get; set; }
        private int Up { get; set; }

        public Matriz(string posicao, int left, int right,
                                        int down, int up)
        {
            Position = posicao;
            Left = left;
            Right = right;
            Down = down;
            Up = up;
        }

        public Matriz() { }

        public override string ToString()
        {
            return $"Position: {Position} \n" +
                   $"Left: {Left} \n" +
                   $"Right: {Right} \n" +
                   $"Down: {Down} \n" +
                   $"Up: {Up} \n";
        }

        public void MatrizExrecicio()
        {
            Console.Write("Digite a quantidade de linhas e colunas\n");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];

            for (int linha = 0; linha < n; linha++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int coluna = 0; coluna < m; coluna++)
                {
                    matriz[linha, coluna] = int.Parse(valores[coluna]);
                }
            }

            Console.WriteLine("Digite o número para ser encontrado na matriz:");
            int valorProcurado = int.Parse(Console.ReadLine());

            try
            {
                for (int linha = 0; linha < matriz.GetLength(0); linha++)
                {
                    for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                    {
                        if (matriz[linha, coluna] == valorProcurado)
                        {
                            string position = $"{linha},{coluna}";

                            // Retornará -0 se valo não estiver dentro da matriz

                            int left = (coluna > 0) ? matriz[linha, coluna - 1] : -1;
                            int right = (coluna < matriz.GetLength(1) - 1) ? matriz[linha, coluna + 1] : -1; 
                            int down = (linha > 0) ? matriz[linha - 1, coluna] : -0;
                            int up = (linha < matriz.GetLength(0) - 1) ? matriz[linha + 1, coluna] : -1; 

                            var matrizPrincipal = new Matriz(position, left, right, down, up);
                            Console.WriteLine(matrizPrincipal.ToString());
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}