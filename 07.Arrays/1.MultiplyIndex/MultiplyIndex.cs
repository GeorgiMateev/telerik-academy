using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.MultiplyIndex
{
    class MultiplyIndex
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            for (int i = 0; i < 20; i++)
            {
                numbers[i] = i * 5;
                Console.WriteLine(numbers[i]);
            }

            Console.ReadKey(true);
        }
    }
}
