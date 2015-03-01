using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.CountIntegers
{
    class CountIntegers
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3,5,2,6,2,4,5,6,4,8,3,4,5,6,4,3,2,5,7,8,9,7,6,5,6,4,3,2,4,5,7,8,2};
            //int[] numbers = new int[] {};
            //int[] numbers = new int[] { 4};
            Dictionary<int, int> counters = new Dictionary<int, int>();

            foreach (var item in numbers)
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
                Console.WriteLine("{0} -> {1}",item.Key,item.Value);
            }

            Console.ReadKey();
        }
    }
}
