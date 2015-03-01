using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.CombinationsWithDublications
{
    class Combinations
    {
        static int[] combination;

        /// <summary>
        /// Generate all combinations with duplication of n elements.
        /// </summary>
        /// <param name="n">Elements</param>
        /// <param name="k">Lenght of the combination.</param>
        static void CombinationsWithDuplication(int n, int k)
        {
            if (k==0)
            {
                PrintCombinations(combination);
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                combination[k-1] = i;
                CombinationsWithDuplication(n, k - 1);
            }
        }

        private static void PrintCombinations(int[] combination)
        {
            for (int i = (combination.Length - 1); i >= 0; i--)
            {
                Console.Write("{0} ",combination[i]);
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            combination = new int[k];
            CombinationsWithDuplication(n, k);

            Console.ReadKey();
        }
    }
}
