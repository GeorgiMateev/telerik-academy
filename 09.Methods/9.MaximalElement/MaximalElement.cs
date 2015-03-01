using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.MaximalElement
{
    class MaximalElement
    {
        static int[] Sort(int[] array)
        {
            return new int[0];
        }

        static int MaximalElementInPortion(int[] array, int index)
        {
            int max = 0;
            for (int i = index; i < array.Length; i++)
            {
                if (array[i]>max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5,3,6,3,26,54,23,63,32,2,1,36};
            int index = 5;

            int maximalElement = MaximalElementInPortion(numbers, index);

            Console.WriteLine("Maximal element after inde {0} is {1}",index,maximalElement);

            Console.ReadKey();
        }
    }
}
