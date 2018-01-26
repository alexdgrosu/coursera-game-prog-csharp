namespace Lab02
{
    /// <summary>
    /// Demonstrates variables and constants.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrates variables and constants.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            // Declaring and using variables
            int age = 42;
            System.Console.WriteLine(string.Format("My age is {0}", age));

            // Declaring and using constants and variables.
            const int MaxScore = 100;
            int score = 42;

            float percent = (float)score / MaxScore;
            System.Console.WriteLine(string.Format("Your score % is: {0:P0}", percent));
        }
    }
}