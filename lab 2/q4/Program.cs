using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create a generic list of integers
        List<int> numbers = new List<int>();

        // Step 2: Add numbers 1 to 10 into the list
        for (int i = 1; i <= 10; i++)
        {
            numbers.Add(i);
        }

        // Step 3: Print the numbers from the list
        Console.WriteLine("Numbers from 1 to 10:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}

