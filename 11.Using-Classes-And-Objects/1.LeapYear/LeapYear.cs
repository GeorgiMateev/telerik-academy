using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.Write("Year = ");
            int year = int.Parse(Console.ReadLine());

            bool isLeap = DateTime.IsLeapYear(year);

            if (isLeap)
            {
                Console.WriteLine("Is leap.");
            }
            else
            {
                Console.WriteLine("Is not leap.");
            }

            Console.ReadKey();
        }
    }
}
