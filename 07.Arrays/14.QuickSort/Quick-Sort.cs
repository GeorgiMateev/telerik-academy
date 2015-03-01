using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14.QuickSort
{
    class Program
    {
        static List<int> QuickSort(List<int> numbers)
        {
            if (numbers.Count <= 1)
            {
                return numbers;
            }
            int pivotIndex = numbers.Count / 2;
            int pivotValue = numbers[pivotIndex];
            numbers.RemoveAt(pivotIndex);
            List<int> less = new List<int>();
            List<int> greater = new List<int>();
            foreach (var item in numbers)
            {
                if (item<=pivotValue)
                {
                    less.Add(item);
                }
                else
                {
                    greater.Add(item);
                }
            }
            less = QuickSort(less);
            greater = QuickSort(greater);
            List<int> result = Concatenate(less,pivotValue,greater);
            return result;
        }

        private static List<int> Concatenate(List<int> less, int pivotValue, List<int> greater)
        {
            less.Add(pivotValue);
            less.AddRange(greater);
            return less;
        }

        static void Main(string[] args)
        {
            List<int> numbers = new List<int> 
            {
                3,-2,-34234,2,5,3,2,572,34,86,0,-34,-67,-32,-4
            };

            foreach (var item in numbers)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            List<int> sortedNumbers = new List<int>();
            sortedNumbers = QuickSort(numbers);

            foreach (var item in sortedNumbers)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
        }
    }
}
