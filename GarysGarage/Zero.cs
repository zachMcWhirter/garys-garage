using System;

public class Zero : Vehicle // Electric motorcycle
{
    public double BatteryKWh { get; set; }
    public void ChargeBattery()
    {

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