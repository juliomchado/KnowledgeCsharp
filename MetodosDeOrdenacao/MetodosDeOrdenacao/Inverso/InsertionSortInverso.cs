using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosDeOrdenacao.Inverso
{
    class InsertionSortInverso
    {
        public void InsertionSortInv(int[] vetor)

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
    }
}
