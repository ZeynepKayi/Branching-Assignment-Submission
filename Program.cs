
using System;

class PackageEstimator
{
    static void Main()
    {
        Console.WriteLine("=== Welcome to Package Express ===");
        Console.WriteLine("Please provide the package details below.");

        Console.Write("Weight of the package: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal weight))
        {
            Console.WriteLine("Error: Invalid weight input.");
            return;
        }

        if (weight > 50)
        {
            Console.WriteLine("Sorry, the package exceeds the weight limit for Package Express. Have a great day!");
            return;
        }

        Console.Write("Package Width: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal width))
        {
            Console.WriteLine("Error: Invalid width input.");
            return;
        }

        Console.Write("Package Height: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal height))
        {
            Console.WriteLine("Error: Invalid height input.");
            return;
        }

        Console.Write("Package Length: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal length))
        {
            Console.WriteLine("Error: Invalid length input.");
            return;
        }

        decimal totalDimensions = width + height + length;
        if (totalDimensions > 50)
        {
            Console.WriteLine("The package dimensions are too large for Package Express.");
            return;
        }

        decimal costEstimate = (width * height * length * weight) / 100;
        Console.WriteLine($"Estimated shipping cost: ${costEstimate:0.00}");
        Console.WriteLine("Thanks for choosing Package Express!");
    }
}
