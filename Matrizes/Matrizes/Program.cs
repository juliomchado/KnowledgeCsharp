using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length); //Qnts elementos tem no total.

            Console.WriteLine(mat.Rank); //Qnt é 1 dimensão da matriz (qnt linhas).

            Console.WriteLine(mat.GetLength(0)); //Qnt da 1 dimensão (linhas).

            Console.WriteLine(mat.GetLength(1)); //Qnt da 2 dimensão (colunas).
        }
    }
}
