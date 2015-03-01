using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.SortStrings
{
    class SortStrings_
    {
        static void Main(string[] args)
        {
            string[] strings = new string[5]
            {
                "xaxaxaxax","gosho","100milionaleva","qwerty","asd"
            };
            foreach (var item in strings)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            var sortedStrings = SortStrings(strings);

            foreach (var item in sortedStrings)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            Console.ReadKey();
        }

        static IOrderedEnumerable<string> SortStrings(string[] strings)
        {
            return strings.OrderBy(x => x.Length);
        }
    }
}
