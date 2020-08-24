using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosDeOrdenacao.Inverso
{
    class BubbleSortInverso
    {
        static void BubbleSortInv(int[] vetor)

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


    }
}
