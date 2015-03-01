using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                double sqrt = Math.Sqrt((double)number);

                Console.WriteLine(sqrt);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
                Console.ReadKey(true);
            }
        }
    }
}
