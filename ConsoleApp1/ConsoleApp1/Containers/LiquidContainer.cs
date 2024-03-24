using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public class LiquidContainer : Container, IHazardNotifer
{
    public LiquidContainer(int serialNumber, double height, double selfWeight, double depth, double cargoWeight,LoadType loadType) : base(serialNumber, height, selfWeight, depth, cargoWeight,loadType)
    {
        if (loadType==LoadType.DANGEROUS )
        {
            if (cargoWeight>0.5*selfWeight)
            {
                Console.Error.WriteLine("Weight of the load for this type of container is to big. We have to decrement it to the half of the container weight");
            }
            cargoWeight = 0.5 * selfWeight;
            
        }
        else
        {
            if (cargoWeight>0.9*selfWeight)
            {
                Console.Error.WriteLine("Weight of the load for this type of container is to big. We have to decrement it to the 90% of the container weight");
            }
            cargoWeight = 0.9 * selfWeight;
        }
    }

    public override void Load(double cargoWeight)
    {
        Console.WriteLine("liquidContainer");
        base.Load(10.0);
       
    }
    
}