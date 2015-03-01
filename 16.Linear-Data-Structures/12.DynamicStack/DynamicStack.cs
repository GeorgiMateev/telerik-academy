using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.DynamicStack
{
    /// <summary>
    /// The main stack class.
    /// </summary>
    /// <typeparam name="T">The type of the elements which will be stored.</typeparam>
    public class DynamicStack<T>
    {
        /// <summary>
        /// Represents single node which contains element and pointer to the previous element.
        /// </summary>
        /// <typeparam name="T">The type of the element.</typeparam>
        public class StackItem<T>
        {
            private T element;
            public T Element
            {
                get { return element; }
                set { element = value; }
            }

            private StackItem<T> previousItem;
            public StackItem<T> PreviousItem
            {
                get { return previousItem; }
                set { previousItem = value; }
            }

            public StackItem(T element)
            {
                this.element = element;
                this.previousItem = null;
            }
        }

        private StackItem<T> top;
        public StackItem<T> Top
        {
            get { return top; }
            set { top = value; }
        }

        private int count;
        public int Count
        {
            get { return count; }
        }
        
        public DynamicStack()
        {
            this.top = null;
            this.count = 0;
        }

        /// <summary>
        /// Pushs element on the top of the stack.
        /// </summary>
        public void Push(T element)
        {
            if (this.top==null)
            {
                //The stack is empty.
                StackItem<T> item = new StackItem<T>(element);
                this.top = item;
            }
            else
            {
                //The stack is not empty
                StackItem<T> item = new StackItem<T>(element);
                item.PreviousItem = top;
                top = item;
            }
            this.count++;
        }

        /// <summary>
        /// Returns and removes the top element.
        /// </summary>
        public T Pop()
        {
            if (this.count==0)
            {
                //The stack is empty
                throw new InvalidOperationException("The stack is empty!");
            }

            this.count--;
            if (count==0)
            {
                //The stack becomes empty.
                StackItem<T> item = this.top;
                this.top = null;
                return item.Element;
            }
            else
            {
                StackItem<T> item = this.top;
                this.top = item.PreviousItem;
                return item.Element;
            }
        }

        /// <summary>
        /// Returns the top element without removing it.
        /// </summary>
        public T Peek()
        {
            if (this.count==0)
            {
                throw new InvalidOperationException("The stack is empty!");
            }

            return this.top.Element;
        }

        /// <summary>
        /// Removes all elements.
        /// </summary>
        public void Clear()
        {
            this.top = null;
            this.count = 0;
        }

        /// <summary>
        /// Returns array with the elements in the stack with order top to bottom.
        /// </summary>
        public T[] ToArray()
        {
            T[] arr = new T[this.count];
            StackItem<T> current = this.top;
            int counter = 0;
            while (current!=null)
            {
                arr[counter] = current.Element;
                current = current.PreviousItem;
                counter++;
            }
            return arr;
        }
    }
}
