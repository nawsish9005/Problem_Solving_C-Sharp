using System; 

// Make a program that reads three floating point values: A, B and C. Then, calculate and show:
// a) the area of the rectangled triangle that has base A and height C.
// b) the area of the radius's circle C. (pi = 3.14159)
// c) the area of the trapezium which has A and B by base, and C by height.
// d) the area of ​​the square that has side B.
// e) the area of the rectangle that has sides A and B.
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