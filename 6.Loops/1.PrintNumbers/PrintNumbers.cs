using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.PrintNumbers
{
    class PrintNumbers
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
                Console.Write("{0} ", i);
            }

            Console.ReadKey(true);
        }
    }
}
