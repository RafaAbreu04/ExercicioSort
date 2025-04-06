using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            MergeSort testeMerge = new MergeSort();
            NumAleatorios numAleatorio = new NumAleatorios();

            numAleatorio.IndicarTamanhoArray();
            Console.WriteLine(numAleatorio.TamanhoArray);

            Console.Write("Insira o valor mínimo do vetor (número inteiro): ");
            string strMin = Console.ReadLine();

            if (!int.TryParse(strMin, out int min) || min < 0)
            {
                Console.WriteLine("Valor não aceito");
                Environment.Exit(0);
            }

            Console.Write("Insira o valor máximo do vetor (número inteiro): ");
            string strMax = Console.ReadLine();

            if (!int.TryParse(strMax, out int max) || max < 0)
            {
                Console.WriteLine("Valor não aceito");
                Environment.Exit(0);
            }

            int[] numeros = new int[numAleatorio.TamanhoArray];
            numAleatorio.GerarArray(numeros, min, max);

            PrintarDados.PrintarSorteados(numeros);

            testeMerge.Ordenar(numeros, 0, numeros.Length - 1);
            PrintarDados.PrintarOrdenados(numeros);

            Console.ReadLine();
        }
    }
}
