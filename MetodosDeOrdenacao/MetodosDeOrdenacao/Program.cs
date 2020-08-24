using System;
using MetodosDeOrdenacao.Inverso;

namespace MetodosOrdenacao

{

    class Program

    { 

        // Método de Ordenação INSERTION SORT

        static void InsertionSort(int[] vetor)

        {

            int indiceAuxiliar, atual;

            for (int indice = 1; indice < vetor.Length; indice++)

            {

                atual = vetor[indice];

                for (indiceAuxiliar = indice; indiceAuxiliar > 0 && vetor[indiceAuxiliar - 1] > atual; indiceAuxiliar--)

                {

                    if (indiceAuxiliar != indiceAuxiliar - 1)

                        vetor[indiceAuxiliar] = vetor[indiceAuxiliar - 1];

                }

                if (indiceAuxiliar != indice)

                    vetor[indiceAuxiliar] = atual;

            }

        }

        // Método de Ordenação SELECTION SORT

        static void SelectionSort(int[] vetor)

        {

            int indiceMenor, aux;

            for (int indice = 0; indice < vetor.Length; indice++)

            {

                indiceMenor = indice;

                for (int indiceAux = indice + 1; indiceAux < vetor.Length; indiceAux++)

                    if (vetor[indiceAux] < vetor[indiceMenor])

                        indiceMenor = indiceAux;

                if (indiceMenor != indice)

                {

                    aux = vetor[indiceMenor];

                    vetor[indiceMenor] = vetor[indice];

                    vetor[indice] = aux;

                }

            }

        }

        // Método de Ordenação BUBBLE SORT

        static void BubbleSort(int[] vetor)

        {

            int indice, indiceAux, aux;

            for (indice = 0; indice < vetor.Length; indice++)

            {

                for (indiceAux = 0; indice < vetor.Length - (indiceAux + 1); indiceAux++)

                {

                    if (vetor[indiceAux + 1] < vetor[indiceAux])

                    {

                        aux = vetor[indiceAux];

                        vetor[indiceAux] = vetor[indiceAux + 1];

                        vetor[indiceAux + 1] = aux;

                    }

                }

            }

        }

        // Método de Ordenação SHELL SORT

        static void ShellSort(int[] vetor)

        {

            int indiceAux, aux;

            int pulo = 4;

            while (pulo > 0)

            {

                for (int indice = 0; indice < vetor.Length; indice++)

                {

                    indiceAux = indice;

                    aux = vetor[indice];

                    while ((indiceAux >= pulo) && (vetor[indiceAux - pulo] > aux))

                    {

                        vetor[indiceAux] = vetor[indiceAux - pulo];

                        indiceAux = indiceAux - pulo;

                    }

                    vetor[indiceAux] = aux;

                }

                if (pulo / 2 != 0)

                    pulo = pulo / 2;

                else if (pulo == 1)

                    pulo = 0;

                else

                    pulo = 1;

            }

        }

        // Método de Ordenação HEAP SORT

        class HeapSort

        {

            private int heapSize;

            private void ConstruirMaxHeap(int[] arr)

            {

                heapSize = arr.Length - 1;

                for (int i = heapSize / 2; i >= 0; i--)

                {

                    ExecutarMaxHeap(arr, i);

                }

            }

            private void Trocar(int[] arr, int x, int y)

            {

                int temp = arr[x];

                arr[x] = arr[y];

                arr[y] = temp;

            }

            private void ExecutarMaxHeap(int[] arr, int index)

            {

                int noEsquerdo = 2 * index + 1;

                int noDireito = 2 * index + 2;

                int maior = index;

                if (noEsquerdo <= heapSize && arr[noEsquerdo] > arr[index])

                {

                    maior = noEsquerdo;

                }

                if (noDireito <= heapSize && arr[noDireito] > arr[maior])

                {

                    maior = noDireito;

                }

                if (maior != index)

                {

                    Trocar(arr, index, maior);

                    ExecutarMaxHeap(arr, maior);

                }

            }

            public void ExecutarHeapSort(int[] arr)

            {

                ConstruirMaxHeap(arr);

                for (int i = arr.Length - 1; i >= 0; i--)

                {

                    Trocar(arr, 0, i);

                    heapSize--;

                    ExecutarMaxHeap(arr, 0);

                }

            }

            private void MostrarArray(int[] arr)

            {

                for (int i = 0; i < arr.Length; i++)

                { Console.Write("[{0}]", arr[i]); }

            }

        }

        // Método de Ordenação QUICK SORT

        static public void QuickSort(int[] vetor, int primeiro, int ultimo)

        {

            int baixo, alto, meio, pivo, repositorio;

            baixo = primeiro;

            alto = ultimo;

            meio = (int)((baixo + alto) / 2);

            pivo = vetor[meio];

            while (baixo <= alto)

            {

                while (vetor[baixo] < pivo)

                    baixo++;

                while (vetor[alto] > pivo)

                    alto--;

                if (baixo < alto)

                {

                    repositorio = vetor[baixo];

                    vetor[baixo] = vetor[alto];

                    vetor[alto] = repositorio;

                    baixo++;

                    alto--;

                }

                else

                {

                    if (baixo == alto)

                    {

                        baixo++;

                        alto--;

                    }

                }

            }

            if (alto > primeiro)

                QuickSort(vetor, primeiro, alto);

            if (baixo < ultimo)

                QuickSort(vetor, baixo, ultimo);

        }

        // Método de Ordenação MERGE SORT

        class MergeSort

        {

            private void Mesclar(int[] numbers, int esquerda, int meio, int direita)

            {
                
                int[] temp = new int[numbers.Length];

                int i, esquerda_end, num_elements, tmp_pos;

                esquerda_end = (meio - 1);

                tmp_pos = esquerda;

                num_elements = (direita - esquerda + 1);

                while ((esquerda <= esquerda_end) && (meio <= direita))

                {

                    if (numbers[esquerda] <= numbers[meio])

                        temp[tmp_pos++] = numbers[esquerda++];

                    else

                        temp[tmp_pos++] = numbers[meio++];

                }

                while (esquerda <= esquerda_end)

                    temp[tmp_pos++] = numbers[esquerda++];

                while (meio <= direita)

                    temp[tmp_pos++] = numbers[meio++];

                for (i = 0; i < num_elements; i++)

                {

                    numbers[direita] = temp[direita];

                    direita--;

                }

            }

            public void MergeSort_Recursivo(int[] numbers, int esquerda, int direita)

            {

                int meio;

                if (direita > esquerda)

                {

                    meio = (direita + esquerda) / 2;

                    MergeSort_Recursivo(numbers, esquerda, meio);

                    MergeSort_Recursivo(numbers, (meio + 1), direita);

                    Mesclar(numbers, esquerda, (meio + 1), direita);

                }

            }

        }

        static void Main(string[] args)

        {
            BubbleSortInverso bubble = new BubbleSortInverso();
            InsertionSortInverso insertion = new InsertionSortInverso();
            SelectionSortInverso select = new SelectionSortInverso();

            int[] vetor = new int[8];

            Random random = new Random();
            
            for (var alimento = 0; alimento < vetor.Length; alimento++)
            {
                
                vetor[alimento] = random.Next(0, 1000);
                
            }
            // O(s) método(s) de ordenação devem ser chamados aqui.
         

            select.SelectionSortInv(vetor);

            foreach (int obj in vetor)
                Console.WriteLine(obj);

            Console.ReadKey();

            // O(s) método(s) de ordenação devem ser chamados aqui.

        }

    }

}