namespace ConsoleApp1.Containers;

public class LiquidContainer : Container
{
    
    
    
    public LiquidContainer(double cargoWeight) : base(cargoWeight)
    {
        
    }
    
    public override void Load(double cargoWeight)
    {
        Console.WriteLine("liquidContainer");
        base.Load(10.0);
       
    }
}