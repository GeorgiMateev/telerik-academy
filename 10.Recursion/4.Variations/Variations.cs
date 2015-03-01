using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Variations
{
    class Variations
    {
        static int[] variation;
        static int[] used;

        /// <summary>
        /// Generates variations of consistent integer numbers starting from 1 without duplications.
        /// When range and length are equal the configuration is permutation.
        /// </summary>
        /// <param name="length">The length of the configuration.</param>
        /// <param name="range">The range of numbers between 1 and n.</param>
        static void GenerateVariations(int length, int range)
        {
            if (length>range)
            {
                throw new ArgumentException("The length should be smaller or equal to the range!");
            }
            if (length==0)
            {
                PrintVariations(variation);
                return;
            }
            for (int i = 1; i <= range; i++)
            {
                if (used[i-1]==1)
                {
                    continue;
                }
                variation[length - 1] = i;
                used[i - 1] = 1;
                GenerateVariations(length - 1, range);
                used[i - 1] = 0;
            }
        }
        private static void PrintVariations(int[] variation)
        {
            for (int i = (variation.Length - 1); i >= 0; i--)
            {
                Console.Write("{0} ", variation[i]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(@"Generates k-set variations from n elements strating from 1.
If k=n the configuration is permutation.");

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            variation = new int[k];
            used = new int[n];

            try
            {
                GenerateVariations(k,n);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
