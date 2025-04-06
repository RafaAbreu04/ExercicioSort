using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class MergeSort
    {
        public int[] Ordenar(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int meio = (fim + inicio) / 2;
                Ordenar(vetor, inicio, meio);
                Ordenar(vetor, meio + 1, fim);
                Merge(vetor, inicio, meio, fim);
            }
            return vetor;
        }

        public void Merge(int[] vetor, int inicio, int meio, int fim)
        {
            int i;
            int esquerda;
            int direita;
            int[] vetorTemp = new int[vetor.Length];

            for (i = inicio; i <= fim; i++)
            {
                vetorTemp[i] = vetor[i];
            }

            esquerda = inicio;
            direita = meio + 1;
            i = inicio;
            while (esquerda <= meio && direita <= fim)
            {
                if (vetorTemp[esquerda] <= vetorTemp[direita])
                {
                    vetor[i++] = vetorTemp[esquerda++];
                }
                else
                {
                    vetor[i++] = vetorTemp[direita++];
                }
            }

            while (esquerda <= meio)
            {
                vetor[i++] = vetorTemp[esquerda++];
            }
            while (direita <= fim)
            {
                vetor[i++] = vetorTemp[direita++];
            }
        }
    }
}
