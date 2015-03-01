using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.DivisionInInterval
{
    class DivisionInIntervals
    {
        static void Main(string[] args)
        {
            int a;
            bool isCorrectA = false;
            do
            {
                Console.Write("a = "); string inA = Console.ReadLine();
                if (int.TryParse(inA,out a))
                {
                    isCorrectA = true;
                }
                else
                {
                    Console.WriteLine("Enter only numbers!");
                    Console.WriteLine();
                }
            }
            while (!isCorrectA);

            int b;
            bool isCorrectB = false;
            do
            {
                Console.Write("b = "); string inB = Console.ReadLine();
                if (int.TryParse(inB, out b))
                {
                    isCorrectB = true;
                }
                else
                {
                    Console.WriteLine("Enter only numbers!");
                    Console.WriteLine();
                }
            }
            while (!isCorrectB);

            int p = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                }
            }
            Console.WriteLine("p = {0}",p);

            Console.ReadKey(false);
        }
    }
}
