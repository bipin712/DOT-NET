using System;

class Program
{
    static void Main()
    {
        string str1 = "Hello";
        Console.WriteLine("Original string: " + str1);

        // Modify the string (actually creates a new string)
        string str2 = str1 + " World";

        Console.WriteLine("After modification:");
        Console.WriteLine("str1: " + str1);  // Still "Hello"
        Console.WriteLine("str2: " + str2);  // "Hello World"

        // Check if str1 and str2 point to the same memory location
        if (object.ReferenceEquals(str1, str2))
            Console.WriteLine("str1 and str2 refer to the same object.");
        else
            Console.WriteLine("str1 and str2 refer to different objects.");
    }
}


