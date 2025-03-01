using System;
//Read an integer value, which is the duration in seconds of a certain event in a factory, 
//and inform it expressed in hours:minutes:seconds.
class Program
{
    static void Main()
    {
        // Read the input values for A and B
        int A = int.Parse(Console.ReadLine());

        // Calculate the sum of A and B
        int hour = A / 3600;
        int minute=(A%3600)/60;
        int second=A%60;

        // Print the result in the required format
        Console.WriteLine($"{hour}:{minute}:{second}");
    }
}
