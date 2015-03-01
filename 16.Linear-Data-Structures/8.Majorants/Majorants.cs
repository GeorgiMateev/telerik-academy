using System;
using System.Collections.Generic;

namespace _8.Majorants
{
    class Majorants
    {
        static bool FindMajorant(List<int> sequence, out int majorant)
        {       
            sequence.Sort();

            int majorantOccurancesNeeded = sequence.Count / 2 + 1;

            int number = sequence[0];
            int numberCount = 1;

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i]==sequence[i+1])
                {
                    numberCount++;
                    if (numberCount==majorantOccurancesNeeded)
                    {
                        majorant = number;
                        return true;
                    }
                }
                else
                {
                    if (i>=majorantOccurancesNeeded)
                    {
                        majorant = 0;
                        return false;
                    }
                    number = sequence[i+1];
                    numberCount = 1;
                }
            }
            majorant = 0;
            return false;
        }

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

            int majorant = 0;
            bool hasMajorant = FindMajorant(sequence, out majorant);

            if (hasMajorant)
            {
                Console.WriteLine(majorant);
            }
            else
            {
                Console.WriteLine("There is no majorant.");
            }
        }
    }
}
