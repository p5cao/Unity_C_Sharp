using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace Exercise1
{
    /// <summary>
    /// Exercise 1 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Practices using arrays
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Card[] Cards = new Card[5];
            deck.Shuffle();

            Cards[0] = deck.TakeTopCard();
            Cards[0].FlipOver();
            Cards[0].Print();

            Cards[1] = deck.TakeTopCard();
            Cards[1].FlipOver();
            Cards[0].Print();
            Cards[1].Print();

            Console.WriteLine();
        }
    }
}
