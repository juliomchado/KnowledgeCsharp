using System;
using System.Collections.Generic;

namespace ExercicioConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();


            Console.Write("O curso A possui quantos alunos? ");
            int AlunosA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunso do curso A: ");
            for(int alunos = 0; alunos < AlunosA; alunos++)
            {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }

            Console.Write("O curso A possui quantos alunos? ");
            int AlunosB = int.Parse(Console.ReadLine());

            for (int alunos = 0; alunos < AlunosB; alunos++)
            {
                int x = int.Parse(Console.ReadLine());
                B.Add(x);
            }

            Console.Write("O curso A possui quantos alunos? ");
            int AlunosC = int.Parse(Console.ReadLine());

            for (int alunos = 0; alunos < AlunosC; alunos++)

            {
                int x = int.Parse(Console.ReadLine());
                C.Add(x);
            }
            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(A);
            Novo.UnionWith(B);
            Novo.UnionWith(C);


            Console.WriteLine($"Total de alunos: {Novo.Count}");
        }
    }
}
