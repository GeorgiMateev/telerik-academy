using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                try
                {
                    Console.Write("N = ");
                    n = int.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        throw new ArgumentOutOfRangeException("Enter only integer number >= 3 !");
                    }
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
            UInt64 a = 1;
            UInt64 b = 1;
            UInt64 c = 0;
            Console.Write("{0}, {1}, ",a,b);

            try
            {
                for (int i = 3; i <= n; i++)
                {
                    checked
                    {
                        c = a + b;
                        b = a;
                        a = c;
                    }
                    Console.Write("{0}, ", c);
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("They are getting too big!");
            }

            Console.ReadKey(true);
        }
    }
}
