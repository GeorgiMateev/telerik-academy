using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace _4.LongestEqualSequence
{
    class LongestEqualSequence
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(100000000);

            ///Test inputs
            //list.AddRange(new int[] { 6, 6, 6, 6, 6, 6, 6, 6, 2, 2, 2, 4, 4, 4, 4, 4, 4, 4 });
            //list.AddRange(new int[] { 6, 6, 6, 2, 2, 2, 4, 4, 4, 4, 4, 4, 4 });
            //list.AddRange(new int[] { 6 });
            //list.AddRange(new int[] { });

            ///Load Test
            for (int i = 1; i <= list.Capacity; i++)
            {
                list.Add(i);
            }

            Stopwatch timer = new Stopwatch();
            timer.Start();
            List<int> result = FindLongestEqualSubsequence(list);
            timer.Stop();

            Console.WriteLine("Elapsed Time: {0} seconds.",timer.Elapsed.TotalSeconds);
            ///End load test

            foreach (var item in result)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
        }

        static List<int> FindLongestEqualSubsequence(List<int> sequence)
        {
            if (sequence.Count<=1)
            {
                return sequence;
            }

            int maxLength = 1;
            int currentLength = 1;
            int longestSequenceElement = sequence[0];

            for (int i = 0; i < sequence.Count-1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    currentLength++;
                    if (i<sequence.Count)
                    {
                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                            longestSequenceElement = sequence[i];
                        }
                    }
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        longestSequenceElement = sequence[i];
                    }
                    currentLength = 1;
                }
            }

            List<int> result = new List<int>();
            for (int i = 0; i < maxLength; i++)
            {
                result.Add(longestSequenceElement);
            }

            return result;
        }
    }
}
