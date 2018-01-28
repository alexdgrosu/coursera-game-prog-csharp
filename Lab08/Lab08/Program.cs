namespace Lab08
{
    using System;

    /// <summary>
    /// Implementation for Lab08.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Implementation for Lab08.
        /// </summary>
        /// <param name="args">Command-line args.</param>
        private static void Main(string[] args)
        {
            Console.Write("<pyramid slot number>,<block letter>,<whether or not the block should be lit>: ");
            string csv = Console.ReadLine();

            // NOTE: This is the beginner way of doing it. It would be easier to use
            //       <string>.Split(params char[] separator) instead.
            int commaIndex = csv.IndexOf(',');
            int slotNumber = int.Parse(csv.Substring(0, commaIndex));

            csv = csv.Substring(commaIndex + 1);
            commaIndex = csv.IndexOf(',');
            char blockLetter = csv.Substring(0, commaIndex)[0];

            csv = csv.Substring(commaIndex + 1);
            bool isLit = bool.Parse(csv);

            Console.WriteLine(string.Format("({0}, {1}, {2})", slotNumber, blockLetter, isLit));
        }
    }
}