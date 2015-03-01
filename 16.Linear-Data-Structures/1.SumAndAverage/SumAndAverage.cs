using System;
using System.Collections.Generic;


namespace _1.SumAndAverage
{
    class SumAndAverage
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            while (true)
            {
                string line = Console.ReadLine();
                int number = 0;
                if (!int.TryParse(line,out number))
                {
                    break;
                }
                else
                {
                    numbers.Add(number);
                }
            }

            long sum = FindSum(numbers);
            double average = sum / (double)numbers.Count;

            Console.WriteLine("Sum = {0}",sum);
            Console.WriteLine("Average = {0}",average);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }

        static long FindSum(List<int> numbers)
        {
            long sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }        

    }
}
