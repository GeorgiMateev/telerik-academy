using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.FindASumSequence
{
    class FindSequence
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = 
            {
                4, 3, 1, 4, 2, 5, 8
            };


            List<int> sequence = new List<int>();
            for (int sp = 0; sp < numbers.Length; sp++)
            {
                int currentSum = numbers[sp];
                for (int i = sp+1; i < numbers.Length; i++)
                {
                    currentSum += numbers[i];
                    if (currentSum==n)
                    {
                        for (int j = sp; j <= i; j++)
                        {
                            sequence.Add(numbers[j]);
                        }
                        break;
                    }
                }
                if (currentSum==n)
                {
                    break;
                }
            }
            foreach (var item in sequence)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
        }
    }
}
