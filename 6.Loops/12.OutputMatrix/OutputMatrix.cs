using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.OutputMatrix
{
    class OutputMatrix
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
                    if (n <= 0 || n>=20)
                    {
                        throw new ArgumentOutOfRangeException("Enter only integer number between 1 and 20 !");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only integer number between 1 and 20!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter smaller integer number!");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Enter integer number between 1 and 20");
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    Console.Write("{0} ", col + row);
                }
                Console.WriteLine();
            }

            Console.ReadKey(true);
        }
    }
}
