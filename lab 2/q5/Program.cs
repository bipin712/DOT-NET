using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create a dictionary with CustomerId as key and CustomerName as value
        Dictionary<int, string> customers = new Dictionary<int, string>();

        // Step 2: Add some sample customers
        customers.Add(101, "John Doe");
        customers.Add(102, "Alice Johnson");
        customers.Add(103, "Michael Smith");
        customers.Add(104, "Emma Watson");

        // Step 3: Print customer details
        Console.WriteLine("Customer Details:");
        foreach (KeyValuePair<int, string> customer in customers)
        {
            Console.WriteLine("CustomerId: {0}, CustomerName: {1}", customer.Key, customer.Value);
        }
    }
}

