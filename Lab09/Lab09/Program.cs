namespace Lab09
{
    using System;

    /// <summary>
    /// Implementation for Lab09.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Implementation for Lab09.
        /// </summary>
        /// <param name="args">Command-line args.</param>
        private static void Main(string[] args)
        {
            const string separator = "**************";

            Console.WriteLine(separator);
            Console.WriteLine("Menu: ");
            Console.WriteLine();
            Console.WriteLine("N - New Game");
            Console.WriteLine("L - Load Game");
            Console.WriteLine("O - Options");
            Console.WriteLine("Q - Quit");
            Console.WriteLine(separator);

            Console.Write("Enter your choice: ");
            char userChoice = Console.ReadLine()[0];

            if (userChoice == 'N' || userChoice == 'L')
            {
                Console.WriteLine("Loading game...");
            }
            else if (userChoice == 'O')
            {
                Console.WriteLine("Showing options...");
            }
            else if (userChoice == 'Q')
            {
                Console.WriteLine("Quitting game...");
            }
            else
            {
                Console.WriteLine("Choice not recognized");
            }

            switch (userChoice)
            {
                case 'N':
                case 'L':
                    Console.WriteLine("Loading game...");
                    break;

                case 'O':
                    Console.WriteLine("Showing options...");
                    break;

                case 'Q':
                    Console.WriteLine("Quitting game...");
                    break;

                default:
                    Console.WriteLine("Choice not recognized");
                    break;
            }
        }
    }
}