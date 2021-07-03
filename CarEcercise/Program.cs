using System;

namespace CarEcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Truck = new Car();
            Truck.Make = "Ford";
            Truck.Model = "F250";
            Truck.Year = 2021;
            Console.WriteLine($"My work truck is a {Truck.Make} \nThe model is a {Truck.Model} \nIt was built in {Truck.Year}");
            Console.WriteLine("------------------------------------------------------");
            
            Interior Inside = new Interior();
            Inside.Material = "Cloth";
            Inside.FitsNumberOfPeople = 5;
            Inside.HasElectricSeats = false;
            Console.WriteLine($"The Material is {Inside.Material}\nI can fit {Inside.FitsNumberOfPeople} people\nDoes it have electric seats? {Inside.HasElectricSeats}");
            Console.WriteLine("------------------------------------------------------");

            Car WifesCar = new Car();
            WifesCar.Make = "Subaru";
            WifesCar.Model = "Forester";
            WifesCar.Year = 2012;

            Interior WifesCarInside = new Interior();
            WifesCarInside.FitsNumberOfPeople = 5;
            WifesCarInside.Material = "Cloth";
            WifesCarInside.HasElectricSeats = false;

            Console.WriteLine($"My wifes car is a {WifesCar.Year}, {WifesCar.Make}, {WifesCar.Model}\nIt fits {WifesCarInside.FitsNumberOfPeople}, the material is {WifesCarInside.Material} and does it have electric seats? {WifesCarInside.HasElectricSeats}");
            
        }
        
    }
}
