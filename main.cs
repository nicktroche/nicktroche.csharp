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

        int revenue = currentYearContestants * 25;

        bool isBigger = currentYearContestants > previousYearContestants;
        bool isMoreThanTwice = currentYearContestants > 2 * previousYearContestants;

        Console.WriteLine($"\nLast year's competition had {previousYearContestants} contestants, and this year's has {currentYearContestants} contestants");
        Console.WriteLine($"Revenue expected this year is ${revenue}");

        if (isMoreThanTwice)
        {
            Console.WriteLine("The competition is more than twice as big this year!");
        }
        else if (isBigger)
        {
            Console.WriteLine("The competition is bigger than ever!");
        }
        else
        {
            Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        }

        Console.WriteLine("\nPress any key to return to the main menu...");
        Console.ReadKey();
        DisplayMenu();
    }
}
