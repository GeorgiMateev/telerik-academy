using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.CatalanNumbers
{
    class CatalanNumbers
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
                        throw new ArgumentOutOfRangeException("Enter only integer number >= 0 !");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only integer number >= 0!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter smaller integer number!");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Enter integer number >= 0!");
                }
            }
            try
            {           
                UInt64 ch = Factorial(2 * n);
                UInt64 zn = Factorial(n + 1) * Factorial(n);
                UInt64 C = ch / zn;           

                Console.WriteLine("C{0} = {1}",n,C);
            }
            catch (OverflowException err)
            {
                Console.WriteLine(err.Message);
            }

            Console.ReadKey(true);
        }
        static UInt64 Factorial(int n)
        {
            UInt64 fact = 1;
            try
            {
                for (uint i = 1; i <= n; i++)
                {
                    checked
                    {
                        fact *= i;
                    }
                }
            }
            catch (OverflowException err)
            {
                throw new OverflowException("The result is too big!", err);
            }
            return fact;
        }
    }
}
