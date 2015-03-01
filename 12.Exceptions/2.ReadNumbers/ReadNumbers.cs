using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.ReadNumbers
{
    class ReadNumbers
    {
        /// <summary>
        /// Reads a number from the console.
        /// </summary>
        /// <param name="start">The minimum value of the number.</param>
        /// <param name="end">"The maximum value of the console."</param>
        /// <returns></returns>
        public static int ReadNumber(int start, int end)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number<start || number>end)
                {
                    throw new ArgumentOutOfRangeException("The number is not in the given interval");
                }
                return number;
            }
            catch (FormatException e)
            {
                throw new InvalidOperationException("Invalid number.",e);
            }
            catch (OverflowException e)
            {
                throw new InvalidOperationException("Too big number.",e);
            }

        }

        static void Main(string[] args)
        {
            int numberCount = 10;
            Console.WriteLine("Enter {0} numbers in increasing order:",numberCount);

            List<int> numbers = new List<int>();
            int start = 0;
            while (numbers.Count<numberCount)
            {
                try
                {
                    Console.Write("Number {0} = ", numbers.Count + 1);
                    int n = ReadNumber(start + 1, 100);
                    numbers.Add(n);
                    start = n;
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("The number should be bigger than previous and smaller than 100!");
                }
            }

            Console.ReadKey();
        }
    }
}
