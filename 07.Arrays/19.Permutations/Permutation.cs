using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19.Permutations
{
    class Permutations
    {
        private static int N;
        private static int[] numbers;
        private static int[] permutation;
        private static List<int> usedIndexes;

        private static void Permutation(int position)
        {
            if (position==N)
            {
                ConsolePrintPermutation(); return;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (usedIndexes.Contains(i))
                {
                    continue;
                }
                usedIndexes.Add(i);
                permutation[position] = numbers[i];
                Permutation(position + 1);
                usedIndexes.Remove(i);
            }
        }
        private static void ConsolePrintPermutation()
        {
            foreach (var item in permutation)
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
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
            
            permutation = new int[N];
            usedIndexes = new List<int>();

            Permutation(0);

            Console.ReadKey();
        }
    }
}
