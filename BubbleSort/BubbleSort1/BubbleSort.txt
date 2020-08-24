using System;

namespace BubbleSort1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vetor = new int[15];
            Random rnd = new Random();


            for (int posicao = 0; posicao < vetor.Length; posicao++)
            {
                vetor[posicao] = rnd.Next(1, 50);

            }

            bubbleSort(vetor, vetor.Length);

            Console.WriteLine("Vetor Ordenado:  ");
            for (int posicao = 0; posicao < vetor.Length; posicao++)
            {
  
                Console.WriteLine(vetor[posicao]);
            }
            Console.ReadLine();
        }

        static void bubbleSort(int[] vetor, int final)
        {
            int trocas = 0;
            for (int posicao = 0; posicao < final - 1; posicao++)
            {
                for (int Comparacao = 0; Comparacao < final - 1; Comparacao++)
                {
                    if (vetor[Comparacao] > vetor[Comparacao + 1])
                    {
                        trocas = vetor[Comparacao];
                        vetor[Comparacao] = vetor[Comparacao + 1];
                        vetor[Comparacao + 1] = trocas;
                    }
                }
            }
        }
    }
}