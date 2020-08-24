using System;

namespace Funcao
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Escreva 3 números: ");
            string[] vet = Console.ReadLine().Split(' ');
            int n1 = int.Parse(vet[0]);
            int n2 = int.Parse(vet[1]);
            int n3 = int.Parse(vet[2]);


            double resultado = Maior(n1, n2, n3);

            Console.WriteLine($"Resultado = {resultado}");
        }

        static int Maior(int a, int b, int c)
        {
                int m;

                if(a > b && a > c)
                {
                    m = a;

                }
                else if(b > c){
                    m = b;
                }
                else
                {
                    m = c;
                }
            return m;
        }
    }
}

