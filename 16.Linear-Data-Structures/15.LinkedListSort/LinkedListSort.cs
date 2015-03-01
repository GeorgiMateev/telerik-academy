using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15.LinkedListSort
{
    class LinkedListSort
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            string line = Console.ReadLine();
            string[] lineParts = line.Split(new char[]{' '} ,StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in lineParts)
            {
                list.AddFirst(int.Parse(item));
            }

            Sort<int>(list);

            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Buble sort
        /// </summary>
        /// <typeparam name="T">The type of the contained elements. Should implement IComparable interface in order to be correct sorted.</typeparam>
        /// <param name="list">The linked list to be sorted.</param>
        static void Sort<T>(LinkedList<T> list) where T : IComparable<T>
        {
            int rightBorderIndex = 0;
            for (int i = list.Count-1; i > 0; i = rightBorderIndex)
            {
                LinkedListNode<T> current = list.First;
                rightBorderIndex = 0;
                for (int j = 0; j < i; j++)
                {
                    if (current.Value.CompareTo(current.Next.Value)>0)
                    {
                        T x = current.Value;
                        current.Value = current.Next.Value;
                        current.Next.Value = x;
                        rightBorderIndex = j;
                    }
                    current = current.Next;
                }
            }
        }
    }
}
