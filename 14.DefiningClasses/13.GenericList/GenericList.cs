using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13.GenericList
{
    class GenericList<T>
    {
        private int capacity;
        public int Capacity
        {
            get { return capacity; }
        }

        private T[] list;

        private int amount;
        public int Amount
        {
            get { return amount; }
        }

        public GenericList(int capacity)
        {
            if (capacity<0)
            {
                throw new ArgumentOutOfRangeException("The capacity should be non negative value!");
            }
            this.capacity = capacity;
            this.list = new T[capacity]; 
            this.amount=0;
        }

        public T this[int index]
        {            
            get
            {
                if (index<0||index>=amount)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.list[index]; 
            }
            set { this.list[index] = value; /* set the specified index to value here */ }
        }

        public void Add(T item)
        {
            if (amount==capacity)
            {
                this.Enlarge();
            }
            if (amount<capacity)
            {
                list[amount - 1] = item;
            }
            else
            {
                throw new OutOfMemoryException("There is no place for new items!");
            }
        }

        public void RemoveAt(int index)
        {
            if (index<0 || index>=amount)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                for (int i = index; i < amount - 1; i++)
                {
                    list[i] = list[i + 1];
                }
                list[amount - 1] = default(T);
                amount--;
            }
        }

        public void Insert(T item, int index)
        {
            if (index < 0 || index >= amount)
            {
                throw new IndexOutOfRangeException();
            }
            if (amount==capacity)
            {
                this.Enlarge();
            }

            for (int i = amount; i >= index+1; i--)
            {
                list[i] = list[i - 1];
            }
            list[index] = item;
            amount++;
            
        }

        public void Clear()
        {
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = default(T);
            }
            amount = 0;
        }

        public T Find(T item)
        {
            return  this.list.First(x => x.Equals(item));           
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < amount; i++)
            {
                if (i<amount-1)
                {
                    str.Append(this.list[i] + " ");
                }
                else
                {
                    str.Append(this.list[i]);
                }
            }
            return str.ToString();
        }

        private void Enlarge()
        {
            capacity *= 2;
            T[] newList = new T[capacity];
            for (int i = 0; i < amount; i++)
            {
                newList[i] = this.list[i];
            }
            this.list = newList;
        }
    }
}
