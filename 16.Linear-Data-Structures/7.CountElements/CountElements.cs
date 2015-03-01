using System;
using System.Collections.Generic;

namespace _7.CountElements
{
    class Count_Elements
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

            int[] occurances = new int[1001];

            foreach (var number in sequence)
            {
                occurances[number]++;
            }

            for (int i = 0; i < occurances.Length; i++)
            {
                if (occurances[i]>0)
                {
                    Console.WriteLine("{0}->{1}",i, occurances[i]);
                }
            }
        }        
    }
}
