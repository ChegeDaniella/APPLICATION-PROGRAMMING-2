using System;

class Program
{
    static void Main()
    {
        // Generate a random number
        Random random = new Random();
        int n = random.Next(-10, 11); // Generates a random integer between -10 and 10

        // Print the randomly generated number
        Console.WriteLine($"Random Number: {n}");

        // Check if the number is positive or negative
        if (n > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (n < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}

