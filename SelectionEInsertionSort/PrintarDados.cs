using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionEInsertionSort
{
    public abstract class PrintarDados
    {
        public static void PrintarArray(int[] numeros)
        {
            Console.Write("Vetor: ");
            foreach (int i in numeros)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }

        
    }
}
