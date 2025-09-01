using System;

class Program
{
    // Step 1: Define a delegate
    public delegate int AddDelegate(int a, int b);

    // Step 2: Create a method that matches the delegate signature
    public static int AddNumbers(int x, int y)
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        // Step 3: Instantiate the delegate and point to the method
        AddDelegate addDel = new AddDelegate(AddNumbers);

        // Step 4: Use the delegate to call the method
        Console.Write("Enter first digit: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second digit: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int result = addDel(num1, num2);

        // Step 5: Display result
        Console.WriteLine("The sum of {0} and {1} is: {2}", num1, num2, result);
    }
}

