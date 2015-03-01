using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            StringBuilder rev = new StringBuilder(str.Length);
            for (int i = str.Length-1; i >= 0; i--)
            {
                rev.Append(str[i]);
            }

            Console.WriteLine(rev.ToString());

            Console.ReadKey();
        }
    }
}
