using System;
using System.Collections.Generic;

namespace _2.ReverseSequence
{
    class ReverseSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Push(number);
            }

            Console.WriteLine();

            while (numbers.Count>0)
            {
                Console.Write("{0} ",numbers.Pop());
            }
            Console.ReadKey();
        }
    }
}
