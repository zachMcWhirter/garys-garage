using System;
public class Ram : Vehicle // Gas powered truck
{
    public double FuelCapacity { get; set; }
    public void RefuelTank()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine($"The dude in the {MainColor} Ram creeps by...putputput.");
    }
    public override void Turn(string direction)
    {
        Console.WriteLine($"Big truck turns {direction} ...smh lady drivers");
    }
    public override void Stop()
    {
        Console.WriteLine("The Ram stops");
    }
}