namespace ConsoleApp1.Containers;

public class LiquidContainer : Container
{
    public LiquidContainer(int serialNumber, double height, double selfWeight, double depth, double cargoWeight) : base(serialNumber, height, selfWeight, depth, cargoWeight)
    {
        
    }

    public override void Load(double cargoWeight)
    {
        Console.WriteLine("liquidContainer");
        base.Load(10.0);
       
    }
}