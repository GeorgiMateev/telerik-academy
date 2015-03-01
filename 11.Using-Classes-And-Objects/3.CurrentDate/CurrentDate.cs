using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.CurrentDate
{
    class CurrentDate
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.DayOfWeek.ToString());

            Console.ReadKey();
        }
    }
}
