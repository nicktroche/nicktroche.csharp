using System;

class Program
{
    static void Main()
    {
        const int MinTemperature = -30;
        const int MaxTemperature = 130;
        const int NumTemperatures = 5;

        int[] temperatures = new int[NumTemperatures];
        bool isValidInput = false;

        for (int i = 0; i < NumTemperatures; i++)
        {
            while (!isValidInput)
            {
                Console.Write($"Enter temperature #{i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int temp))
                {
                    if (temp >= MinTemperature && temp <= MaxTemperature)
                    {
                        temperatures[i] = temp;
                        isValidInput = true;
                    }
                    else
                    {
                        Console.WriteLine($"Temperature {temp} is invalid. Please enter a valid temperature between {MinTemperature} and {MaxTemperature}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer temperature.");
                }
            }
            isValidInput = false;
        }

        bool isAscending = true;
        bool isDescending = true;
        for (int i = 1; i < NumTemperatures; i++)
        {
            if (temperatures[i] > temperatures[i - 1])
            {
                isDescending = false;
            }
            else if (temperatures[i] < temperatures[i - 1])
            {
                isAscending = false;
            }
        }

        if (isAscending)
        {
            Console.WriteLine("Getting warmer");
        }
        else if (isDescending)
        {
            Console.WriteLine("Getting cooler");
        }
        else
        {
            Console.WriteLine("It's a mixed bag");
        }

        Console.WriteLine("5-day Temperature [" + string.Join(", ", temperatures) + "]");

        double averageTemperature = CalculateAverage(temperatures);
        Console.WriteLine($"Average Temperature is {averageTemperature} degrees");
    }

    static double CalculateAverage(int[] temperatures)
    {
        int sum = 0;
        foreach (int temp in temperatures)
        {
            sum += temp;
        }
        return (double)sum / temperatures.Length;
    }
}
