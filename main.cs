using System;

class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("*  The stars shine in Greenville.  *");
            Console.WriteLine("************************************");
            Console.WriteLine("Please Enter the following number below from the following menu:\n");
            Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
            Console.WriteLine("2. Exit");

            bool isValidInput = false;
            while (!isValidInput)
            {
                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CalculateRevenue();
                        break;
                    case "2":
                        Console.WriteLine("\nThank you for using the Greenville Revenue App, good-bye!");
                        isValidInput = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter 1 or 2.");
                        break;
                }
            }
        }

        static void CalculateRevenue()
        {
            Console.Write("\nEnter number of contestants in previous year: ");
            int previousYearContestants = int.Parse(Console.ReadLine());

            Console.Write("Enter number of contestants in current year: ");
            int currentYearContestants = int.Parse(Console.ReadLine());

            // Calculate revenue
            int revenue = currentYearContestants * 25;

            // Determine if this year's competition is bigger
            bool isBigger = currentYearContestants > previousYearContestants;

            // Output results
            Console.WriteLine($"\nLast year's competition had {previousYearContestants} contestants, and this year's has {currentYearContestants} contestants");
            Console.WriteLine($"Revenue expected this year is ${revenue}");
            Console.WriteLine($"It is {(isBigger ? "true" : "false")} that this year's competition is bigger than last year's.");
            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
            DisplayMenu();
        }
    }

