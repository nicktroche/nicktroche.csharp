using System;

class Program 
{
  static void Main()
  {
    const double CentimetersPerInch = 2.54;
    //constants 

    double inches;
    double centimeters; 
     //variables

    Console.Write("Enter the measurement in inches: ");
    if (!double.TryParse(Console.ReadLine(), out inches))
    //inputs in inches
    {
      
    }

    centimeters = inches * CentimetersPerInch;
    //calculations

    Console.WriteLine($"{inches} inches is equal to {centimeters} centimeters.");
    //output in centimeters 
  }

}