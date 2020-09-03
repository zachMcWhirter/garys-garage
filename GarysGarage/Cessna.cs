using System;

namespace GarysGarage
{

    public class Cessna : Vehicle, IRealRide
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine("Jet says Zoooooom!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine("Jet turns upside down!");
        }
        public override void Stop()
        {
            Console.WriteLine("Jet stops Flying! That's not good");
        }
    }
}