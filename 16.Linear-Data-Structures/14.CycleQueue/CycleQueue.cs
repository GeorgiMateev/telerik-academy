using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14.CycleQueue
{
    class CycleQueue<T>
    {
        private T[] elements;
        private int headIndex;
        private int tailIndex;
        private bool isTransfered;
        private bool hasFreePlacesBeforeHead;
        
        private int count;
        public int Count
        {
            get { return count; }
        }

        public CycleQueue()
        {
            this.elements = new T[4];
            this.headIndex = 0;
            this.tailIndex = 0;
            this.hasFreePlacesBeforeHead = false;
            this.isTransfered = false;
        }

        public void Enqueue(T element)
        {
            if (this.count > 0)
            {
                this.tailIndex++;
            }                
            this.count++;            

            if (this.tailIndex==this.elements.Length) // If the end of the array is reached.
            {
                if (this.hasFreePlacesBeforeHead==true) //If there are free places before the head
                {
                    this.tailIndex = 0;
                    this.elements[this.tailIndex] = element;
                    this.isTransfered = true;
                    if (this.headIndex-this.tailIndex==1) 
                    {
                        //Check if the there is no more free slots before the head.
                        this.hasFreePlacesBeforeHead = false;
                    }
                }
                else
                {
                    //There is no free places before the head.
                    this.ExpandArray();
                    this.elements[tailIndex] = element;
                }
            }
            else //The end is not reached.
            {
                if (this.isTransfered) // The queue has passed the end of the array.
                {
                    if (!this.hasFreePlacesBeforeHead)
                    {
                        this.ExpandArray();
                        this.elements[tailIndex] = element;
                    }
                    else //There are free places before the head.
                    {
                        this.elements[this.tailIndex] = element;
                        if (this.headIndex-this.tailIndex==1)
                        {
                            this.hasFreePlacesBeforeHead = false;
                        }
                    }
                }
                else // The queue is hasn't passed the end of the array.
                {
                    this.elements[this.tailIndex] = element;
                }
            }
        }

        public T Dequeue()
        {
            if (this.count==0)
            {
                throw new InvalidOperationException("The queue is empty!");
            }

            T element = this.elements[this.headIndex];
            this.headIndex++;
            this.count--;

            if (this.headIndex==this.elements.Length) //The head reached the end of the array
            {
                this.headIndex = 0;
                this.isTransfered = false;
                this.hasFreePlacesBeforeHead = false;
            }
            else //Has not reached the end of the array.
            {
                this.hasFreePlacesBeforeHead = true;
            }
            return element;
        }

        public void Clear()
        {
            this.count = 0;
            this.hasFreePlacesBeforeHead = false;
            this.isTransfered = false;
            this.headIndex = 0;
            this.tailIndex = 0;
        }   

        public T Peek()
        {
            if (this.count==0)
            {
                throw new InvalidOperationException("The queue is empty!");
            }
            return this.elements[this.headIndex];
        }

        private void ExpandArray()
        {
            T[] newArray = new T[this.elements.Length * 2];
            int newCounter = 0;

            if (this.isTransfered)
            {
                for (int i = this.headIndex; i < elements.Length; i++)
                {
                    newArray[newCounter] = this.elements[i];
                    newCounter++;
                }
                for (int i = 0; i <= this.tailIndex-1; i++)
                {
                    newArray[newCounter] = this.elements[i];
                }                
            }
            else
            {
                for (int i = this.headIndex; i <= this.tailIndex-1; i++)
                {
                    newArray[newCounter] = this.elements[i];
                    newCounter++;
                }
            }

            this.headIndex = 0;
            this.tailIndex = newCounter;
            this.hasFreePlacesBeforeHead = false;
            this.isTransfered = false;
            this.elements = newArray;
        }
    }
}
