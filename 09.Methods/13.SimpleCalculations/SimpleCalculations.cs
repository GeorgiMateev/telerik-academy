using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13.SimpleCalculations
{
    class SimpleCalculations
    {
        
        static int ReverseDigits(int number)
        {
            int m = number;
            List<sbyte> digits = new List<sbyte>();
            while (m != 0)
            {
                digits.Add((sbyte)(m % 10));
                m /= 10;
            }
            int reversed = 0;
            for (int i = 0, dec = 10; i < digits.Count; i++)
            {
                reversed += (int)(digits[i] * Math.Pow(dec,digits.Count-1-i));
            }
            return reversed;
        }

        private static decimal GetAverage(int[] numbers)
        {
            decimal average = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                average += numbers[i];
            }
            average /= numbers.Length;
            return average;
        }

        private static void SolveEquation()
        {
            Console.Write("a = ");
            int a = 0;
            while (true)
            {
                a = GetNumber();
                if (a==0)
                {
                    Console.WriteLine("a different than 0");
                    Console.Write("a = ");
                }
                else
                {
                    break;
                }
            }

            Console.Write("b = ");
            int b = GetNumber();

            decimal x = (decimal)(-b) / (decimal)a;
            Console.WriteLine("x = {0}",x);
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Press 'x' to exit or another key to perform an action.");

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.KeyChar == 'x')
                {
                    break;
                }

                PrintMenu();
                sbyte action = GetAction();

                switch (action)
                {
                    case 1:
                        Console.Write("Number = ");
                        int reversed = ReverseDigits(GetPositiveNumber());
                        Console.WriteLine("Reversed = {0}", reversed);
                        break;
                    case 2:
                        int[] numbers = GetNumbersInArray();
                        decimal average = GetAverage(numbers);
                        Console.WriteLine("Average = {0}", average);
                        break;
                    case 3:
                        SolveEquation();
                        break;
                    default:
                        break;
                }

                Console.WriteLine();               
                
            }
        }     

        

        private static int[] GetNumbersInArray()
        {
            Console.Write("Length = ");
            int count = GetPositiveNumber();
            int[] numbers = new int[count];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Number = ");
                numbers[i] = GetNumber();
            }
            return numbers;
        }

        static void PrintMenu()
        {
            Console.WriteLine("Perform an action:");
            Console.WriteLine("1.Reverse the digits of a number.");
            Console.WriteLine("2.Calculate the average of a sequence of integers.");
            Console.WriteLine("3.Solve the equation : a*x + b = 0");
            Console.WriteLine();
        }

        private static int GetPositiveNumber()
        {
            bool isCorrect = false;
            int number = 0;
            while (!isCorrect)
            {
                isCorrect = int.TryParse(Console.ReadLine(), out number);
                if (number < 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Enter positive number.");
                }
            }
            Console.WriteLine();
            return number;
        }
        private static int GetNumber()
        {
            bool isCorrect = false;
            int number = 0;
            while (!isCorrect)
            {
                isCorrect = int.TryParse(Console.ReadLine(), out number);                
            }
            Console.WriteLine();
            return number;
        }

        private static sbyte GetAction()
        {
            bool isCorrect = false;
            sbyte action = 0;
            while (!isCorrect)
            {
                Console.Write("Select: ");
                isCorrect = sbyte.TryParse(Console.ReadLine(),out action);
                if (action<1 || action>3)
                {
                    isCorrect = false;
                }
            }
            Console.WriteLine();
            return action;
        }
    }
}
