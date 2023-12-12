// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Generate a random number
        Random random = new Random();
        int n = random.Next(); 

        // Print the randomly generated number
        Console.WriteLine($"Random Number: {n}");

        // Get and print the last digit of the number
        int lastDigit = n % 10;
        Console.WriteLine($"Last Digit: {lastDigit}");
    }
}

