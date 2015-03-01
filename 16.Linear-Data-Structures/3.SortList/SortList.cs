using System;
using System.Collections.Generic;

namespace _3.SortList
{
    class Sort
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            while (true)
            {
                string line = Console.ReadLine();
                int number = 0;
                if (int.TryParse(line, out number))
                {
                    numbers.Add(number);
                }
                else
                {
                    break;
                }
            }

            numbers.Sort();

            foreach (var item in numbers)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
        }
    }
}
