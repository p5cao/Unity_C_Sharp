using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleCards;

namespace Exercise2
{
    /// <summary>
    /// Exercise 2 Solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Practice using lists
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // create deck and hand
            Deck deck = new Deck();
            List<Card> hand = new List<Card>();
            // Compared to array, we don't actually need to specify the size of the list when we create it, \
            // and the list will automatically grow and shrink as we add and remove items from the list
            deck.Shuffle();

            // add card, flip over, and print
            hand.Add(deck.TakeTopCard());
            hand[0].FlipOver();
            hand[0].Print();
            Console.WriteLine();

            // add another card, flip over, and print both cards
            hand.Add(deck.TakeTopCard());
            hand[1].FlipOver();
            hand[1].Print();
            hand[0].Print();

            Console.WriteLine();
        }
    }
}

