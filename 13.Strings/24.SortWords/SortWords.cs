using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _24.SortWords
{
    class SortWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Words:");
            string text = Console.ReadLine();

            string[] words = text.Split(' ');
            Array.Sort(words);

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
