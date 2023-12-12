using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine($"Before swap: a = {a}, b = {b}");

        // Call the Swap function to swap the values
        Swap(ref a, ref b);

        Console.WriteLine($"After swap: a = {a}, b = {b}");
    }

    static void Swap(ref int x, ref int y)
    {
        // Use a temporary variable to swap the values
        int temp = x;
        x = y;
        y = temp;
    }
}

