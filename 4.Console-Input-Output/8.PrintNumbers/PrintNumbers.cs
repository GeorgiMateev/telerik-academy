using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.PrintNumbers
{
    class PrintNumbers
    {
        static void Main(string[] args)
        {
            int n;
            bool isCorrectN = false;
            do
            {
                Console.Write("n = "); string inN = Console.ReadLine();
                if (int.TryParse(inN, out n))
                {
                    isCorrectN = true;
                }
                else
                {
                    Console.WriteLine("Enter only integer numbers!");
                    Console.WriteLine();
                }
            }
            while (!isCorrectN);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey(false);
        }
    }
}
