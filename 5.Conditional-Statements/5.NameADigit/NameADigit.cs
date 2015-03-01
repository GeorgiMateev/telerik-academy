using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.NameADigit
{
    class NameADigit
    {
        static void Main(string[] args)
        {
            int a;
            while (true)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    if (!(a >= 0 && a <= 9))
                    {
                        throw new ArgumentException("Enter only one digit!");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only one number!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter smaller number!");
                }
                catch (ArgumentException err)
                {
                    Console.WriteLine(err.Message);
                }
            }

            switch (a)
            {
                case 0: Console.WriteLine("Zero"); break;
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                default: Console.WriteLine("I missed something :("); break;
            }

            Console.ReadKey(false);
        }
    }
}
