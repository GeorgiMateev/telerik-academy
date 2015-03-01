using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _4.HashTable;

namespace _5.Set
{
    class HashedSet<T> : IEnumerable<T>
    {
        private HashTable<T, T> set;

        public int Count
        {
            get { return this.set.Count; }
        }
        public int Capacity
        {
            get { return this.set.Capacity; }
        }

        public HashedSet()
        {
            this.set = new HashTable<T, T>();
        }
        public HashedSet(int capacity)
        {
            this.set = new HashTable<T, T>(capacity);
        }

        public void Add(T element)
        {
            this.set.Add(element, element);
        }

        public T Find(T element)
        {
            return this.set.FindValue(element);
        }

        public void Remove(T element)
        {
            this.set.Remove(element);
        }

        public void Clear()
        {
            this.set.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.set)
            {
                yield return item.Value;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
