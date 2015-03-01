using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18.SortedSubset
{
    class SortedSubset
    {
        static void Main(string[] args)
        {
            Dictionary<int, int>[] numbers = new Dictionary<int, int>[8];
            numbers[0] = new Dictionary<int, int>();
            numbers[0].Add(0, 2);

            numbers[1] = new Dictionary<int, int>();
            numbers[1].Add(1, 5);

            numbers[2] = new Dictionary<int, int>();
            numbers[2].Add(2, 1);

            numbers[3] = new Dictionary<int, int>();
            numbers[3].Add(3, 8);

            numbers[4] = new Dictionary<int, int>();
            numbers[4].Add(4, 3);

            numbers[5] = new Dictionary<int, int>();
            numbers[5].Add(5, 4);

            numbers[6] = new Dictionary<int, int>();
            numbers[6].Add(6, 2);

            numbers[7] = new Dictionary<int, int>();
            numbers[7].Add(7, 5);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i][i]);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
