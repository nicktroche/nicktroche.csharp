using System;

class HomeSales

{
    static void Main()
    {
        int salesPersonDTotal = 0;
        int salesPersonETotal = 0;
        int salesPersonFTotal = 0;
        int grandTotal = 0;
        char salesPersonInitial;

        Console.WriteLine("Enter the salesperson initial (D, E, or F) or Z to finish:");

        while (true)
        {
            Console.Write("Salesperson initial: ");
            string input = Console.ReadLine().ToUpper(); 

            if (input == "Z")
                break;

            if (input != "D" && input != "E" && input != "F")
            {
                Console.WriteLine("Error, invalid salesperson selected, please try again.");
                continue;
            }

            salesPersonInitial = input[0]; 

            Console.Write("Amount of sale: ");
            if (!int.TryParse(Console.ReadLine(), out int saleAmount))
            {
                Console.WriteLine("Invalid input for sale amount. Please enter a valid integer.");
                continue;
            }

            switch (salesPersonInitial)
            {
                case 'D':
                    salesPersonDTotal += saleAmount;
                    break;
                case 'E':
                    salesPersonETotal += saleAmount;
                    break;
                case 'F':
                    salesPersonFTotal += saleAmount;
                    break;
                default:
                    break;
            }

            grandTotal += saleAmount;
        }

        Console.WriteLine($"\nGrand Total: ${grandTotal}");
        
        int highestTotal = Math.Max(salesPersonDTotal, Math.Max(salesPersonETotal, salesPersonFTotal));
        string highestSalesperson = "";
        
        if (highestTotal == salesPersonDTotal)
            highestSalesperson = "D";
        else if (highestTotal == salesPersonETotal)
            highestSalesperson = "E";
        else if (highestTotal == salesPersonFTotal)
            highestSalesperson = "F";
        
        Console.WriteLine($"Highest Sale: {highestSalesperson}");

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey(); 
    }
}
