using System; 

class URI {

    static void Main(string[] args) {

        Dictionary<int, double> priceTable = new Dictionary<int, double>
        {
            { 1, 4.00 },
            { 2, 4.50 },
            { 3, 5.00 },
            { 4, 2.00 },
            { 5, 1.50 }
        };

        string[] input = Console.ReadLine().Split(' ');
        int x = int.Parse(input[0]);
        int y = int.Parse(input[1]);

        double total = priceTable[x] * y;
        Console.WriteLine($"Total: R$ {total:F2}");
    }

}