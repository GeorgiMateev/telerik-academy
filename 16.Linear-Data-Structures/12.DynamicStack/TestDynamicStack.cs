using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.DynamicStack
{
    class TestDynamicStack
    {
        public static void Main()
        {
            DynamicStack<int> stack = new DynamicStack<int>();
            try
            {
                stack.Pop();
            }
            catch (InvalidOperationException err)
            {
                Console.WriteLine(err.Message);
            }

            for (int i = 0; i < 20; i++)
            {
                stack.Push(i);
            }
            Console.WriteLine(stack.Count);

            int[] arr = stack.ToArray();
            foreach (var item in arr)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();

            while (stack.Count>0)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.WriteLine(stack.Count);

            stack.Push(3);
            stack.Push(4);
            stack.Push(6);

            stack.Clear();

            try
            {
                stack.Peek();
            }
            catch (InvalidOperationException err)
            {
                Console.WriteLine(err.Message);
            }

            Console.WriteLine(stack.Count);

            Console.ReadKey();
        }
    }
}
