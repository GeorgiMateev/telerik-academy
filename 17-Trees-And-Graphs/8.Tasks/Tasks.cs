using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.Tasks
{
    class Tasks
    {
        struct TaskDependency
        {
            private int parent;
            public int Parent
            {
                get { return parent; }
                set { parent = value; }
            }

            private int child;
            public int Child
            {
                get { return child; }
                set { child = value; }
            }

            public TaskDependency(int parent, int child)
            {
                this.parent = parent;
                this.child = child;
            }
        } //Ordered pair task->task

        const int tasksCount = 9;
        static TaskDependency[] dependencies = 
        {
            new TaskDependency(0,1),
            new TaskDependency(1,4),
            new TaskDependency(1,3),
            new TaskDependency(2,0),
            new TaskDependency(5,1),
            new TaskDependency(6,5),
            new TaskDependency(5,7),
            new TaskDependency(8,6),
            new TaskDependency(0,1),
            new TaskDependency(2,4) // This makes cycle
        };

        static List<int>[] tasksGraph = new List<int>[tasksCount];  //List of the successors of a current task.
        static int[] numberDependencies = new int[tasksCount];  //On how many tasks the solution of the current depends.

        static List<int> taskSolutionSequence;   //The order in which the tasks should be solved.

        static void Main(string[] args)
        {
            CreateGraph();
            bool solutionExist = FindTaskSequence();
            if (solutionExist)
            {
                foreach (var item in taskSolutionSequence)
                {
                    Console.Write("{0} ", item);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Solution doesn't exisst!");
            }

            Console.ReadKey();
        }
        

        /// <summary>
        /// Initializes the list of the successors and counts the dependencies of a task.
        /// </summary>
        private static void CreateGraph()
        {
            for (int i = 0; i < tasksCount; i++)
            {
                tasksGraph[i] = new List<int>();
            }

            foreach (var item in dependencies)
            {
                tasksGraph[item.Parent].Add(item.Child);
                numberDependencies[item.Child]++;
            }
        }

        /// <summary>
        /// Finds the order in which the tasks should be solved.
        /// </summary>
        /// <returns></returns>
        private static bool FindTaskSequence()
        {
            taskSolutionSequence = new List<int>();
            bool[] visited = new bool[tasksCount];

            int[] freeTasks = FindFreeTasks();
            if (freeTasks.Length==0)
            {
                return false;
            }

            Queue<int> BFSQueue = new Queue<int>(freeTasks);
            foreach (var item in freeTasks)
            {
                visited[item] = true;
            }
            while (BFSQueue.Count>0)
            {
                int current = BFSQueue.Dequeue();
                if (numberDependencies[current]==0)
                {
                    taskSolutionSequence.Add(current);
                    foreach (var item in tasksGraph[current])
                    {
                        //if (taskSolutionSequence.Contains(item))
                        //{
                        //    return false;
                        //}
                        numberDependencies[item]--;                       
                        if (!visited[item])
                        {
                            BFSQueue.Enqueue(item);
                            visited[item] = true;
                        }
                    }
                }
                else
                {
                    if (BFSQueue.Count == 0)
                    {
                        return false;
                    }
                    BFSQueue.Enqueue(current);
                }
            }
            return true;
        }

        /// <summary>
        /// Finds the tasks which can be solved alone.
        /// </summary>
        /// <returns></returns>
        private static int[] FindFreeTasks()
        {
            List<int> tasks = new List<int>();
            for (int i = 0; i < tasksCount; i++)
            {
                if (numberDependencies[i]==0)
                {
                    tasks.Add(i);
                }
            }
            return tasks.ToArray();
        }
    }
}
