using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        double R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double pi = 3.14159;
        double A = pi * R * R;

        Console.WriteLine($"A={A:F4}");
    }

}