using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public class LiquidContainer : Container, IHazardNotifer
{
    private LoadType _loadType;
    private double _selfWeight;

    public LiquidContainer(int serialNumber, double height, double selfWeight, double depth, double cargoWeight,
        LoadType loadType) : base(serialNumber, height, selfWeight, depth, cargoWeight, loadType)
    {
        _loadType = loadType;
        _selfWeight = selfWeight;
    }

    public override void Load(double cargoWeight)
    {
        Console.WriteLine("liquidContainer");
        base.Load(10.0);
        if (_loadType == LoadType.DANGEROUS)
        {
            if (cargoWeight > 0.5 * _selfWeight)
            {
                Console.Error.WriteLine(
                    "Weight of the load for this type of container is to big. We have to decrement it to the half of the container weight");
            }

            cargoWeight = 0.5 * _selfWeight;
        }
        else
        {
            if (cargoWeight > 0.9 * _selfWeight)
            {
                Console.Error.WriteLine(
                    "Weight of the load for this type of container is to big. We have to decrement it to the 90% of the container weight");
            }

            cargoWeight = 0.9 * _selfWeight;
        }
    }
}