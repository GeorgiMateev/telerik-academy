using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.Majorants
{
    class Majorants
    {
        static bool IsMajorant(int number, List<int> sequence)
        {
            int counter = 0;
            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i]==number)
                {
                    counter++;
                }
            }
            if (counter >= sequence.Count/2+1)
            {
                return true;
            }
            return false;
        }

        static bool FindMajorant(List<int> sequence, out int majorant)
        {
            Stack<int> majorants = new Stack<int>();
            for (int i = 1; i < sequence.Count; i++)
            {
                if (majorants.Count==0)
                {
                    majorants.Push(sequence[i]);
                    continue;
                }
                int current = majorants.Peek();
                if (current==sequence[i])
                {
                    majorants.Push(sequence[i]);
                }
                else
                {
                    majorants.Pop();
                }
            }
            if (majorants.Count==0)
            {
                majorant = 0;
                return false;
            }

            bool isMajorant = IsMajorant(majorants.Peek(), sequence);
            if (isMajorant)
            {
                majorant = majorants.Peek();
                return true;
            }
            else
            {
                majorant = 0;
                return false;
            }
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

            Console.ReadKey();
        }
    }
}
