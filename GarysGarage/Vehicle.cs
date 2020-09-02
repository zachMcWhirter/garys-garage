using System;
public class Vehicle
{
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public virtual void Drive()
    {
        Console.WriteLine("Vrooom!");
    }
    public virtual void Turn(string direction)
    {
        Console.WriteLine("Turn right, no wait left! Kidding, turn right.");
    }
    public virtual void Stop()
    {
        Console.WriteLine("AAHHHH! STOP!.");
    }
}