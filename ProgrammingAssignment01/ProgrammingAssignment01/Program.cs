namespace ProgrammingAssignment01
{
    using System;

    /// <summary>
    /// This program is able to compute the distance and angle (in radians and degrees) between two
    /// arbitrary points place in a X Y coordinate system.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Compute the distance and angle between two points.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome! This program is going to calculate the distance and angle between two points.");

            // Prompt and read X Y coordinates for two points.
            Console.Write("Point 1 X: ");
            float point1X = float.Parse(Console.ReadLine());

            Console.Write("Point 1 Y: ");
            float point1Y = float.Parse(Console.ReadLine());

            Console.Write("Point 2 X: ");
            float point2X = float.Parse(Console.ReadLine());

            Console.Write("Point 2 Y: ");
            float point2Y = float.Parse(Console.ReadLine());

            // Compute delta for X and Y coordinates for the two points.
            float deltaX = point2X - point1X;
            float deltaY = point2Y - point1Y;

            // Compute distance between the two points.
            double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));

            // Compute the angle (in radians) between the two points.
            double angleInRadians = Math.Atan2(deltaY, deltaX);

            // Compute the angle (in degrees) between the two points.
            double angleInDegrees = (angleInRadians * 180) / Math.PI;

            // Output the computed results.
            Console.WriteLine(string.Format("Distance between points: {0:F3}", distance));
            Console.WriteLine(string.Format("Angle between points: {0:F3} degrees", angleInDegrees));
        }
    }
}