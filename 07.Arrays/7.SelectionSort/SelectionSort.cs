using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.SelectionSort
{
    class SelectionSort_
    {
        static void SelectionSort(int[] array)
        {
            for (int sp = 0; sp < array.Length; sp++)
            {
                int min = sp;
                for (int j = sp; j < array.Length; j++)
                {
                    if (array[j]<array[min])
                    {
                        min = j;
                    }                   
                }
                int x = array[sp];
                array[sp] = array[min];
                array[min] = x;
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = 
            {
                2,4,1,2,5,2,7,2,4,9,67,3,0,3,-1,-5,-49
            };
            foreach (var item in numbers)
            {
                Console.Write("{0} ", item);
            }

            SelectionSort(numbers);

            Console.WriteLine();

            foreach (var item in numbers)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
        }
    }
}
