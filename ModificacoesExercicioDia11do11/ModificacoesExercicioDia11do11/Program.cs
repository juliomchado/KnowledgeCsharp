using System;


namespace ModificacoesExercicioDia11do11
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vetor = new int[10];

            Random random = new Random();



            for (var alimento = 0; alimento < vetor.Length; alimento++)

            {


                vetor[alimento] = random.Next(0, 1000);

            }

            Console.WriteLine("Antes da troca: ");
            foreach (int obj in vetor)
                Console.WriteLine(obj);

            Console.WriteLine();
            BubbleSort(vetor);

            Console.WriteLine();
            Console.WriteLine("Depois da troca: ");
            foreach (int obj in vetor)
                Console.WriteLine(obj);
        }
        static void BubbleSort(int[] vetor)

        {
            int indice, indiceAux, aux;

            for (indice = vetor.Length - 1; indice >= 0; indice--)

            {

                for (indiceAux = vetor.Length - 1; indice >= 0 && indiceAux >= 1; indiceAux--)

                {

                    if (vetor[indiceAux - 1] > vetor[indiceAux])

                    {

                        aux = vetor[indiceAux - 1];
                        vetor[indiceAux - 1] = vetor[indiceAux];
                        vetor[indiceAux] = aux;

                        Console.WriteLine($"O elemento do índice {indiceAux - 1} trocou com o elemento do índice {indiceAux}");

                    }

                }

            }

        }
    }
}
