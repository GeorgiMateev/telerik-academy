using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.CountSubstrings
{
    class Program
    {
        public static int CountSubstrings(string str, string substr)
        {
            int counter = 0;
            int startIndex = 0;
            while (true)
            {
                startIndex = str.IndexOf(substr, startIndex,StringComparison.InvariantCultureIgnoreCase);
                if (startIndex>=0)
                {
                    counter++;
                }
                else
                {
                    return counter;
                }
                startIndex += substr.Length;
                if (startIndex>=str.Length)
                {
                    return counter;
                }
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
