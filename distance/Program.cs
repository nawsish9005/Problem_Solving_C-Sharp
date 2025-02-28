//Two cars (X and Y) leave in the same direction. The car X leaves with a constant 
//speed of 60 km/h and the car Y leaves with a constant speed of 90 km / h.

//In one hour (60 minutes) the car Y can get a distance of 30 kilometers from the X car,
// in other words, it can get away one kilometer for each 2 minutes.

//Read the distance (in km) and calculate how long it takes (in minutes) for the car Y to take
// this distance in relation to the other car.
using System; 

class URI {

    static void Main(string[] args) { 

        int X = 60;
        int Y = 90;
        int speed = Y - X;
        int givenMinutes = 60;
        
        int cover = givenMinutes / speed;
        
        int time = int.Parse(Console.ReadLine());
        
        int distance = time * cover;
        Console.WriteLine($"{distance} minutos");

    }

}