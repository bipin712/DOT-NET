using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Step 1: Input string from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Step 2: Use LINQ to group characters and count frequency
        var characterFrequency = input
            .GroupBy(c => c)             // Group by character
            .Select(g => new { Char = g.Key, Count = g.Count() }); // Get count of each group

        // Step 3: Display result
        Console.WriteLine("\nCharacter frequencies:");
        foreach (var item in characterFrequency)
        {
            Console.WriteLine($"Character '{item.Char}' occurs {item.Count} time(s)");
        }
    }
}

