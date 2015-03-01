using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.RemoveOddTimesContained
{
    class Odds
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

            List<int> removedOdds = RemoveOddTimesContained(sequence);

            foreach (var item in removedOdds)
            {
                Console.Write(item);
            }
        }

        public static List<int> RemoveOddTimesContained(List<int> sequence)
        {
            if (sequence.Count == 0)
            {
                return sequence;
            }

            List<int> orderedSequence = sequence.OrderBy(x => x).ToList();
            List<int> toBeRemoved = new List<int>();

            int currentCount = 1;
            for (int i = 0; i < orderedSequence.Count - 1; i++)
            {
                if (orderedSequence[i] != orderedSequence[i + 1])
                {
                    if (currentCount % 2 != 0)
                    {
                        toBeRemoved.Add(orderedSequence[i]);
                    }
                    currentCount = 1;
                }
                else
                {
                    currentCount++;
                    if (i == orderedSequence.Count - 2)
                    {
                        if (currentCount % 2 != 0)
                        {
                            toBeRemoved.Add(sequence[i]);
                        }
                    }
                }
            }

            List<int> result = new List<int>();
            for (int i = 0; i < sequence.Count; i++)
            {
                if (!toBeRemoved.Contains(sequence[i]))
                {
                    result.Add(sequence[i]);
                }
            }
            return result;
        }
    }
}
