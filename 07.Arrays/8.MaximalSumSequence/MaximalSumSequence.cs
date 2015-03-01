using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.MaximalSumSequence
{
    class MaximalSumSequence
    {
        static void Main(string[] args)
        {
            int[] numbers = 
            {
               2, 3, -6, -1, 2, -1, 6, 4, -8, 8
            };

            foreach (var item in numbers)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            int[] maxSumSequence = GetMaxSumSequence(numbers);
            foreach (var item in maxSumSequence)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        private static int[] GetMaxSumSequence(int[] numbers)
        {
            int maxSum = 0;
            List<int> maxSumSequene = new List<int>();

            for (int sp = 0; sp < numbers.Length; sp++)
            {
                int currentSum = numbers[sp];
                int lastMaxPosition = -1;
                for (int i = sp + 1; i < numbers.Length; i++)
                {
                    currentSum += numbers[i];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        lastMaxPosition = i;
                    }                    
                }
                if (lastMaxPosition!=-1)
                {
                    maxSumSequene.Clear();
                    for (int j = sp; j <= lastMaxPosition; j++)
                    {
                        maxSumSequene.Add(numbers[j]);
                    }
                }
            }
            return maxSumSequene.ToArray();
        }
    }
}
