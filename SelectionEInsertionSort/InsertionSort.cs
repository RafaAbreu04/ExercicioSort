using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionEInsertionSort
{
    public class InsertionSort
    {
        public int[] vetorOrdenado;

        public int[] Insertion(int[] vetorSorteado)
        {            
            for (int i = 1; i < vetorSorteado.Length; i++)
            {
                int temporario = vetorSorteado[i];
                int j = i - 1;

                while (j >= 0 && vetorSorteado[j] > temporario)
                {
                    vetorSorteado[j + 1] = vetorSorteado[j];
                    j = j - 1;
                }
                vetorSorteado[j + 1] = temporario;
            }

            vetorOrdenado = vetorSorteado;
            return vetorOrdenado;
        }
    }
}
