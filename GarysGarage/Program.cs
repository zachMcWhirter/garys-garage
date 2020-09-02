using System;
using System.Collections.Generic;

namespace GarysGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Ram Truck = new Ram();
            Truck.MainColor = "Rusty";
            Zero Motorcycle = new Zero();
            Motorcycle.MainColor = "Green";
            Cessna Jet = new Cessna();
            Jet.MainColor = "Silver";
            Tesla Car = new Tesla();
            Car.MainColor = "Red";

            Truck.Drive();
            Truck.Turn("left");
            Truck.Stop();
            Console.WriteLine();
            Motorcycle.Drive();
            Motorcycle.Turn("left");
            Motorcycle.Stop();
            Console.WriteLine();
            Jet.Drive();
            Jet.Turn("left");
            Jet.Stop();
            Console.WriteLine();
            Car.Drive();
            Car.Turn("left");
            Car.Stop();
            Console.WriteLine();
        }

    }

}