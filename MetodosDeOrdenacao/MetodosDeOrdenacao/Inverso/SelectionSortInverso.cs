using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosDeOrdenacao.Inverso
{
    class SelectionSortInverso
    {
        public void SelectionSortInv(int[] vetor)

        {

            int indiceMenor, aux;

            for (int indice = vetor.Length -2; indice <= 0; indice--)

            {

                indiceMenor = indice;

                for (int indiceAux = vetor.Length - 1; indiceAux <= vetor.Length - 1; indiceAux++)

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
    }
}
