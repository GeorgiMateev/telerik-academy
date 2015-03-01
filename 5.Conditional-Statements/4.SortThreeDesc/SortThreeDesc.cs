using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.SortThreeDesc
{
    class SortThreeDesc
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
            double min = 0;
            double mid = 0;

            if (a > b)
            {
                if (b > c)
                {
                    max = a;
                }
                else if (a > c)
                {
                    max = a;
                }
                else
                {
                    max = c;
                }
            }
            else if (b < c)
            {
                max = c;
            }
            else
            {
                max = b;
            }

            if (max==a)
            {
                if (b>c)
                {
                    min = c;
                    mid = b;
                }
                else
                {
                    min = b;
                    mid = c;
                }
            }
            else if(max==b)
            {
                if (a>c)
                {
                    mid = a;
                    min = c;
                }
                else
                {
                    mid = c;
                    min = a;
                }
            }
            else
            {
                if (a>b)
                {
                    mid = a;
                    min = b;
                }
                else
                {
                    mid = b;
                    min = a;
                }
            }

            Console.WriteLine("{0} > {1} > {2}",max,mid,min);

            Console.ReadKey(false);
        }
    }
}
