using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.CalculateSum
{
    class CalculateSum
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

            int sum = 0;

            Console.WriteLine("Enter {0} numbers:",n);
            for (int i = 0; i < n; i++)
            {
                int m;
                bool isCorrectM = false;
                do
                {
                    string inM = Console.ReadLine();
                    if (int.TryParse(inM, out m))
                    {
                        isCorrectM = true;
                    }
                    else
                    {
                        Console.WriteLine("Enter only integer numbers!");
                        Console.WriteLine();
                    }
                }
                while (!isCorrectM);
                sum += m;
            }

            Console.WriteLine("Enter more {0} numbers:",n);
            for (int i = 0; i < n; i++)
            {
                int m;
                bool isCorrectM = false;
                do
                {
                    string inM = Console.ReadLine();
                    if (int.TryParse(inM, out m))
                    {
                        isCorrectM = true;
                    }
                    else
                    {
                        Console.WriteLine("Enter only integer numbers!");
                        Console.WriteLine();
                    }
                }
                while (!isCorrectM);
                sum += m;
            }

            Console.WriteLine("sum = {0}",sum);

            Console.ReadKey(false);
        }
    }
}
