using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14.CycleQueue
{
    class TestCycleQueue
    {
        public static void Main()
        {
            CycleQueue<int> queue = new CycleQueue<int>();

            queue.Enqueue(22);
            queue.Enqueue(99);
            queue.Clear();

            for (int i = 1; i <= 5; i++)
            {
                queue.Enqueue(i);
            }
            Console.WriteLine(queue.Count);

            for (int i = 6; i <= 10; i++)
            {
                queue.Enqueue(i);
            }
            Console.WriteLine(queue.Count);

            while(queue.Count>5)
            {
                Console.Write("{0} ", queue.Dequeue());
            }
            Console.WriteLine();
            Console.WriteLine(queue.Count);

            queue.Enqueue(1000);
            queue.Enqueue(2000);

            Console.WriteLine(queue.Peek());

            while (queue.Count>0)
            {
                Console.Write("{0} ",queue.Dequeue());
            }

            Console.ReadKey();
        }
    }
}
