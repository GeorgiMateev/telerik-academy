using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20.Variations
{
    class Variations
    {
        private static int N;
        private static int K;
        private static int[] numbers;
        private static int[] variation;
        private static List<int> usedIndexes;

        private static void Variation(int position)
        {
            if (position == K)
            {
                ConsolePrintVariation(); return;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (usedIndexes.Contains(i))
                {
                    continue;
                }
                usedIndexes.Add(i);
                variation[position] = numbers[i];
                Variation(position + 1);
                usedIndexes.Remove(i);
            }
        }
        private static void ConsolePrintVariation()
        {
            foreach (var item in variation)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            bool isCorrectN = false;
            while (!isCorrectN)
            {
                Console.Write("N = ");
                isCorrectN = int.TryParse(Console.ReadLine(), out N);
            }

            numbers = new int[N];
            for (int i = 0; i< numbers.Length; i++)
            {
                numbers[i] = i+1;
            }

            bool isCorrectK = false;
            while (!isCorrectK)
            {
                Console.Write("K = ");
                isCorrectK = int.TryParse(Console.ReadLine(), out K);
            }

            variation = new int[K];
            usedIndexes = new List<int>(); 
            
            Variation(0);

            Console.ReadKey();
        }
    }
}
