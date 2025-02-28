//Read the four values corresponding to the x and y axes of two points in 
//the plane, p1 (x1, y1) and p2 (x2, y2) and calculate the distance between them, 
 using System; 

class URI {

    static void Main(string[] args) { 

        string[] point1 = Console.ReadLine().Split(' ');
        double X1 = double.Parse(point1[0]);
        double Y1 = double.Parse(point1[1]);
        string[] point2 = Console.ReadLine().Split(' ');
        double X2 = double.Parse(point2[0]);
        double Y2 = double.Parse(point2[1]);
        
        double result = Math.Sqrt(Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2));
        Console.WriteLine($"{result:F4}");
    }

}