using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.RandomNumbers
{
    class RandomNumbers
    {
        const int MIN = 100;
        const int MAX = 200;

        static void Main(string[] args)
        {
            Random random = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                int rand = random.Next(MIN, MAX);
                Console.WriteLine(rand);
            }

            Console.ReadKey();
        }
    }
}
