using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.MinAndMax
{
    class MinAndMax
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

            int[] numbers = new int[100];

            for (int i = 0; i < n; i++)
            {
                int k;
                while (true)
                {
                    try
                    {
                        k = int.Parse(Console.ReadLine());
                        numbers[i] = k;
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
            }

            int min = int.MaxValue; int max = 0;
            for (int i = 0; i < n; i++)
            {
                if (numbers[i]>max)
                {
                    max = numbers[i];
                }
                if (numbers[i]<min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine("min = {0}; max = {1}",min,max);

            Console.ReadKey(true);
        }
    }
}
