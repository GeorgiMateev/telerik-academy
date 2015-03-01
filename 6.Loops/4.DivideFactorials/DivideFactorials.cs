using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _4.DivideFactorials
{
    class DivideFactorials
    {
        static void Main(string[] args)
        {
            int k;
            while (true)
            {
                try
                {
                    Console.Write("K = ");
                    k = int.Parse(Console.ReadLine());
                    if (k<=1)
                    {
                        throw new ArgumentOutOfRangeException("Enter only integer number larger than 1!");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only integer number larger than 1!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter smaller integer number larger than 1!");
                }
                catch (ArgumentOutOfRangeException err)
                {
                    Console.WriteLine(err.Message);
                }
            }

            int n;
            while (true)
            {
                try
                {
                    Console.Write("N = ");
                    n = int.Parse(Console.ReadLine());
                    if (n<=0 || n>=k)
                    {
                        throw new ArgumentOutOfRangeException("Enter integer number larger than 1 and less than K!");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter integer number larger than 1 and less than K!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter smaller integer number larger than 1 and less than K!");
                }
                catch (ArgumentOutOfRangeException err)
                {
                    Console.WriteLine(err.Message);
                }
            }

            Int64 factN = 0;
            Int64 factK = 0;

            try
            {
                factN = Factorial(n);
                factK = Factorial(k);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The result is too big!");
            }

            double calculation = (double)Factorial(n) / (double)Factorial(k);

            Console.WriteLine(
@"N! = {0};
K! = {1}",factN,factK);
            Console.WriteLine("{0}!/{1}! = {2}",n,k,calculation);

            Console.ReadKey(true);
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
