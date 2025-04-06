using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class NumAleatorios
    {
        Random r = new Random();

        private int tamanhoArray;

        public int TamanhoArray
        {
            get { return tamanhoArray; }
            set { tamanhoArray = value; }
        }



        public void IndicarTamanhoArray()
        {
            Console.Write("Indique o tamanho do vetor: ");
            string strVetor = Console.ReadLine();
            if (!int.TryParse(strVetor, out int vetor) || vetor <= 0)
            {
                Console.WriteLine("Valor não aceito");
                Environment.Exit(0);
            }

            TamanhoArray = vetor;
        }


        public void GerarArray(int[] vetor, int min, int max)
        {
            int numRandom = r.Next(min, max);

            for (int i = 0; i < TamanhoArray; i++)
            {
                vetor[i] = r.Next(min, max);
            }
        }
    }
}

