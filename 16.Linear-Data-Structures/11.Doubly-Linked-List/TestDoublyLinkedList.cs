using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.Doubly_Linked_List
{
    class TestDoublyLinkedList
    {
        public static void Main()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            for (int i = 0; i < 20; i++)
            {
                list.AddFirst(i);
            }
            for (int i = 0; i < 20; i++)
            {
                list.AddLast(i);
            }

            int[] elements = list.ToArray();
            foreach (var item in elements)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            list.AddAt(1001, 30);


            DoublyLinkedList<int>.ListItem<int> current = list.FirstElement;
            while (current!=null)
            {
                Console.Write("{0} ",current.Element);
                current = current.NextItem;
            }

            for (int i = 0; i < 10; i++)
            {
               list.RemoveAt(i);                
            }
           
            Console.WriteLine();

            DoublyLinkedList<int>.ListItem<int> current2 = list.FirstElement;
            while (current2 != null)
            {
                Console.Write("{0} ", current2.Element);
                current2 = current2.NextItem;
            }

            Console.WriteLine();
            Console.WriteLine(list.IndexOf(13));
            Console.WriteLine(list.IndexOf(2000));
            Console.ReadKey();

           
        }
    }
}
