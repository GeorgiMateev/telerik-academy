using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Print_Sum
{
    class PrintSum
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            bool isCorrectIn = false ;
            
            do
            {
                try
                {
                    Console.Write("a = "); a = int.Parse(Console.ReadLine());
                    Console.Write("b = "); b = int.Parse(Console.ReadLine());
                    Console.Write("c = "); c = int.Parse(Console.ReadLine());
                    isCorrectIn = true;
                }
                catch (FormatException err)
                {
                    Console.WriteLine(err.Message);
                    Console.WriteLine();
                }
            }
            while(!isCorrectIn);

            int sum = a + b + c;

            Console.WriteLine("sum = {0}",sum);

            Console.ReadKey(false);
        }
    }
}
