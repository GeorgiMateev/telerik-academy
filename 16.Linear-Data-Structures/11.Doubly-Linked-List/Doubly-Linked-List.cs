using System;
using System.Collections.Generic;

namespace _11.Doubly_Linked_List
{
    /// <summary>
    /// The main dynamic list class.
    /// </summary>
    /// <typeparam name="T">The type of the contained value.></typeparam>
    public class DoublyLinkedList<T>
    {
        /// <summary>
        /// Contains single element with pointers to the previous and the next element.
        /// </summary>
        /// <typeparam name="T">The type of the element.</typeparam>
        public class ListItem<T>
        {
            private T element;
            public T Element
            {
                get { return element; }
                set { element = value; }
            }

            private ListItem<T> previousItem;
            public ListItem<T> PreviousItem
            {
                get { return previousItem; }
                set { previousItem = value; }
            }

            private ListItem<T> nextItem;
            public ListItem<T> NextItem
            {
                get { return nextItem; }
                set { nextItem = value; }
            }

            public ListItem(T element)
            {
                this.element = element;
                this.nextItem = null;
                this.previousItem = null;
            }
            public ListItem(T element, ListItem<T> previous, ListItem<T> next)
            {
                this.element = element;
                this.nextItem = next;
                this.previousItem = previous;
            }
        }

        private ListItem<T> firstElement;
        public ListItem<T> FirstElement
        {
            get { return firstElement; }
            set { firstElement = value; }
        }

        private ListItem<T> lastElement;
        public ListItem<T> LastElement
        {
            get { return lastElement; }
            set { lastElement = value; }
        }

        private int count;
        public int Count
        {
            get { return count; }
        }

        public DoublyLinkedList()
        {
            this.firstElement = null;
            this.lastElement = null;
            this.count = 0;
        }

        /// <summary>
        /// Adds element at the beginning of the list.
        /// </summary>
        public void AddFirst(T element)
        {
            if (this.firstElement==null)
            {
                //We have empty list
                ListItem<T> item = new ListItem<T>(element);
                this.firstElement = item;
                this.lastElement = firstElement;
            }
            else
            {
                //The list is not empty
                ListItem<T> item = new ListItem<T>(element);
                item.NextItem = firstElement;
                firstElement.PreviousItem = item;
                firstElement = item;
            }
            this.count++;
        }

        /// <summary>
        /// Adds element at the end of the list
        /// </summary>
        public void AddLast(T element)
        {
            if (this.lastElement==null)
            {
                //The llist is empty
                ListItem<T> item = new ListItem<T>(element);
                this.lastElement = item;
                this.firstElement = lastElement;
            }
            else
            {
                //The list is not empty
                ListItem<T> item = new ListItem<T>(element);
                item.PreviousItem = this.lastElement;
                this.lastElement.NextItem = item;
                this.lastElement = item;
            }
            this.count++;
        }

        /// <summary>
        /// Adds element at specified index. If the list is empty use AddFist() or AddLast().
        /// </summary>
        /// <param name="element">The element</param>
        /// <param name="index">Index. (Starts from 0).</param>
        public void AddAt(T element, int index)
        {           
            if (index<0 || index>=this.count)
            {
                throw new IndexOutOfRangeException();
            }
                       
            ListItem<T> itemAtGivenIndex = this.GetAt(index);

            //Adds element
            ListItem<T> previousItem = itemAtGivenIndex.PreviousItem;            
            ListItem<T> newItem = new ListItem<T>(element,previousItem,itemAtGivenIndex);
            previousItem.NextItem = newItem;
            itemAtGivenIndex.PreviousItem = newItem;
            count++;
        }       

        /// <summary>
        /// Removes a element at specified index.
        /// </summary>
        /// <param name="index">Index (starts from 0)</param>
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new IndexOutOfRangeException();
            }

            ListItem<T> itemToRemove = this.GetAt(index);

            count--;
            if (this.count == 0)
            {
                //The list becomes empty
                this.firstElement = null;
                this.lastElement = null;
            }
            else
            {
                if (itemToRemove.PreviousItem == null)
                {
                    //If the first element should be removed.
                    this.firstElement.NextItem.PreviousItem = null;
                    this.firstElement = itemToRemove.NextItem;
                    itemToRemove.NextItem = null;
                }
                if (itemToRemove.NextItem == null)
                {
                    //If the last element should be removed.
                    this.lastElement.PreviousItem.NextItem = null;
                    this.lastElement = itemToRemove.PreviousItem;
                    itemToRemove.PreviousItem = null;
                }
                if (itemToRemove.PreviousItem != null && itemToRemove.NextItem != null)
                {
                    //If the element to be removed is not in the begining or the end.
                    ListItem<T> previousItem = itemToRemove.PreviousItem;
                    ListItem<T> nextItem = itemToRemove.NextItem;

                    previousItem.NextItem = nextItem;
                    nextItem.PreviousItem = previousItem;

                    itemToRemove.NextItem = null;
                    itemToRemove.PreviousItem = null;
                }
            }          
        }

        /// <summary>
        /// Returns the element at specified index.
        /// </summary>
        /// <param name="index">Index. (Starts from 0)</param>
        public ListItem<T> GetAt(int index)
        {
            ListItem<T> currentItem = this.firstElement;
            for (int i = 1; i <= index; i++)
            {
                currentItem = currentItem.NextItem;
            }
            return currentItem;
        }

        /// <summary>
        /// Returns the index of the first occurance of the element in the list or -1 if the element don't exist.
        /// </summary>
        /// <param name="element">The element to search for. Must implement IComparable interface in order to be corectly compared.</param>
        /// <returns>Zero based index or -1</returns>
        public int IndexOf(T element)
        {
            if (this.count==0)
            {
                return -1;
            }
            ListItem<T> current = this.firstElement;
            for (int i = 0; i < this.count-1; i++)
            {
                if (current.Element.Equals(element))
                {
                    return i;
                }
                current = current.NextItem;
            }
            return -1;
        }

        /// <summary>
        /// Returns an array with the elements in the list.
        /// </summary>
        public T[] ToArray()
        {
            T[] arr = new T[this.count];
            if (arr.Length==0)
            {
                return arr;
            }

            ListItem<T> current = this.firstElement;
            for (int i = 0; i < this.count; i++)
            {
                arr[i] = current.Element;
                current = current.NextItem;
            }
            return arr;
        }

    }
}
