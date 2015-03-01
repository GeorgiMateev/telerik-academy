using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.CheckIfSubsetIsZero
{
    class CheckIfSubsetIsZero
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                int n;
                while (true)
                {
                    try
                    {
                        n = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter only numbers!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Enter smaller number!");
                    }
                }
                numbers[i] = n;
            }

            bool hasZeroSubset = CheckForZeroSubset(numbers);
            if (hasZeroSubset)
            {
                Console.WriteLine("There is subset with zero sum!");
            }
            else
            {
                Console.WriteLine("There is NO subset with zero sum!");
            }

            Console.ReadKey(true);
        }

        static bool CheckForZeroSubset(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == 0)
                    {
                        return true;
                    }
                }
            }

            for (int f = 0; f < numbers.Length; f++)
            {
                for (int i = f+1; i < numbers.Length; i++)
                {
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[f] + numbers[i] + numbers[j] == 0)
                        {
                            return true;
                        }
                    }
                }
            }

            for (int g = 0; g < numbers.Length; g++)
            {
                for (int f = g + 1; f < numbers.Length; f++)
                {
                    for (int i = f+1; i < numbers.Length; i++)
                    {
                        for (int j = i + 1; j < numbers.Length; j++)
                        {
                            if( numbers[g] + numbers[f] + numbers[i] + numbers[j] == 0)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                if (sum==0)
                {
                    return true;
                }
            }            
           

            return false;
        }


    }
}
