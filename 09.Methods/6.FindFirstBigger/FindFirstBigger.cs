using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.FindFirstBigger
{
    class FindFirstBigger
    {
        static bool CheckIfIsBigger(int[] numbers, int position)
        {
            if (position < 0 || position >= numbers.Length)
            {
                throw new ArgumentException("The position should be in the bounds of the array!");
            }

            if (position == 0 && position == numbers.Length - 1)
            {
                return true;
            }
            if (position == 0)
            {
                if (numbers[position] > numbers[position + 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (position == numbers.Length - 1)
            {
                if (numbers[position] > numbers[position - 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool isBigger = numbers[position] > numbers[position - 1] && numbers[position] > numbers[position + 1];
            if (isBigger)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Finds the position of the first element which is bigger than his neighbours.
        /// </summary>
        /// <param name="numbers">The array in which to search.</param>
        /// <returns>Returns the index of the element or -1 if there is no such element.</returns>
        static int FirstBiggerElement(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                bool isFound = CheckIfIsBigger(numbers, i);
                if (isFound)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 4, 4, 364, 3, 46, 3, 46, 5, 32243, 66, 7, 4, 2, 4, 6, 54, 32, 5, 6456, 4, 35, 3, 53, 46 };
            //int[] numbers = new int[] { 1,1,1,1};
            int index = FindFirstBigger.FirstBiggerElement(numbers);

            Console.WriteLine("Index = {0}",index);

            Console.ReadKey();
        }
    }
}
