using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.ArrayAnalys
{
    class ArrayAnalysis
    {
        static int CountNumberInArray(int[] numbers, int n)
        {
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == n)
                {
                    counter++;
                }
            }
            return counter;
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[] {2,4,6,2,5,3,7,8,7,2,3,2,15,6,3,};

            bool isCorrectNumber = false;
            int number = 0;
            while (!isCorrectNumber)
            {
                Console.Write("number = ");
                isCorrectNumber = int.TryParse(Console.ReadLine(), out number);
            }

            int count = CountNumberInArray(numbers,number);

            Console.WriteLine("Count: {0}",count);

            Console.ReadKey();
        }
    }
}
