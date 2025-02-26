using System; 

class URI {

    static void Main(string[] args) { 
        
        string[] product1 = Console.ReadLine().Split(' ');
        string[] product2 = Console.ReadLine().Split(' ');
        
        int code1 = int.Parse(product1[0]);
        int quantity1 = int.Parse(product1[1]);
        double price1 = double.Parse(product1[2]);
        
        int code2 = int.Parse(product2[0]);
        int quantity2 = int.Parse(product2[1]);
        double price2 = double.Parse(product2[2]);
        
        double total= (quantity1 * price1) + (quantity2 * price2);
        Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");

    }

}