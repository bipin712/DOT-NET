using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Step 1: Input string from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Step 2: Use LINQ to find uppercase letters
        var upperCaseLetters = input.Where(c => Char.IsUpper(c));

        // Step 3: Display the result
        Console.WriteLine("Uppercase letters in the string: " + string.Join(", ", upperCaseLetters));

        // Optional: Count the number of uppercase letters
        Console.WriteLine("Number of uppercase letters: " + upperCaseLetters.Count());
    }
}
