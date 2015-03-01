using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.Workdays
{
    public class Workdays
    {
        public static int CountWorkdays(DateTime date, DateTime[] holydays)
        {
            if (date.Year != DateTime.Today.Year)
            {
                throw new ArgumentException("The year must be the same as current!");
            }            
            if (DateTime.Today.CompareTo(date) >= 0)
            {
                throw new ArgumentException("The date should be in the future!");
            }          
            
            int workdayCounter = 0;

            for (int d = 0; d <= date.DayOfYear-DateTime.Today.DayOfYear; d++)
            {
                DateTime currentDate = DateTime.Today.AddDays(d);
                bool isWorkday = currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday;
                bool isHoliday = holydays.Contains(currentDate);
                if (isWorkday&& !isHoliday)
                {
                    workdayCounter++;
                }
            }
            return workdayCounter;
        }

        static void Main(string[] args)
        {
        }
    }
}
