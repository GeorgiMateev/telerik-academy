using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintCurrentDateTime
{
    class PrintCurrentdateTime
    {
        static void Main(string[] args)
        {
            string currentDate = DateTime.Now.ToShortDateString();
            string currentTime = DateTime.Now.ToShortTimeString();
            Console.WriteLine("Date: {0} Time: {1}",currentDate,currentTime);

            Console.ReadKey(false);
        }
    }
}
