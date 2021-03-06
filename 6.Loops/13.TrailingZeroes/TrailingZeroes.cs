﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _13.TrailingZeroes
{
    class TrailingZeroes
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

            BigInteger fact = Factorial(n);
            Console.WriteLine(fact);
            Console.ReadKey(true);
        }
        static BigInteger Factorial(int n)
        {
            BigInteger fact = 1;
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
