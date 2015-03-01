using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.DividedBy5and7
{
    class DividedBy5And7
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isDivisible = n % 7 == 0 && n % 5 == 0;
            if (isDivisible)
            {
                Console.WriteLine("Can be divided by 5 and 7!");
            }
            else
            {
                Console.WriteLine("Can NOT be divided by 5 and 7!");
            }

            Console.ReadKey(false);
        }
    }
}
