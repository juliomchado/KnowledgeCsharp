using System;
using System.Collections.Generic;

namespace Conjuntos
    
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            //B.Remove(4);
            //A.IntersectWith(B); //Interseção A e B (O q tem nos 2).

            //A.UnionWith(B); //A união B.
            //A.ExceptWith(B); //Diferença entra A e B = A - B.
                


            foreach (int x in B)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Digite um valor inteiro: ");
            int N = int.Parse(Console.ReadLine());



            /*
            if (B.Contains(N))                  //Se o valor N contem ou não contém no conjunto B
            {
                Console.WriteLine(N + "Percente ao conjunto B");
            }
            else
                Console.WriteLine(N+ "Não pertence ao conjunto B");
                */

        }
    }
}
