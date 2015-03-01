using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.BinarySearch
{
    class BinarySearch_
    {
        static void Main(string[] args)
        {
            int[] numbers =
            {
                30,4,5,20,90,-2,-12,5,8
            };

            Array.Sort(numbers);

            Console.Write("Search for: ");
            int n = int.Parse(Console.ReadLine());

            int position = BinarySearch(numbers, n);

            Console.WriteLine("The position of the element is: {0}",position);

            Console.ReadKey();
        }

        static int BinarySearch(int[] numbers, int s)
        {
            int left = 0;
            int right = numbers.Length-1;

            if (s==numbers[right])
            {
                return right;
            }

            int position = 0;

            int mid = (left+right)/2;
            do
            {                
                if (s==numbers[mid])
                {
                    return mid;
                }
                if (s<numbers[mid])
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }
                mid = (left + right) / 2;
            } while (mid!=left && mid!=right);
            position = mid * -1;
            return position;
        }
    }
}
