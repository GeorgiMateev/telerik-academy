using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.RemoveNegativeNumbers
{
    class RemoveNegative
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

            List<int> positives = RemoveNegativeNumbers(sequence);

            foreach (var item in positives)
            {
                Console.Write(item);
            }
        }

        static List<int> RemoveNegativeNumbers(List<int> sequence)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] >= 0)
                {
                    result.Add(sequence[i]);
                }
            }
            return result;
        }
    }
}
