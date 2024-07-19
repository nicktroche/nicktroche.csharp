using System;

class Program
{
    static void Main()
    {
        string[] salespersons = { "Danielle", "Edward", "Francis" };
        char[] allowedInitials = { 'D', 'E', 'F' };
        int[] sales = new int[salespersons.Length];
        
        int grandTotal = 0;
        char highestSaleInitial = ' '; 
        int highestSaleAmount = 0;

        while (true)
        {
            Console.Write("Enter salesperson initial (D, E, F) or 'Q' to quit: ");
            char initial = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (initial == 'Q')
            {
                break;
            }

            int index = Array.IndexOf(allowedInitials, initial);

            if (index == -1)
            {
                Console.WriteLine("Error, invalid salesperson selected, please try again");
                continue;
            }

            Console.Write("Enter sale amount: ");
            int saleAmount;
            if (!int.TryParse(Console.ReadLine(), out saleAmount) || saleAmount < 0)
            {
                Console.WriteLine("Invalid sale amount, please enter a valid positive number.");
                continue;
            }

            sales[index] += saleAmount;
            grandTotal += saleAmount;

            if (saleAmount > highestSaleAmount)
            {
                highestSaleAmount = saleAmount;
                highestSaleInitial = initial;
            }

            Console.WriteLine($"Salesperson: {salespersons[index]} Sale amount: ${saleAmount:n0}");
        }

        Console.WriteLine();
        Console.WriteLine($"Grand Total: ${grandTotal:n0}");

        if (highestSaleInitial != ' ')
        {
            int highestIndex = Array.IndexOf(allowedInitials, highestSaleInitial);
            Console.WriteLine($"Highest Sale: {salespersons[highestIndex]}");
        }
    }
}