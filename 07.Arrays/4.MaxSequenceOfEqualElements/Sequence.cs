using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.MaxSequenceOfEqualElements
{
    class Sequence
    {
        static void Main(string[] args)
        {
            int[] numbers = 
            {
                1,2,3,4,4,4,4
            };

            int maxCount = 1;
            int theMaxNumber = numbers[0];

            int counter = 1;
            for (int i = 0; i <= numbers.Length-2; i++)
            {
                
                if (numbers[i] == numbers[i+1])
                {
                    counter++;
                }
                else if (counter>maxCount)
                {
                    maxCount = counter;
                    theMaxNumber = numbers[i];
                    counter = 1;
                }
                if (i == numbers.Length-2 && counter>maxCount)
                {
                    maxCount = counter;
                    theMaxNumber = numbers[i];
                }
            }

            Console.WriteLine("The maximal equal sequence is:");
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write("{0} ", theMaxNumber);
            }

            Console.ReadKey();
        }
    }
}
