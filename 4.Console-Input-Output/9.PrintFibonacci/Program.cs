using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _9.PrintFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger a, b, c;
            a = 1;
            b = 1;
            Console.Write("{0}, {1}", a, b);

            int count = 3;
            while(count<=100)
            {
                c = a + b;
                Console.Write(", {0}", c);
                a = b;
                b = c;
                count++;
            }

            Console.ReadKey(false);
        }
    }
}
