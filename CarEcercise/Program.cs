using System;

namespace CarEcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Truck = new Car();
            Truck.Make = "Ford";
            Truck.Modle = "F250";
            Truck.Year = 2021;
            Console.WriteLine($"My work truck is a {Truck.Make} \nThe modle is a {Truck.Modle} \nIt was built in {Truck.Year}");
        }
    }
}
