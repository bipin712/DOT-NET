using System;

// Step 1: Define an interface
interface ICalculator
{
    int Add(int a, int b);
    int Subtract(int a, int b);
    int Multiply(int a, int b);
    double Divide(int a, int b);
}

// Step 2: Implement the interface in a class
class Calculator : ICalculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero!");
            return double.NaN; // Return "Not a Number"
        }
        return (double)a / b;
    }
}

// Step 3: Use the class in Main()
class Program
{
    static void Main(string[] args)
    {
        ICalculator calc = new Calculator();

        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nResults:");
        Console.WriteLine("Addition: " + calc.Add(num1, num2));
        Console.WriteLine("Subtraction: " + calc.Subtract(num1, num2));
        Console.WriteLine("Multiplication: " + calc.Multiply(num1, num2));
        Console.WriteLine("Division: " + calc.Divide(num1, num2));
    }
}
