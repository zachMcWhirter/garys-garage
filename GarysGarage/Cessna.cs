using System;

public class Cessna : Vehicle
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method definition omitted
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