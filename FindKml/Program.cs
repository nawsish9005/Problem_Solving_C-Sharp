using System;
using System.Globalization;


//Calculate a car's average consumption being provided the total 
//distance traveled (in Km) and the spent fuel total (in liters).
class Program
{
    static void Main()
    {
        // Read integer value X (total distance)
        int X = int.Parse(Console.ReadLine());

        // Read floating point value Y (total fuel spent)
        double Y = double.Parse(Console.ReadLine());

        // Calculate average consumption
        double result = X / Y;

        // Print result with 3 decimal places
        Console.WriteLine($"{result:F3} km/l");
    }
}
