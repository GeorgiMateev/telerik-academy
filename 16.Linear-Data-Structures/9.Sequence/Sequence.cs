using System;
using System.Collections.Generic;

namespace _9.Sequence
{
    class Sequence
    {        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int> elements = new Queue<int>();
            elements.Enqueue(n);

            for(int i = 0; i<50; i++)
            {
                int current = elements.Dequeue();
                Console.WriteLine(current);

                elements.Enqueue(current + 1);
                elements.Enqueue(2 * current + 1);
                elements.Enqueue(current + 2);
            }
        }
    }
}
