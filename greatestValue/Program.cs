
// Make a program that reads 3 integer values and present the greatest one followed by the message 
// "eh o maior". Use the following formula:

using System; 

class URI {

    static void Main(string[] args) { 

       string[] input = Console.ReadLine().Split(' ');
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int C = int.Parse(input[2]);
        
        int result = (A + B+Math.Abs(A-B))/2;
        int maior = (result + C + Math.Abs(result - C)) / 2;
        
        Console.WriteLine($"{maior} eh o maior");

    }

}