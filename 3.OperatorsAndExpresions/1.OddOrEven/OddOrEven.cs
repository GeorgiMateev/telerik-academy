using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool isEven = n % 2 == 0;
            if (isEven)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            Console.ReadKey(false);
        }
    }
}
