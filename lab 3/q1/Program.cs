using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Step 1: Create a list of student marks
        List<int> studentMarks = new List<int> { 75, 82, 90, 68, 95, 55, 88 };

        // Step 2: Use LINQ to find students with marks > 80
        var highScorers = studentMarks.Where(mark => mark > 80);

        // Step 3: Count the number of students
        int count = highScorers.Count();

        // Step 4: Display the result
        Console.WriteLine("Number of students scoring more than 80: " + count);

        // Optional: Display the marks of students scoring > 80
        Console.WriteLine("Marks of students scoring more than 80: " + string.Join(", ", highScorers));
    }
}

