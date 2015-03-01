using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] numbers =
            {
                3,5,5,5,5,4,4,4,4,6,5,5,5,2,-1
            };

            Array.Sort(numbers);

            int mostFreq = 0;
            int biggestCount = 0;

            int counter = 1;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                int number = numbers[i];
                if (number==numbers[i+1])
                {
                    counter++;
                }
                else if (counter>biggestCount)
                {
                    biggestCount = counter;
                    mostFreq = numbers[i];
                    counter = 1;
                }
                    else
                    {
                        counter = 1;
                    }
                if (i == numbers.Length - 2 && number == numbers[i + 1] && counter>biggestCount)
                {
                    mostFreq = numbers[i];
                }
            }

            foreach (var item in numbers)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            Console.WriteLine(mostFreq);

            Console.ReadKey();
        }
    }
}
