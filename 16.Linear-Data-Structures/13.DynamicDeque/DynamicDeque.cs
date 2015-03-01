using System;
using System.Collections.Generic;

namespace DynamicDeque
{
    /// <summary>
    /// The main deque class.Contains pointers to the first and to the last element.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DynamicDeque<T>
    {
        /// <summary>
        /// Represents single deque item with pointers to the previous and to the next element.
        /// </summary>
        public class DequeItem<T>
        {
            private T element;
            public T Element
            {
                get { return element; }
                set { element = value; }
            }

            private DequeItem<T> previousItem;
            public DequeItem<T> PreviousItem
            {
                get { return previousItem; }
                set { previousItem = value; }
            }

            private DequeItem<T> nextItem;
            public DequeItem<T> NextItem
            {
                get { return nextItem; }
                set { nextItem = value; }
            }

            public DequeItem(T element)
            {
                this.element = element;
                this.previousItem = null;
                this.nextItem = null;
            }
        }

        private DequeItem<T> firstItem;
        public DequeItem<T> FirstItem
        {
            get { return firstItem; }
            set { firstItem = value; }
        }

        private DequeItem<T> lastItem;
        public DequeItem<T> LastItem
        {
            get { return lastItem; }
            set { lastItem = value; }
        }

        private int count;
        public int Count
        {
            get { return count; }
        }

        public DynamicDeque()
        {
            this.firstItem = null;
            this.lastItem = null;
            this.count = 0;
        }

        /// <summary>
        /// Adds element in the beginning of the deque.
        /// </summary>
        public void AddFirst(T element)
        {
            if (this.firstItem==null)
            {
                //The deque is empty.
                DequeItem<T> item = new DequeItem<T>(element);
                this.firstItem = item;
                this.lastItem = firstItem;
            }
            else
            {
                DequeItem<T> item = new DequeItem<T>(element);
                item.NextItem = this.firstItem;
                this.firstItem.PreviousItem = item;
                this.firstItem = item;
            }
            this.count++;
        }

        /// <summary>
        /// Adds element in the end of the deque.
        /// </summary>
        public void AddLast(T element)
        {
            if (this.lastItem==null)
            {
                //The deque is empty.
                DequeItem<T> item = new DequeItem<T>(element);
                this.lastItem = item;
                this.firstItem = this.lastItem;
            }
            else
            {
                DequeItem<T> item = new DequeItem<T>(element);
                item.PreviousItem = this.lastItem;
                this.lastItem.NextItem = item;
                this.lastItem = item;
            }
            count++;
        }

        /// <summary>
        /// Returns and removes the first element of the deque.
        /// </summary>
        public T RemoveFirst()
        {
            if (this.count==0)
            {
                throw new InvalidOperationException("The deque is empty!");
            }

            count--;

            DequeItem<T> item = this.firstItem;

            if (count==0)
            {
                //The deque becomes empty.
                this.firstItem = null;
                this.lastItem = null;
                return item.Element;
            }

            this.firstItem = item.NextItem;
            this.firstItem.PreviousItem = null;

            return item.NextItem.Element;
        }

        /// <summary>
        /// Returns and removes the last element in the deque.
        /// </summary>
        public T RemoveLast()
        {
            if (this.count==0)
            {
                throw new InvalidOperationException("The deque is empty!");
            }

            this.count--;

            DequeItem<T> item = this.lastItem;

            if (count==0)
            {
                //The deque becomes empty.
                this.lastItem = null;
                this.firstItem = null;
                return item.Element;
            }

            this.lastItem = item.PreviousItem;
            this.lastItem.NextItem = null;

            return item.Element;
        }

        /// <summary>
        /// Returns the first element of the deque without removing it.
        /// </summary>
        public T GetFirst()
        {
            if (this.count==0)
            {
                throw new InvalidOperationException("The deque is empty!");
            }

            return this.firstItem.Element;
        }

        /// <summary>
        /// Returns the last element of the deque without removing it.
        /// </summary>
        public T GetLast()
        {
            if (this.count==0)
            {
                throw new InvalidOperationException("The deque is empty!");
            }

            return this.lastItem.Element;
        }


        /// <summary>
        /// Removes all elements in the deque.
        /// </summary>
        public void Clear()
        {
            this.firstItem = null;
            this.lastItem = null;
            this.count = 0;
        }
    }
}
