using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionEInsertionSort
{
    public class SelectionSort
    {

        public int[] vetorOrdenado;
        public int[] Selection(int[] vetorSorteado)
        {
            for (int i = 0; i < vetorSorteado.Length; i++)
            {
                int[] vetorTemporario = vetorSorteado;

                for (int j = 0; j < vetorTemporario.Length; j++) 
                {
                    if (vetorTemporario[j] < vetorSorteado[i]) 
                    {
                        int temp = vetorSorteado[i];
                        vetorSorteado[i] = vetorTemporario[j];
                        vetorSorteado[j] = temp;
                    }
                }
            }
            vetorOrdenado = vetorSorteado;
            Array.Reverse(vetorOrdenado);
            return vetorOrdenado;
        }
        
    }
}
