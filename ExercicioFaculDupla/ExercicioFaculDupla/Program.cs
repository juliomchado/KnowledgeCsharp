using System;
using System.Globalization;


namespace ExercicioFaculDupla
{
    class Program
    {
        static void Main(string[] args)
        {

            int contador = 0;
            int[] vetor = new int[1000];
            Random rnd = new Random();

            for (int numeros = 0; numeros < vetor.Length; numeros++)
            {
                vetor[numeros] = rnd.Next(1, 500);

                if (vetor[numeros] > 100 && vetor[numeros] % 2 == 0)
                {
                    Console.WriteLine($"Número #{contador + 1}: {vetor[numeros]}");
                    contador++;

                    if (contador == 10)
                        break;
                }
            }
            


           
        }
    }
}

