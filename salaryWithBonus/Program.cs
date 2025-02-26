using System; 

class URI {

    static void Main(string[] args) { 

        string userName=Console.ReadLine();
        double fixedSalary=double.Parse(Console.ReadLine());
        double totalSale=double.Parse(Console.ReadLine());
        
        double totalSalary=fixedSalary+(totalSale * 0.15);
        
        Console.WriteLine($"TOTAL = {totalSalary:F2}");

    }

}