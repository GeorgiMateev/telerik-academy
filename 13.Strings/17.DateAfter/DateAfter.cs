using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17.DateAfter
{
    class DateAfter
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter date and time in format day.month.year hour:minute:second");
            string dateTimeStr = "13.02.2020 13:03:14";
            string format = "dd.MM.yyyy HH:mm:ss";

            DateTime dateAndTime =new DateTime();
            try
            {
                dateAndTime = DateTime.ParseExact
                    (dateTimeStr,format,System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (FormatException )
            {
                Console.WriteLine("Incorrect format!");
            }

            DateTime after = dateAndTime.Add(new TimeSpan(6, 30, 0));

            string formatDate = after.ToString(format, System.Globalization.CultureInfo.InvariantCulture);
            string dayOfWeek = DateTime.Now.ToString("dddd",new System.Globalization.CultureInfo("bg-BG"));
            Console.WriteLine(formatDate+" "+dayOfWeek);

            Console.ReadKey();
        }
    }
}
