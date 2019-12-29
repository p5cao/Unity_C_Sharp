﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{    
    /// <summary>
    /// Exercise 9 solution 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates using custom classes
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // create a new deck and tell the deck to print itself
            Deck deck = new Deck();
            deck.Print();
            // tell the deck to shuffle and print itself
            Console.WriteLine();
            Console.WriteLine("Shuffle the deck and print all the cards again:");
            deck.Shuffle();
            deck.Print();
            // take the top card from the deck and print the card rank and suit
            Console.WriteLine();
            Card card0 = deck.TakeTopCard();
            Console.WriteLine("Top card in the deck is " + card0.Rank + " of " + card0.Suit);
            Console.WriteLine();

            // take the top card from the deck and print the card rank and suit
            Console.WriteLine();
            Card card1 = deck.TakeTopCard();
            Console.WriteLine("Top card in the deck is " + card1.Rank + " of " + card1.Suit);
            Console.WriteLine();
        }
    }
}
