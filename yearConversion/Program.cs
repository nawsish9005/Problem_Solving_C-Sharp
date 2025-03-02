using System; 

class URI {

    static void Main(string[] args) { 

        int days = int.Parse(Console.ReadLine());
        
        int years = days / 365;
         days = days % 365;
        int months = days/30;
        
        days = days % 30;

        Console.WriteLine($"{years}: {days}: {months}");
    }

}