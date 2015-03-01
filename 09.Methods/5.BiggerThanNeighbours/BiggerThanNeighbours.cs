using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.BiggerThanNeighbours
{
    class BiggerThanNeighbours
    {
        static bool CheckIfIsBigger(int[] numbers, int position)
        {
            if (position<0 || position>=numbers.Length)
            {
                throw new ArgumentException("The position should be in the bounds of the array!");
            }

            if (position==0 && position==numbers.Length-1)
            {
                return true;
            }
            if (position==0)
            {
                if (numbers[position] > numbers[position+1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (position==numbers.Length-1)
            {
                if (numbers[position]>numbers[position-1])
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

        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3,4,634,364,3,46,3,46,5,32243,66,7,4,2,4,6,54,32,5,6456,4,35,3,53,46};

            bool isCorrect = false;
            int p = 0;
            while (!isCorrect)
            {
                Console.Write("position = ");
                isCorrect = int.TryParse(Console.ReadLine(), out p);
            }

            bool isBigger = false;
            try
            {
                CheckIfIsBigger(numbers, p);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            if (isBigger)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadKey();
        }
    }
}
