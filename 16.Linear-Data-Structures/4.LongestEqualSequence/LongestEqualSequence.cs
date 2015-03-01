using System;
using System.Collections.Generic;
using System.IO;

namespace _4.LongestEqualSequence
{
    class LongestEqualSequence
    {
        static void Main(string[] args)
        {
            List<int> sequence = new List<int>();

            while (true)
            {
                string line = Console.ReadLine();
                int number = 0;
                if (!int.TryParse(line, out number))
                {
                    break;
                }
                else
                {
                    sequence.Add(number);
                }
            }

            List<int> longestEqualSubsequence = FindLongestEqualSubsequence(sequence);

            foreach (var item in longestEqualSubsequence)
            {
                Console.WriteLine(item);
            }

            StreamWriter result = new StreamWriter("Test10.out.txt",false);
            using (result)
            {
                foreach (var item in longestEqualSubsequence)
                {
                    result.WriteLine(item);
                }
            }
        }

        static List<int> FindLongestEqualSubsequence(List<int> sequence)
        {
            if (sequence.Count<=1)
            {
                return sequence;
            }

            sequence.Sort();

            int longestSequenceStartIndex = 0;
            int longestSequenceLength = 1;

            int sequenceStartIndex = 0;
            int sequenceLength = 1;
            for (int i = 0; i < sequence.Count-1; i++)
            {
                if (sequence[i]==sequence[i+1])
                {
                    sequenceLength++;
                    if (i==sequence.Count-2)
                    {
                        if (sequenceLength>longestSequenceLength)
                        {
                            longestSequenceLength = sequenceLength;
                            longestSequenceStartIndex = sequenceStartIndex;
                        }
                    }
                }
                else
                {
                    if (sequenceLength>longestSequenceLength)
                    {
                        longestSequenceLength = sequenceLength;
                        longestSequenceStartIndex = sequenceStartIndex;
                    }
                    sequenceLength = 1;
                    sequenceStartIndex = i+1;
                }
            }

            List<int> result = sequence.GetRange(longestSequenceStartIndex, longestSequenceLength);
            return result;
        }
    }
}
