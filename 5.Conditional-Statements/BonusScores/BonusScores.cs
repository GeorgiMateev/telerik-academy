using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BonusScores
{
    class BonusScores
    {
        static void Main(string[] args)
        {
            int score;
            while (true)
            {
                try
                {
                    score = int.Parse(Console.ReadLine());
                    if (score < 1 || score > 9)
                    {
                        throw new ArgumentOutOfRangeException("Enter only integer numbers between 1 and 9!");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only integer numbers between 1 and 9!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter only integer numbers between 1 and 9!");
                }
                catch (ArgumentOutOfRangeException err)
                {
                    Console.WriteLine(err.Message);
                }
            }

            switch (score)
            {
                case 1:
                case 2:
                case 3: score *= 10; break;
                case 4:
                case 5:
                case 6: score *= 100; break;
                case 7:
                case 8:
                case 9: score *= 1000; break;
                default:
                    break;
            }

            Console.WriteLine("The new score is: {0}",score);

            Console.ReadKey(true);
        }
    }
}
