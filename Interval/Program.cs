﻿using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Read input and parse it as a double
        double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Check the intervals
        if (number >= 0 && number <= 25)
        {
            Console.WriteLine("Intervalo [0,25]");
        }
        else if (number > 25 && number <= 50)
        {
            Console.WriteLine("Intervalo (25,50]");
        }
        else if (number > 50 && number <= 75)
        {
            Console.WriteLine("Intervalo (50,75]");
        }
        else if (number > 75 && number <= 100)
        {
            Console.WriteLine("Intervalo (75,100]");
        }
        else
        {
            Console.WriteLine("Fora de intervalo");
        }
    }
}
