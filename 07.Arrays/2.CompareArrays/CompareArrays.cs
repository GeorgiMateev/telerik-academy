using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.CompareArrays
{
    class CompareArrays
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
            string[] firstArr = new string[n];
            Console.WriteLine("Enter {0} string elements!",n);
            for (int i = 0; i < n; i++)
            {
                firstArr[i] = Console.ReadLine();
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
            string[] secondArr = new string[m];
            Console.WriteLine("Enter {0} string elements!", m);
            for (int i = 0; i < m; i++)
            {
                secondArr[i] = Console.ReadLine();
            }

            bool isSame = true;
            if (n!=m)
            {
                isSame = false;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (firstArr[i]!=secondArr[i])
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
