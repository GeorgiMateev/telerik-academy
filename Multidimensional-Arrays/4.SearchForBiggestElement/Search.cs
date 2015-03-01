using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.SearchForBiggestElement
{
    class Search
    {
        static void Main(string[] args)
        {
            int n = 0;
            bool isCorrectN = false;
            while (!isCorrectN)
            {
                Console.Write("n = ");
                isCorrectN = int.TryParse(Console.ReadLine(), out n);
                if (n <= 0)
                {
                    isCorrectN = false;
                }
            }
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                int x = 0;
                bool isCorrectX = false;
                while (!isCorrectX)
                {
                    Console.Write("x = ");
                    isCorrectX = int.TryParse(Console.ReadLine(), out x);
                    numbers[i] = x;
                }
            }
            
            int k = 0;
            bool isCorrectK = false;
            while (!isCorrectK)
            {
                Console.Write("k = ");
                isCorrectK = int.TryParse(Console.ReadLine(), out k);
            }

            Array.Sort(numbers);

            foreach (var item in numbers)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            int index = Array.BinarySearch(numbers, k);
            if (index>=0)
            {
                Console.WriteLine("Max number <= K: {0}",numbers[index]);
            }
            else
            {
                int positiveIndex = ~index;
                if (positiveIndex==0)
                {
                    Console.WriteLine("There is no number <= K");
                    goto Finish;
                }
                if (positiveIndex >= numbers.Length)
                {
                    Console.WriteLine("Max number <= K: {0}", numbers[numbers.Length - 1]);
                }
                else
                {
                    Console.WriteLine("Max number <= K: {0}", numbers[positiveIndex - 1]);
                }
            }
            Finish:
            Console.ReadKey();
        }
    }
}
