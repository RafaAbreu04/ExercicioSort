using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public static class PrintarDados
    {
        public static void PrintarSorteados(int[] numeros)
        {
            Console.Write("Vetor sorteado: ");
            foreach (int i in numeros)
            {
                Console.Write(i + " ");
            }
        }

        public static void PrintarOrdenados(int[] numeros)
        {
            Console.WriteLine();
            Console.Write("Vetor ordenado: ");
            foreach (int i in numeros)
            {
                Console.Write(i + " ");
            }
        }
    }
}
