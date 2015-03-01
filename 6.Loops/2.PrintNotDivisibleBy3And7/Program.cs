using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.PrintNotDivisibleBy3And7
{
    class NotDivisible
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only integer number!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter smaller integer number!");
                }
            }

            for (int i = 0; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write("{0} ", i);
                }
            }

            Console.ReadKey(true);
        }
    }
}
