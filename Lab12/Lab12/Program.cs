namespace Lab12
{
    using ConsoleCards;

    /// <summary>
    /// Implementation for Lab12.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Implementation for Lab12.
        /// </summary>
        /// <param name="args">Command-line args.</param>
        private static void Main(string[] args)
        {
            // Declare variables
            Deck deck = new Deck();
            Card[] cards = new Card[5];

            // Shuffle the deck
            deck.Shuffle();

            // Add card to array, flip it over, print card
            cards[0] = deck.TakeTopCard();
            cards[0].FlipOver();
            cards[0].Print();

            System.Console.WriteLine();

            // Add another card to array, flip it it over, print both cards
            cards[1] = deck.TakeTopCard();
            cards[1].FlipOver();
            cards[0].Print();
            cards[1].Print();
        }
    }
}