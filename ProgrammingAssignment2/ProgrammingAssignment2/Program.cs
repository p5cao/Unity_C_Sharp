using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Welcome!");
            Console.WriteLine("This is for Programming Assignment 2 of Dr.T's class.");
            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();
            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Console.WriteLine("Dealed 2 cards each to 3 players.");
            // deal first card to each player
            Card player1_Card1 = deck.TakeTopCard();
            Card player2_Card1 = deck.TakeTopCard();
            Card player3_Card1 = deck.TakeTopCard();
            // deal second card to each player
            Card player1_Card2 = deck.TakeTopCard();
            Card player2_Card2 = deck.TakeTopCard();
            Card player3_Card2 = deck.TakeTopCard();
            // flip all the cards over
            player1_Card1.FlipOver();
            player1_Card2.FlipOver();
            player2_Card1.FlipOver();
            player2_Card2.FlipOver();
            player3_Card1.FlipOver();
            player3_Card2.FlipOver();
            // print the cards for player 1
            Console.WriteLine("The first card of player 1's is "+ player1_Card1.Rank + " of " + player1_Card1.Suit);
            Console.WriteLine("The second card of player 1's is " + player1_Card2.Rank + " of " + player1_Card2.Suit);
            // print the cards for player 2
            Console.WriteLine("The first card of player 2's is " + player2_Card1.Rank + " of " + player2_Card1.Suit);
            Console.WriteLine("The second card of player 2's is " + player2_Card2.Rank + " of " + player2_Card2.Suit);
            // print the cards for player 3
            Console.WriteLine("The first card of player 3's is " + player3_Card1.Rank + " of " + player3_Card1.Suit);
            Console.WriteLine("The second card of player 3's is " + player3_Card2.Rank + " of " + player3_Card2.Suit);
            Console.WriteLine();
        }
    }
}
