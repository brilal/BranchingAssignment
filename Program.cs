using System;

class Program
{
    static void Main()
    {
        // Display the required welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user for the package weight
        Console.Write("Please enter the package weight: ");
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // Check if the package is too heavy
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End the program
        }

        // Prompt for package width
        Console.Write("Please enter the package width: ");
        decimal width = Convert.ToDecimal(Console.ReadLine());

        // Prompt for package height
        Console.Write("Please enter the package height: ");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        // Prompt for package length
        Console.Write("Please enter the package length: ");
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // Check if the total dimensions exceed the limit
        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // End the program
        }

        // Calculate the shipping quote:
        // Multiply width × height × length × weight, then divide by 100
        decimal quote = (width * height * length * weight) / 100;

        // Display the quote formatted as currency (e.g., $528.00)
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

        // Thank the user
        Console.WriteLine("Thank you!");
    }
}
