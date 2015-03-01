using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.GCD
{
    class _GCD
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
            int k;
            while (true)
            {
                try
                {
                    k = int.Parse(Console.ReadLine());
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

            int g = GCD(n, k);
            Console.WriteLine("GCD = {0}",g);
            Console.ReadKey(true);
        }

        static int GCD(int x, int y)
        {
            if (x == 0) return y;
            if (y == 0) return x;
            if (x == 0 && y == 0) return 0;

            int a = Math.Abs(x);
            int b = Math.Abs(y);

            while (1 == 1)
            {
                int d = 0;
                if (a < b)
                {
                    int z = a;
                    a = b;
                    b = z;
                }
                if (a % b == 0) return b;
                d = a % b;
                a = b;
                b = d;
            }
        }
    }
}
