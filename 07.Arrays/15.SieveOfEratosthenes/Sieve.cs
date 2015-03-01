using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15.SieveOfEratosthenes
{
    class Sieve
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            numbers[0] = 0;
            numbers[1] = 1;
            Console.WriteLine("1.Preparing numbers...");
            for (int i = 2; i < n; i++)
            {
                numbers[i] = i;
            }

            Console.WriteLine("2.Calculating...");

            int p = 2;
            while (p*p<=n)
            {
                for (int i = 0; i < numbers.Length; i++ )
                {
                    if (numbers[i] != p && numbers[i] % p == 0)
                    {
                        numbers[i] = -1;
                    }
                }
                p++;
            }

            foreach (var item in numbers)
            {
                if (item != -1)
                {
                    Console.Write("{0} ", item);
                }
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
