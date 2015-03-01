using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.Cards
{
    class Cards
    {
        static void Main(string[] args)
        {
            string color = null;
            string card = null;
            for (int i = 1; i <= 4; i++)
            {
                
                switch (i)
                {
                    case 1: color = "spades"; break;
                    case 2: color = "hearts"; break;
                    case 3: color = "diamonds"; break;
                    case 4: color = "clubs"; break;
                    default:
                        break;
                }
                for (int j = 2; j <= 14; j++)
                {
                    
                    switch (j)
                    {
                        case 2: card = "Two"; break;
                        case 3: card = "Three"; break;
                        case 4: card = "Four"; break;
                        case 5: card = "Five"; break;
                        case 6: card = "Six"; break;
                        case 7: card = "Seven"; break;
                        case 8: card = "Eight"; break;
                        case 9: card = "Nine"; break;
                        case 10: card = "Ten"; break;
                        case 11: card = "Ace"; break;
                        case 12: card = "Jack"; break;
                        case 13: card = "Queen"; break;
                        case 14: card = "King"; break;

                        default:
                            break;
                    }
                    Console.WriteLine(card + " " + color);
                }
            }

            Console.ReadKey(true);
        }
    }
}
