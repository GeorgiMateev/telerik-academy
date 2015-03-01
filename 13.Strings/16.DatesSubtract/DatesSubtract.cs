using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16.DatesSubtract
{
    class DatesSubtract
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dates in format dd.mm.yyyy");

            Console.Write("Date 1: ");
            string date1str = Console.ReadLine();

            Console.Write("Date 2: ");
            string date2str = Console.ReadLine();

            DateTime date1 = new DateTime();
            DateTime date2=new DateTime();
            try
            {
                date1 = DateTime.Parse(date1str);
                date2 = DateTime.Parse(date2str);
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect date!");
            }

            TimeSpan distance = date1 - date2;

            Console.WriteLine("Distance: {0:dd} days",distance);

            Console.ReadKey();
        }
    }
}
