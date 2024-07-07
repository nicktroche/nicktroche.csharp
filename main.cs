using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the wind speed in miles per hour:");
        if (double.TryParse(Console.ReadLine(), out double windSpeed))
        {
            string category = CategorizeHurricane(windSpeed);
            Console.WriteLine($"The hurricane category is: {category}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static string CategorizeHurricane(double windSpeed)
    {
        if (windSpeed >= 157)
        {
            return "Category Five Hurricane";
        }
        else if (windSpeed >= 130)
        {
            return "Category Four Hurricane";
        }
        else if (windSpeed >= 111)
        {
            return "Category Three Hurricane";
        }
        else if (windSpeed >= 96)
        {
            return "Category Two Hurricane";
        }
        else if (windSpeed >= 74)
        {
            return "Category One Hurricane";
        }
        else
        {
            return "Not a Hurricane";
        }
    }
}
