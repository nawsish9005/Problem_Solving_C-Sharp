using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        double N1 = double.Parse(input[0]);
        double N2 = double.Parse(input[1]);
        double N3 = double.Parse(input[2]);
        double N4 = double.Parse(input[3]);

        // Weighted average calculation
        double average = ((N1 * 2) + (N2 * 3) + (N3 * 4) + (N4 * 1)) / 10.0;

        // Ensuring correct rounding (if needed)
        average = Math.Floor(average * 10) / 10.0;

        Console.WriteLine($"Media: {average.ToString("0.0")}");

        if (average >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (average < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");

            double examScore = double.Parse(Console.ReadLine());
            Console.WriteLine($"Nota do exame: {examScore.ToString("0.0")}");

            double finalAverage = (average + examScore) / 2.0;
            finalAverage = Math.Floor(finalAverage * 10) / 10.0; // Ensure proper rounding

            if (finalAverage >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }

            Console.WriteLine($"Media final: {finalAverage.ToString("0.0")}");
        }
    }
}
