using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.PriorityQueue
{
    class TestQueue
    {
        public static void Main()
        {
            PriorityQueue<int> q = new PriorityQueue<int>();
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                q.Enqueue(rand.Next(1,50));
            }
            
            int min = q.DequeueSmallest();
            Console.WriteLine("Min = {0}",min);

            Console.WriteLine("Rest of the elements:");
            while (q.Count>0)
            {
                Console.Write("{0} ",q.DequeueSmallest());
            }

            Console.ReadKey();
        }
    }
}
