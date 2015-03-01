using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_BiDictionary
{
    
    class BiDictionary<K1,K2,T>
    {
        private Dictionary<K1, T> firstKeyDictionary;
        private Dictionary<K2, T> secondKeyDictionary;

        public int Count
        {
            get { return firstKeyDictionary.Count; }
        }

        public BiDictionary()
        {
            this.firstKeyDictionary = new Dictionary<K1, T>();
            this.secondKeyDictionary = new Dictionary<K2, T>();
        }
        public BiDictionary(int capacity)
        {
            this.firstKeyDictionary = new Dictionary<K1, T>(capacity);
            this.secondKeyDictionary = new Dictionary<K2, T>(capacity);
        }

        public void Add(K1 key1, K2 key2, T value)
        {
            this.firstKeyDictionary.Add(key1, value);
            this.secondKeyDictionary.Add(key2,value);
        }

        public T this[K1 key1]
        {
            get { return this.firstKeyDictionary[key1]; }
        }
        public T this[K2 key2]
        {
            get { return this.secondKeyDictionary[key2]; }
        }
        public T this[K1 key1,K2 key2]
        {
            get { return this.firstKeyDictionary[key1]; }
        }
    }
}
