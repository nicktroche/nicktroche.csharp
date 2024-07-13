using System;

class Program 
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Perfect Number Checker!");

        while (true)
        {
            Console.Write("Enter a number (or 0 to quit): ");
            string input = Console.ReadLine();

            if (input == "0")
            {
                Console.WriteLine("Thank you for using the Perfect Number Checker.\nGoodbye!");
                break;
            }

            if (int.TryParse(input, out int number))
            {
                if (IsPerfectNumber(number))
                {
                    Console.WriteLine($"{number} is a Perfect Number.");
                }
                else
                {
                    Console.WriteLine($"{number} is Not a Perfect Number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }

    static bool IsPerfectNumber(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        int sumOfDivisors = 1; 

        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                sumOfDivisors += i;
            }
        }

        return sumOfDivisors == num;
    }
}
