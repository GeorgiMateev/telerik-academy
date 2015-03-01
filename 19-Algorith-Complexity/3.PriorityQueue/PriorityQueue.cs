using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace _3.PriorityQueue
{
    class PriorityQueue<T> where T: IComparable<T>
    {
        class DefaultComparer<T> : IComparer<T> where T : IComparable<T>
        {
            public int Compare(T x, T y)
            {
                return x.CompareTo(y);
            }
        }

        private OrderedBag<T> queue;
        private IComparer<T> comparer;

        public int Count
        {
            get { return queue.Count; }
        }

        public PriorityQueue()
        {
            this.queue = new OrderedBag<T>();
            this.comparer = new DefaultComparer<T>();
        }
        public PriorityQueue(IComparer<T> comparer)
        {
            this.queue = new OrderedBag<T>();
            this.comparer = comparer;
        }

        public void Enqueue(T item)
        {
            this.queue.Add(item);
        }

        public T DequeueSmallest()
        {
            T smallest = this.queue.GetFirst();
            this.queue.RemoveFirst();
            return smallest;
        }
    }
}
