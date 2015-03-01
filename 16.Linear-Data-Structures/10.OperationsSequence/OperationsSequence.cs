using System;
using System.Collections.Generic;
using System.IO;

namespace _10.OperationsSequence
{
    class OperationsSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Stack<int> solution = new Stack<int>();

            solution = ProceedOperations(n, m);

            StreamWriter resultInFile = new StreamWriter("Test10.out.txt", false);
            using (resultInFile)
            {
                while (solution.Count > 0)
                {
                    if (solution.Count == 1)
                    {
                        int number = solution.Pop();
                        Console.Write(number);
                        resultInFile.WriteLine(number);
                    }
                    else
                    {
                        int number = solution.Pop();
                        Console.Write("{0} -> ", number);
                        resultInFile.Write("{0} -> ", number);
                    }
                }
            }
        }

        /// <summary>
        /// Uses queue to store operation results.
        /// </summary>        
        private static Stack<int> ProceedOperations(int n, int m)
        {
            Queue<int> operations = new Queue<int>();
            operations.Enqueue(n);

            //Holds the result which leads to the current key.
            //The value of the dictionary is the parent of the key.
            Dictionary<int, int> predecessors = new Dictionary<int, int>();
            predecessors.Add(n, int.MinValue);

            while (true)
            {
                int current = operations.Dequeue();
                if (current == m)
                {
                    return  GetSolution(predecessors, current, n);
                }

                if (!predecessors.ContainsKey(current * 2))
                {
                    predecessors.Add(current * 2, current);
                    operations.Enqueue(current * 2);
                }

                if (!predecessors.ContainsKey(current + 2))
                {
                    predecessors.Add(current + 2, current);
                    operations.Enqueue(current + 2);
                }

                if (!predecessors.ContainsKey(current + 1))
                {
                    predecessors.Add(current + 1, current);
                    operations.Enqueue(current + 1);
                }                
            }
        }

        /// <summary>
        /// Recovers the order of the operation results which lead to M
        /// </summary>       
        private static Stack<int> GetSolution(Dictionary<int, int> predecessors, int startKey, int endKey)
        {
            Stack<int> solution = new Stack<int>();

            int current = startKey;
            solution.Push(startKey);

            while (current!=endKey)
            {
                solution.Push(predecessors[current]);
                current = predecessors[current];
            }

            return solution;
        }
    }
}
