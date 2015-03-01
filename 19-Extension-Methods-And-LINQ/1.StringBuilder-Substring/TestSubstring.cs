using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.StringBuilder_Substring
{
    class TestSubstring
    {
        public static void Main()
        {
            StringBuilder str = new StringBuilder("Sample string to be tested.");
            StringBuilder substring = str.GetSubstring(5, 6);
            Console.WriteLine(substring.ToString());

            Console.ReadKey();
        }
    }
}
