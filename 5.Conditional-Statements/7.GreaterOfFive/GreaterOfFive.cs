using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.GreaterOfFive
{
    class GreaterOfFive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter five numbers!");

            decimal a;
            while (true)
            {
                try
                {
                    a = decimal.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only numbers!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter smaller number!");
                }
            }

            decimal b;
            while (true)
            {
                try
                {
                    b = decimal.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only numbers!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter smaller number!");
                }
            }

            decimal c;
            while (true)
            {
                try
                {
                    c = decimal.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only numbers!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter smaller number!");
                }
            }

            decimal d;
            while (true)
            {
                try
                {
                    d = decimal.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only numbers!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter smaller number!");
                }
            }

            decimal e;
            while (true)
            {
                try
                {
                    e = decimal.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only numbers!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter smaller number!");
                }
            }

            decimal max = 0;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            if (c>max)
            {
                max = c;
            }
            if (d>max)
            {
                max = d;
            }
            if (e>max)
            {
                max = e;
            }

            Console.WriteLine("The greatest number is: {0}",max);
            Console.ReadKey(true);
        }
    }
}
