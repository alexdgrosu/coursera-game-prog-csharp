namespace Lab07
{
    using System;

    /// <summary>
    /// Implementation for Lab07.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Implementation for Lab07.
        /// </summary>
        /// <param name="args">Command-line args.</param>
        private static void Main(string[] args)
        {
            Console.Write("In what month were you born? ");
            string month = Console.ReadLine();

            Console.Write("On what day were you born? ");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Format("Your birthday is {0} {1}", month, day));
            Console.WriteLine(string.Format("You’ll receive an email reminder on {0} {1}", month, day - 1));
        }
    }
}