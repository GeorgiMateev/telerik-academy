using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.ShowTheProduct
{
    class ShowTheProduct
    {
        static void Main(string[] args)
        {
            double a;
            while (true)
            {
                try
                {
                    a = double.Parse(Console.ReadLine());
                    if (a==0)
                    {
                        throw new ArgumentException("Don't enter 0!");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only numbers!");
                }
               

                catch (ArgumentException err)
                {
                    Console.WriteLine(err.Message);
                }
            }
            double b;
            while (true)
            {
                try
                {
                    b = double.Parse(Console.ReadLine());
                    if (b == 0)
                    {
                        throw new ArgumentException("Don't enter 0!");
                    }
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
                catch (ArgumentException err)
                {
                    Console.WriteLine(err.Message);
                }
            }
            double c;
            while (true)
            {
                try
                {
                    c = double.Parse(Console.ReadLine());
                    if (c == 0)
                    {
                        throw new ArgumentException("Don't enter 0!");
                    }
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
                catch (ArgumentException err)
                {
                    Console.WriteLine(err.Message);
                }
            }
            bool isPositive = false;

            if (a > 0 && b > 0 && c > 0)
            {
                isPositive = true;
            }

            if (a < 0 && b < 0 && c < 0)
            {
                isPositive = false;
            }

            bool isOneNegative = (a > 0 && b > 0 && c < 0) || (a > 0 && b < 0 && c > 0) || (a < 0 && b > 0 && c > 0);
            bool isOnePositive = (a > 0 && b < 0 && c < 0) || (a < 0 && b < 0 && c > 0) || (a < 0 && b > 0 && c < 0);
            if (isOneNegative)
            {
                isPositive = false;
            }
            if (isOnePositive)
            {
                isPositive = true;
            }

            if (isPositive)
            {
                Console.WriteLine("The expresion is positive!");
            }
            else
            {
                Console.WriteLine("The expresion is negative!");
            }
            Console.ReadKey(false);
        }
    }
}
