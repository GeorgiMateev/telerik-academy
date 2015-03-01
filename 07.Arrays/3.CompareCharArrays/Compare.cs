using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.CompareCharArrays
{
    class Compare
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                try
                {
                    Console.Write("Enter lenght of the first array:");
                    n = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only integer numbers!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter smaller integer numbers!");
                }
            }
            char[] firstArr = new char[n];
            Console.WriteLine("Enter {0} char elements! (If you put string only the first letter will be taken!)", n);
            for (int i = 0; i < n; i++)
            {
                string input = (Console.ReadLine());
                firstArr[i] = input[0];
            }

            int m;
            while (true)
            {
                try
                {
                    Console.Write("Enter lenght of the second array:");
                    m = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only integer numbers!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter smaller integer numbers!");
                }
            }
            char[] secondArr = new char[m];
            Console.WriteLine("Enter {0} char elements! (If you put string only the first letter will be taken!)", m);
            for (int i = 0; i < m; i++)
            {
                string input = (Console.ReadLine());
                secondArr[i] = input[0];
            }

            bool isSame = true;
            if (n != m)
            {
                isSame = false;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (firstArr[i] != secondArr[i])
                    {
                        isSame = false;
                    }
                }
            }
            if (isSame)
            {
                Console.WriteLine("They are same!");
            }
            else
            {
                Console.WriteLine("They are NOT same!");
            }

            Console.ReadLine();
        }
    }
}
