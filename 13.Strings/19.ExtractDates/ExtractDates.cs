using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _19.ExtractDates
{
    class Extract_Dates
    {
        public static DateTime[] ExtractDates(string text)
        {
            string pattern = "\\b[0-9]{2}[.][0-9]{2}[.][0-9]{4}\\b";
            MatchCollection matches = Regex.Matches(text, pattern);
            List<DateTime> dates = new List<DateTime>();

            foreach (var item in matches)
            {
                Match match = (Match)item;
                DateTime date = new DateTime();
                bool isCorrect = DateTime.TryParse(match.Value,out date);
                if (isCorrect)
                {
                    dates.Add(date);
                }
            }

            return dates.ToArray();
        }

        static void Main(string[] args)
        {
        }
    }
}
