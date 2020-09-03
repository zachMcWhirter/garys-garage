using System;

namespace GarysGarage
{

    public class Zero : Vehicle, IElectricRide // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine("I'm on a motorcycle thing! rrrrrrrrr!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"Crotch rocket turns {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine("The Tesla stops");
        }
    }
}