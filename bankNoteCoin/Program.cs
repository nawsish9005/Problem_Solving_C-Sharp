using System;

class Program
{
    static void DecomposeCurrency(decimal amount)
    {
        int[] notes = { 100, 50, 20, 10, 5, 2 };
        decimal[] coins = { 1.00m, 0.50m, 0.25m, 0.10m, 0.05m, 0.01m };
        
        Console.WriteLine("NOTAS:");
        foreach (int note in notes)
        {
            int count = (int)(amount / note);
            Console.WriteLine($"{count} nota(s) de R$ {note}.00");
            amount -= count * note;
        }
        
        Console.WriteLine("MOEDAS:");
        foreach (decimal coin in coins)
        {
            int count = (int)(amount / coin);
            Console.WriteLine($"{count} moeda(s) de R$ {coin:F2}");
            amount -= count * coin;
        }
    }

    static void Main()
    {
        decimal N = decimal.Parse(Console.ReadLine());
        DecomposeCurrency(N);
    }
}
