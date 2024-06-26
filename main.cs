using System;

class Program
{
    static void Main()
    {
        // Constants for pricing
        const double baseRate = 200.0;
        const double hourlyRate = 150.0;
        const double mileageRate = 2.0;

        // Prompt user for inputs
        Console.WriteLine("Enter estimated hours for the job: ");
        double hours = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter estimated miles involved in the move: ");
        double miles = Convert.ToDouble(Console.ReadLine());

        // Calculate total fee
        double totalFee = baseRate + (hourlyRate * hours) + (mileageRate * miles);

        // Print the total fee formatted as currency
        Console.WriteLine($"Total moving fee: ${totalFee:F2}");
    }
}
