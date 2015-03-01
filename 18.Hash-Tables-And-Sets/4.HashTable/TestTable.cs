using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.HashTable
{
    class TestTable
    {
        public static void Main()
        {
            HashTable<string, string> table = new HashTable<string, string>(10);
            StringBuilder  str = new StringBuilder();
            for (int i = 1; i <= 100; i++)
            {
                str.Append(i);
                table.Add(i.ToString(), str.ToString());
            }

            table.Remove("10");

            foreach (var item in table)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }

            Console.WriteLine("Count: {0}",table.Count);

            Console.WriteLine(table["5"]);

            try
            {
                Console.WriteLine(table["11"]);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            table.Clear();
            Console.WriteLine("Count: {0}",table.Count);

            Console.ReadKey();
        }
    }
}
