using System; 

class URI {

    static void Main(string[] args) { 

        string[] input = Console.ReadLine().Split(' ');
        double A = double.Parse(input[0]);
        double B = double.Parse(input[1]);
        double C = double.Parse(input[2]);
         
         double pi = 3.14159;
         
         double triangle = (A * C)/2;
         double circulo = pi * Math.Pow(C, 2);
         double trapezium = ((A + B) * C) / 2;
         double square = B * B;
         double rectangle = A * B;
         
         Console.WriteLine($"TRIANGULO: {triangle:F3}");
         Console.WriteLine($"CIRCULO: {circulo:F3}");
         Console.WriteLine($"TRAPEZIO: {trapezium:F3}");
         Console.WriteLine($"QUADRADO: {square:F3}");
         Console.WriteLine($"RETANGULO: {rectangle:F3}");

    }

}