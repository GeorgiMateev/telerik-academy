using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _15.CalculationsGeneric
{
    public static class CalculationsGeneric
    {
        public static T GetMinimum<T>(params T[] numbers) where T : System.IComparable<T>
        {
            T min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].CompareTo(min) < 0)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        public static T GetMaximum<T>(params T[] numbers) where T : System.IComparable<T>
        {
            
            T max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].CompareTo(max) > 0)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        public static T GetAverage<T>(params T[] numbers)
        {
            
            decimal average = 0.0m;
            for (int i = 0; i < numbers.Length; i++)
            {
                decimal number = Convert.ToDecimal(numbers[i]);
                average += number;
            }
            average /= numbers.Length;
            return (T)Convert.ChangeType(average, typeof(T));
        }

        public static T GetSum<T>(params T[] numbers)
        {
            decimal sum = 0.0m;
            for (int i = 0; i < numbers.Length; i++)
            {
                decimal n = Convert.ToDecimal(numbers[i]);
                sum += n;
            }
            return (T)Convert.ChangeType(sum, typeof(T));
        }

        public static T GetProduct<T>(params T[] numbers)
        {
            decimal product = 1.0m;
            for (int i = 0; i < numbers.Length; i++)
            {
                decimal n = Convert.ToDecimal(numbers[i]);
                product *= n;
            }
            return (T)Convert.ChangeType(product, typeof(T));
        }
        
    }
    static class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.Write("min in decimal = ");
            decimal min = CalculationsGeneric.GetMinimum<decimal>(3.4m, 5.6m, 0.8m, 1.1m,0.0001m, 0.001m);
            Console.WriteLine(min);

            Console.Write("min in float = ");
            float minF = CalculationsGeneric.GetMinimum<float>(3.4f, 5.6f, 0.8f, 1.1f, 0.0001f, 0.001f);
            Console.WriteLine(minF);

            Console.Write("max = ");
            decimal max = CalculationsGeneric.GetMaximum<decimal>(3.4m, 5.6m, 0.8m, 1.1m, 0.0001m, 0.001m);
            Console.WriteLine(max);

            Console.Write("average with float = ");
            float aver = CalculationsGeneric.GetAverage<float>(3.4f, 5.6f, 0.8f, 1.1f, 0.0001f, 0.001f);
            Console.WriteLine(aver);


            Console.Write("average with long = ");
            long averL = CalculationsGeneric.GetAverage<long>(1241423125, 235123521352135, 23512351235, 235213523512);
            Console.WriteLine(averL);

            Console.Write("sum with double = ");
            double sum = CalculationsGeneric.GetSum<double>(3.423424, 534.6, 0.8324, 1.1, 0.0001, 0.001);
            Console.WriteLine(sum);


            Console.Write("sum with byte = ");
            long sumB = CalculationsGeneric.GetSum<long>(124, 23, 235, 212);
            Console.WriteLine(sumB);

            Console.Write("Product with uint = ");
            int product = CalculationsGeneric.GetProduct<int>(342,34,13,24);
            Console.WriteLine(product);

            Console.ReadKey();
        }
    }
}
