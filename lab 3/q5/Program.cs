using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Step 1: Input an array of strings from the user
        Console.WriteLine("Enter the number of strings:");
        int n = Convert.ToInt32(Console.ReadLine());

        string[] strings = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter string {i + 1}: ");
            strings[i] = Console.ReadLine();
        }

        // Step 2: Input the specific character
        Console.Write("Enter the specific character: ");
        char ch = Convert.ToChar(Console.ReadLine());

        // Step 3: Find strings that start and end with the character
        var matchedStrings = strings
            .Where(s => s.Length > 0 && s[0] == ch && s[s.Length - 1] == ch);

        // Step 4: Display results
        Console.WriteLine("\nStrings that start and end with '" + ch + "':");
        foreach (var str in matchedStrings)
        {
            Console.WriteLine(str);
        }
    }
}

