using System;

// Step 1: Create a user-defined exception class
public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Step 2: Read balance from user
            Console.Write("Enter your balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            // Step 3: Read withdraw amount
            Console.Write("Enter withdraw amount: ");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());

            // Step 4: Check and process
            if (withdrawAmount <= balance)
            {
                double remainingBalance = balance - withdrawAmount;
                Console.WriteLine("Withdrawal successful!");
                Console.WriteLine("Remaining Balance: " + remainingBalance);
            }
            else
            {
                // Step 5: Throw custom exception
                throw new InsufficientBalanceException("Error: Withdrawal amount exceeds available balance!");
            }
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            // Handles any unexpected errors
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}

