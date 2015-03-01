using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.MaximalSumInKElements
{
    class MaxSum
    {
        static void SelectionSort(int[] array)
        {
            for (int sp = 0; sp < array.Length; sp++)
            {
                int min = sp;
                for (int j = sp; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                int x = array[sp];
                array[sp] = array[min];
                array[min] = x;
            }
        }

        static void Main(string[] args)
        {
            int n=0;
            bool isCorrectN = false;
            while (!isCorrectN)
            {
                Console.Write("n = ");
                isCorrectN = int.TryParse(Console.ReadLine(), out n);
                if (!isCorrectN)
                {
                    Console.WriteLine("Enter only integers!");
                }
            }

            int k = 0;
            bool isCorrectK = false;
            while (!isCorrectK)
            {
                Console.Write("k = ");
                isCorrectK = int.TryParse(Console.ReadLine(), out k);
                if (!isCorrectK)
                {
                    Console.WriteLine("Enter only integers!");
                }
            }

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                int x = 0;
                bool isCorrectX = false;
                while (!isCorrectX)
                {
                    isCorrectX = int.TryParse(Console.ReadLine(), out x);
                    if (!isCorrectX)
                    {
                        Console.WriteLine("Enter only integers!");
                    }
                }
                numbers[i] = x;
            }

            SelectionSort(numbers);

            foreach (var item in numbers)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            for (int i = k-1; i >= 0; i--)
            {
                Console.Write("{0} ",numbers[n-1-i]);
            }

            Console.ReadKey();
        }
    }
}
