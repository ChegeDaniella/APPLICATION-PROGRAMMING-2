using System;

class Program
{
    static void Main()
    {
        string input = "Application Programmin 2!";

        // Call the GetPrefixLength function
        int prefixLength = GetPrefixLength(input, "Application");

        // Print the result
        Console.WriteLine($"Length of the prefix substring: {prefixLength}");
    }

    static int GetPrefixLength(string input, string prefix)
    {
        // Use the StartsWith method to check if input starts with the specified prefix
        if (input.StartsWith(prefix))
        {
            // If it does, return the length of the prefix
            return prefix.Length;
        }
        else
        {
            // If not, return 0 indicating no match
            return 0;
        }
    }
}
