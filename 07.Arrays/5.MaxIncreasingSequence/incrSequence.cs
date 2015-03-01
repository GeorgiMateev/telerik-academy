using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.MaxIncreasingSequence
{
    class incrSequence
    {
        static void Main(string[] args)
        {
            int[] numbers = 
            {
                3,2,1,3,4,6
            };

            int maxCount = 1;
            int theMaxNumber = numbers[0];

            int counter = 1;
            for (int i = 0; i <= numbers.Length - 2; i++)
            {

                if (numbers[i] == numbers[i + 1]-1)
                {
                    counter++;
                }
                else if (counter > maxCount)
                {
                    maxCount = counter;
                    theMaxNumber = numbers[i];
                    counter = 1;
                }
                if (i == numbers.Length - 2 && counter > maxCount)
                {
                    maxCount = counter;
                    theMaxNumber = numbers[i+1];
                }
            }

            Console.WriteLine("The maximal increasing sequence is:");
            for (int i = maxCount-1; i >= 0; i--)
            {
                Console.Write("{0} ", theMaxNumber-i);
            }

            Console.ReadKey();
        }
    }
}
