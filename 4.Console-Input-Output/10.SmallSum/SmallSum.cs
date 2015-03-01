using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.SmallSum
{
    class SmallSum
    {
        static void Main(string[] args)
        {
            double sum = 0;

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
                sum += 1.0 / i;
            }

            Console.WriteLine("sum = {0:F3}",sum);

            Console.ReadKey(false);
        }
    }
}
