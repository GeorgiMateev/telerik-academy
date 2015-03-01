using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.QuadraticEqulation
{
    class Equlation
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

            double D = b * b - 4 * a * c;
            if (D<0)
            {
                Console.WriteLine("There is no roots!");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(D)) / 2*a;
                double x2 = (-b - Math.Sqrt(D)) / 2 * a;
                if (x1==x2)
                {
                    Console.WriteLine("The only root is {0}",x1);
                }
                else
                {
                    Console.WriteLine("The roots are {0} and {1}", x1, x2);
                }
            }

            Console.ReadKey(true);
        }
    }
}
