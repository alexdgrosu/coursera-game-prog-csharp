namespace Lab03
{
    using System;

    /// <summary>
    /// Converts temperature between Fahrenheit and Celsius.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Converts temperature from Fahrenheit to Celsius and then back again.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            // Read user temperature in Fahrenheit.
            float originalFahrenheit = 0F;
            Console.Write("Enter temperautre (Fahrenheit): ");
            originalFahrenheit = float.Parse(Console.ReadLine());

            // Convert from Fahrenheit to Celsius.
            float convertedToCelsius = ((originalFahrenheit - 32) / 9) * 5;

            // Convert from Celsius back to Fahrenheit.
            float convertedToFahrenheit = ((convertedToCelsius * 9) / 5) + 32;

            // Display converted temperatures.
            Console.WriteLine(string.Format("{0:F1} degrees Fahrenheit is {0:F1} degrees Celsius", 
                originalFahrenheit, 
                convertedToCelsius));

            Console.WriteLine(string.Format("{0:F1} degrees Celsius is {0:F1} degrees Fahrenheit", 
                convertedToCelsius, 
                convertedToFahrenheit));
        }
    }
}