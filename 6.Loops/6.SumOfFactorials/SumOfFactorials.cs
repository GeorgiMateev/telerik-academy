using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.SumOfFactorials
{
    class SumOfFactorials
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
                    Console.WriteLine("Enter only integer number!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter smaller integer number!");
                }                
            }
            int x;
            while (true)
            {
                try
                {
                    Console.Write("X = ");
                    x = int.Parse(Console.ReadLine());
                    if (x == 0)
                    {
                        throw new ArgumentOutOfRangeException("Enter only integer number different than zero!");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only integer number different than zero!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter smaller integer number different than zero!");
                }
                catch (ArgumentOutOfRangeException err)
                {
                    Console.WriteLine(err.Message);
                }
            }

            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Factorial(n) / Math.Pow((double)x, (double)n);
            }

            Console.WriteLine("sum = {0}",sum);
            Console.ReadKey();
        }
        static Int64 Factorial(int n)
        {
            Int64 fact = 1;
            for (int i = 1; i <= n; i++)
            {
                checked
                {
                    fact *= i;
                }
            }
            return fact;
        }
    }
}
