using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.Set
{
    class TestHashedSet
    {
        public static void Main()
        {
            HashedSet<string> set = new HashedSet<string>(10);
            StringBuilder str = new StringBuilder();
            for (int i = 1; i <= 20; i++)
            {
                str.Append(i.ToString());
                set.Add(str.ToString());
            }

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Count: {0}",set.Count);
                        
            set.Remove("12345");
            try
            {
                set.Find("12345");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Count: {0}", set.Count);

            Console.ReadKey();
        }
    }
}
