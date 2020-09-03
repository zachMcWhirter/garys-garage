using System;
using System.Collections.Generic;

namespace GarysGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ram Truck = new Ram();
            // Truck.MainColor = "Rusty";
            // Zero Motorcycle = new Zero();
            // Motorcycle.MainColor = "Green";
            // Cessna Jet = new Cessna();
            // Jet.MainColor = "Silver";
            // Tesla Car = new Tesla();
            // Car.MainColor = "Red";

            // Truck.Drive();
            // Truck.Turn("left");
            // Truck.Stop();
            // Console.WriteLine();
            // Motorcycle.Drive();
            // Motorcycle.Turn("left");
            // Motorcycle.Stop();
            // Console.WriteLine();
            // Jet.Drive();
            // Jet.Turn("left");
            // Jet.Stop();
            // Console.WriteLine();
            // Car.Drive();
            // Car.Turn("left");
            // Car.Stop();
            // Console.WriteLine();

            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectricRide> electricVehicles = new List<IElectricRide>()
            {
                fx,
                fxs,
                modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricRide ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach (IElectricRide ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectricRide ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IRealRide> gasVehicles = new List<IRealRide>()
            {
                ram,
                cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach (IRealRide gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach (IRealRide gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IRealRide gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }

    }

}