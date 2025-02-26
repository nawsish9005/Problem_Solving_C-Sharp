using System; 

class URI {

    static void Main(string[] args) { 

        int number = int.Parse(Console.ReadLine());
        int workHour = int.Parse(Console.ReadLine());
        double hourlyRate = double.Parse(Console.ReadLine());
        
        double salary = workHour * hourlyRate;
        Console.WriteLine($"NUMBER = {number}");
        Console.WriteLine($"SALARY = U$ {salary:F2}");

    }

}