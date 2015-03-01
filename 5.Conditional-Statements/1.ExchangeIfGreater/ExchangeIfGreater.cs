using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            int a;
            while (true)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
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
            int b;
            while (true)
            {
                try
                {
                    b = int.Parse(Console.ReadLine());
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

            if (a>b)
            {
                int x = a;
                a = b;
                b = x;
                Console.WriteLine("The first was bigger and I changed them!");
                Console.WriteLine("{0}, {1}",a,b);
            }
            else
            {
                Console.WriteLine("The second was bigger and I did't changed them!");
                Console.WriteLine("{0}, {1}", a, b);
            }

            Console.ReadKey(false);
        }
    }
}
