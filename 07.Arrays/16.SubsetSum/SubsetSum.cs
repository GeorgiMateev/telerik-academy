using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16.SubsetSum
{
    class SubsetSum
    {
        static void Main(string[] args)
        {

           /* int[] numbers = 
            {
                3,5,1,36,6,30,-12,4,-3,8,-3,-534,-23,-2,-6,-2,3,5
            };*/

            int[] numbers =new int[100];
            Random randNumber = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randNumber.Next(-500, 500);
            }

            foreach (var item in numbers)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            int s = 0;
            bool isCorrect = false;
            while (!isCorrect)
            {
                Console.WriteLine("Enter sum: ");
                isCorrect = int.TryParse(Console.ReadLine(), out s);
            }

            bool exist = HasSubsetSum(numbers, s);
            if (exist)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadKey();

        }
        private static bool HasSubsetSum(int[] numbers, int s)
        {
            List<int> sums = new List<int> { 0 };
            for (int i = 0; i < numbers.Length; i++)
            {
                List<int> increased = IncreaseList(sums,numbers[i]);
                List<int> merged = Merge(sums, increased);
                sums = merged;
                if (sums.Contains(s))
                {
                    return true;
                }                
            }
            return false;
        }
        static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            int leftCounter = 0;
            int rightCounter = 0;
            while (leftCounter < left.Count || rightCounter < right.Count)
            {
                if (leftCounter < left.Count && rightCounter < right.Count)
                {
                    if (left[leftCounter] <= right[rightCounter])
                    {
                        result.Add(left[leftCounter]);
                        leftCounter++;
                    }
                    else
                    {
                        result.Add(right[rightCounter]);
                        rightCounter++;
                    }
                }
                else
                {
                    if (leftCounter < left.Count)
                    {
                        result.Add(left[leftCounter]);
                        leftCounter++;
                    }
                    else if (rightCounter < right.Count)
                    {
                        result.Add(right[rightCounter]);
                        rightCounter++;
                    }
                }
            }
            return result;
        }
        
        private static List<int> IncreaseList(List<int> list, int p)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(list[i] + p);
            }
            return result;
        }
    }
}
