using System;

namespace ExercicioMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva quantidade de linhas e colunas: ");
            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            int[,] mat = new int[m, n];

            Console.WriteLine("Digite o valor das linhas e colunas");

            for (int i = 0; i < m; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Escreva o valor que quer saber: ");
            int x = int.Parse(Console.ReadLine());

            for(int i = 0; i < m; i++)
            {
                for (int j = 0; j < n;j++)
                {
                    if(mat[i,j] == x)
                    {
                        Console.WriteLine($"Posição: {i},{j}: ");
                        if (j > 0)
                            Console.WriteLine($"Esquerda: {mat[i, j - 1]}");

                        if (i > 0)
                            Console.WriteLine($"Cima: {mat[i- 1, j]}");

                        if(j < n - 1)
                            Console.WriteLine($"Direita: {mat[i, j + 1]}");

                        if(i < m - 1)
                            Console.WriteLine($"Baixo: {mat[i + 1, j]}");
                        
                    }
                }
            }
        }
    }
}
