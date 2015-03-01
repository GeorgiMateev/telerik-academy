using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _4.HashTable
{
    public class HashTable<T,K> : IEnumerable<KeyValuePair<K,T>>
    {
        private LinkedList<KeyValuePair<K, T>>[] elements;

        private const float RESIZE_FACTOR = 0.75f;
        public float LoadFactor
        {
            get { return (float)this.Count / (float)this.Capacity; }
        }
        
        int capacity;
        public int Capacity
        {
            get { return capacity; }
        }

        private int count;
        public int Count
        {
            get { return this.count; }
        }
        
        public HashTable()
        {
            this.capacity = 16;
            this.elements = new LinkedList<KeyValuePair<K, T>>[this.capacity];
            this.count = 0;
        }
        public HashTable(int capacity)
        {
            this.capacity = capacity;
            this.elements = new LinkedList<KeyValuePair<K, T>>[this.capacity];
            this.count = 0;
        }

        public void Add(K key, T value)
        {
            KeyValuePair<K,T> element = new KeyValuePair<K,T>(key,value);
            int index = GetHashIndex(element.Key);
            InsertElement(this.elements, element, index);
            if (this.LoadFactor >= RESIZE_FACTOR)
            {
                ResizeHashTable();
            }
        }
        public T FindValue(K key)
        {
            int index = GetHashIndex(key);

            if (this.elements[index] == null)
            {
                throw new ArgumentException("The key doesn't exist!");
            }

            LinkedList<KeyValuePair<K,T>> list = this.elements[index];
            foreach (var item in list)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }

            throw new ArgumentException("The key doesn't exist!");
        }
        public void Remove(K key)
        {
            int index = GetHashIndex(key);

            if (this.elements[index] == null)
            {
                throw new ArgumentException("The key doesn't exist!");
            }

            LinkedList<KeyValuePair<K, T>> list = this.elements[index];
            LinkedListNode<KeyValuePair<K, T>> current = list.First;
            while (current != null)
            {
                if (current.Value.Key.Equals(key))
                {
                    list.Remove(current);
                    this.count--;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentException("The key doesn't exist!");
        }
        public void Clear()
        {
            LinkedList<KeyValuePair<K, T>>[] newElements = new LinkedList<KeyValuePair<K, T>>[16];
            this.elements = newElements;
            this.count = 0;
            this.capacity = 16;
        }
        public T this[K key]
        {
            get { return this.FindValue(key); }
            set { ModifyValue(key, value); }
        }       

        private void ResizeHashTable()
        {
            LinkedList<KeyValuePair<K, T>>[] newElements = new LinkedList<KeyValuePair<K, T>>[capacity*2];
            this.capacity *= 2;
            this.count = 0;
            foreach (var listOfPairs in this.elements)
            {
                if (listOfPairs != null)
                {
                    foreach (var pair in listOfPairs)
                    {
                        int index = GetHashIndex(pair.Key);
                        InsertElement(newElements, pair, index);
                    }
                }
            }
            this.elements = newElements;
        }

        private void ModifyValue(K key, T value)
        {
            int index = GetHashIndex(key);

            if (this.elements[index] == null)
            {
                throw new ArgumentException("The key doesn't exist!");
            }

            LinkedList<KeyValuePair<K, T>> list = this.elements[index];
            LinkedListNode<KeyValuePair<K, T>> current = list.First;
            while(current != null)
            {                
                if (current.Value.Key.Equals(key))
                {
                    current.Value = new KeyValuePair<K,T>(key,value);
                    return;
                }
                current = current.Next;
            }
        }

        private void InsertElement(LinkedList<KeyValuePair<K,T>>[] elements, KeyValuePair<K,T> element, int index)
        {
            if (elements[index] != null)
            {
                elements[index].AddLast(new LinkedListNode<KeyValuePair<K,T>>(element));
            }
            else
            {
                elements[index] = new LinkedList<KeyValuePair<K, T>>();
                elements[index].AddFirst(new LinkedListNode<KeyValuePair<K, T>>(element));
            }
            count++;
        }

        private int GetHashIndex(K key)
        {
            uint hashCode = (uint)key.GetHashCode();
            return (int)(hashCode % this.capacity);
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            foreach (var chain in this.elements)
            {
                if (chain != null)
                {
                    foreach (var element in chain)
                    {
                        yield return element;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
