//In this problem you have to read an integer value and calculate the smallest possible number of 
//banknotes in which the value may be decomposed. The possible banknotes are 100, 50, 20, 10, 5, 2 and 1.
// Print the read value and the list of banknotes.
using System;

class Program
{
    static void Main()
    {
        // Read input
        int N = int.Parse(Console.ReadLine());

        // Store the original value
        Console.WriteLine(N);

        // Banknotes array (sorted from highest to lowest)
        int[] notes = { 100, 50, 20, 10, 5, 2, 1 };

        // Iterate over each banknote
        foreach (int note in notes)
        {
            // Get the number of banknotes needed
            int count = N / note;

            // Print result
            Console.WriteLine($"{count} nota(s) de R$ {note},00");

            // Update the remaining value
            N %= note;
        }
    }
}
