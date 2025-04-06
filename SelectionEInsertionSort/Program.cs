using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionEInsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SelectionSort selectionSort = new SelectionSort();
            InsertionSort insertionSort = new InsertionSort();
            int[] vetorInsertion = new int[7] {3, 8, 98, 345, 5, 7, 1 };
            int[] vetorSelection = new int[7] { 2, 6, 87, 23, 865, 1, 0 };

            Console.WriteLine("Escolha qual método de ordenação deseja: \n");
            Console.WriteLine("1 - Insertion Sort");
            Console.WriteLine("2 - Selection Sort");

            string opcao = Console.ReadLine().ToLower();

            if (opcao.Equals("1") || opcao.Equals("um"))
            {
                PrintarDados.PrintarArray(vetorInsertion);
                PrintarDados.PrintarArray(insertionSort.Insertion(vetorInsertion));
            }
            else if (opcao.Equals("2") || opcao.Equals("dois"))
            {
                PrintarDados.PrintarArray(vetorSelection);
                PrintarDados.PrintarArray(selectionSort.Selection(vetorSelection));
            }
            else
            {
                Console.WriteLine("Valor inválido!");
                Environment.Exit(0);
            }
            
            Console.ReadLine();

        }
    }
}
