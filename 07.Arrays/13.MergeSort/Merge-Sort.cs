using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13.MergeSort
{
    class Sort
    {
        static List<int> MergeSort(List<int> numbers)
        {
            int mid = numbers.Count / 2;
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            if (numbers.Count<=1)
            {
                return numbers;
            }

            for (int i = 0; i < mid; i++)
            {
                left.Add(numbers[i]);
            }
            for (int i = mid; i < numbers.Count; i++)
            {
                right.Add(numbers[i]);
            }
            left = MergeSort(left);
            right = MergeSort(right);
            List<int> result = Merge(left, right);
            return result;
        }

        static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            while (left.Count>0 || right.Count>0)
            {
                if (left.Count>0 && right.Count>0)
                {
                    if (left[0] <= right[0])
                    {
                        result.Add(left[0]);
                        left.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(right[0]);
                        right.RemoveAt(0);
                    }
                }
                else
                {
                    if (left.Count>0)
                    {
                        result.Add(left[0]);
                        left.RemoveAt(0);
                    }
                    else if(right.Count>0)
                    {
                        result.Add(right[0]);
                        right.RemoveAt(0);
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>
            {
                5,-1,3,0,123,-434,213,-4,-55,1,-44                
            };

            foreach (var item in numbers)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            List<int> sortedNumbers = MergeSort(numbers);

            foreach (var item in sortedNumbers)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
        }
    }
}
