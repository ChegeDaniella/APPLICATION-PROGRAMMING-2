using System;

class Reverse
{
    static void Main()
    {
        // Call the PrintStringReversed function
        PrintStringReversed("Application Programming");
    }

    static void PrintStringReversed(string input)
    {
        // Convert the string to a character array
        char[] charArray = input.ToCharArray();

        // Reverse the character array
        Array.Reverse(charArray);

        // Convert the character array back to a string and print
        string reversedString = new string(charArray);
        Console.WriteLine(reversedString);
    }
}
