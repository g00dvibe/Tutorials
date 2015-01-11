// Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
// The cards should be printed with their English names. Use nested for loops and switch-case.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards
{
    class Task11
    {
        static void Main()
        {
            string[] suit = { "Clubs", "Diamonds", "Hearts", "Spades" };
            foreach (var suits in suit)
            {
                for (int card = 1; card <=13; card++)
                {
                    switch (card)
                    {
                        case 1: Console.WriteLine("Ace of {0}", suits); break;
                        case 2: Console.WriteLine("Two of {0}", suits); break;
                        case 3: Console.WriteLine("Three of {0}", suits); break;
                        case 4: Console.WriteLine("Four of {0}", suits); break;
                        case 5: Console.WriteLine("Five of {0}", suits); break;
                        case 6: Console.WriteLine("Six of {0}", suits); break;
                        case 7: Console.WriteLine("Seven of {0}", suits); break;
                        case 8: Console.WriteLine("Eight of {0}", suits); break;
                        case 9: Console.WriteLine("Nine of {0}", suits); break;
                        case 10: Console.WriteLine("Ten of {0}", suits); break;
                        case 11: Console.WriteLine("Jack of {0}", suits); break;
                        case 12: Console.WriteLine("Queen of {0}", suits); break;
                        case 13: Console.WriteLine("King of {0}", suits); break;
                        default: break;
                    }
                }
            }
        }
    }
}
