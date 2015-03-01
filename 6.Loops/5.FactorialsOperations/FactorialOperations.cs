using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.FactorialsOperations
{
    class FactorialOperations
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
            Int64 factK_N = 0;
            double calculation = 0;

            try
            {
                factN = Factorial(n);
                factK = Factorial(k);
                factK_N = Factorial(k-n);

                calculation = factN * factK / factK_N;

            }
            catch (OverflowException)
            {
                Console.WriteLine("The result is too big!");
            }


            Console.WriteLine("N!*K!/(K-N)! = {0}",calculation);
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
