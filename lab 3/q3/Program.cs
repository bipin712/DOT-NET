using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Step 1: Define an array of numbers
        int[] numbers = { 2, 4, 6, 8, 10 };

        // Step 2: Use LINQ to select each number and its square
        var squares = numbers.Select(n => new { Number = n, Square = n * n });

        // Step 3: Display the result
        foreach (var item in squares)
        {
            Console.WriteLine($"Square of Number {item.Number} is {item.Square}");
        }
    }
}

