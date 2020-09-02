using System;
public class Tesla : Vehicle // Electric car
{
    public double BatteryKWh { get; set; }
    public void ChargeBattery()
    {

    }
    public override void Drive()
    {
        Console.WriteLine($"The d-bag in the {MainColor} car cut me off BZZZZZ!");
    }
    public override void Turn(string direction)
    {
        Console.WriteLine($"Electric Car turns {direction} ...smh more lady drivers");
    }
    public override void Stop()
    {
        Console.WriteLine("The Tesla stops");
    }
}