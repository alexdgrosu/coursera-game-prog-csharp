namespace Lab4
{
    using System;

    /// <summary>
    /// Implements Lab 4 functionality
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Implements Lab 4 functionality
        /// </summary>
        /// <param name="args">command-line args</param>
        private static void Main(string[] args)
        {
            // create a new deck and print the contents of the deck
            Deck deck = new Deck();
            deck.Print();

            // shuffle the deck and print the contents of the deck
            deck.Shuffle();
            deck.Print();

            // take the top card from the deck and print the card rank and suit
            Console.WriteLine();
            Card topCard = deck.TakeTopCard();
            Console.WriteLine(string.Format("Top card: {0} of {1}", topCard.Rank, topCard.Suit));

            // take the top card from the deck and print the card rank and suit
            topCard = deck.TakeTopCard();
            Console.WriteLine(string.Format("Top card: {0} of {1}", topCard.Rank, topCard.Suit));
        }
    }
}