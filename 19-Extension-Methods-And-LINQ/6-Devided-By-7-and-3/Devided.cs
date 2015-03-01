using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_Devided_By_7_and_3
{
    class Devided
    {
        private static IEnumerable<int> FindDevidedWithExtensions(int[] numbers)
        {
            return numbers.Where(x => x % 3 == 0 && x % 7 == 0);
        }
        private static IEnumerable<int> FindDevidedWithLINQ(int[] numbers)
        {
            return
                from number in numbers
                where number % 3 == 0 && number % 7 == 0
                select number;
        }

        static void Main(string[] args)
        {
            int[] numbers = new 
                int[] {4,5,3,6,2,5,235,5,30504,12,4,6,25,234234,1,2144,23,235,235,235,23,56754,1,9799,6457,85,5674242,7223, };

            var resultWithExtension = FindDevidedWithExtensions(numbers);
            var resultWithLINQ = FindDevidedWithLINQ(numbers);

            Console.WriteLine("Result with extension methods:");
            foreach (var item in resultWithExtension)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("Result with LINQ:");
            foreach (var item in resultWithLINQ)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
