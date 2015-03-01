using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.ExtractOdds
{
    class ExtractOdds
    {
        static void Main(string[] args)
        {
            string[] words = new string[] {"C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            Dictionary<string, int> counters = new Dictionary<string, int>();

            foreach (var item in words)
            {
                if (counters.ContainsKey(item))
                {
                    counters[item]++;
                }
                else
                {
                    counters.Add(item, 1);
                }
            }

            foreach (var item in counters)
            {
                if (item.Value % 2 != 0)
                {
                    Console.WriteLine(item.Key + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
