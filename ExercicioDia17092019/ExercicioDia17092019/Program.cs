using System;

namespace ExercicioDia17092019
{
    class Program
    { 
        static void Main(string[] args)
        {
            //================================ Exercicio 1 ================================
            /*
            int numero = 0, contador = 1;

            int[] vetor = new int[11];
            Random rnd = new Random();

            while (numero < vetor.Length)
            {
                numero++;
                vetor[numero] = rnd.Next(1, 100);
                Console.WriteLine(contador++ + ": " + vetor[numero]);
            }
            */

            //================================ Exercicio 2 ================================
            /*
            int numero = 0;

            int[] vetor = new int[10];
            Random rnd = new Random();

            for (numero = 0; numero < vetor.Length; numero++)
            {

                vetor[numero] = rnd.Next(1, 100);

            }
            foreach (int i in vetor)
            {
                Console.WriteLine(i);
            }
              */

            //================================ Exercicio 3 ================================\

            int numero = 0;

            int[] vetor = new int[10];
            Random rnd = new Random();

            for (numero = 0; numero < vetor.Length; numero++)
            {

                vetor[numero] = rnd.Next(1, 100);
                if(vetor[numero] % 2 == 0)
                { 
                    Console.WriteLine(vetor[numero]);
                }
            }
            

        }
    }
 }
