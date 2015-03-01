using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.FindMaxNumber
{
    class MaxNumber
    {
        static int GetMax(int a, int b)
        {
            if (a==b)
            {
                return a;
            }
            if (a>b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            int max = GetMax(a, b);
            max = GetMax(max, c);

            Console.WriteLine("Max = {0}",max);

            Console.ReadKey();
        }
    }
}
