using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.BiggestOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            while (true)
            {
                try
                {
                    a = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only numbers!");
                }
             
            }
            double b;
            while (true)
            {
                try
                {
                    b = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only numbers!");
                }
               
            }
            double c;
            while (true)
            {
                try
                {
                    c = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only numbers!");
                }
               
            }

            double max = 0;
            if (a>b)
            {
                if (b>c)
                {
                    max = a;
                }
                else if (a>c)
                {
                    max = a;
                }
                else
                {
                    max = c;
                }
            }
            else if (b<c)
            {
                max = c;
            }
            else
            {
                max = b;
            }
            Console.WriteLine("Max number is {0}",max);

            Console.ReadKey(false);
        }
    }
}
