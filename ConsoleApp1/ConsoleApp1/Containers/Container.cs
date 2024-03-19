using ConsoleApp1.Exceptions;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public abstract class Container : IContainer 
{
    private double _cargoWeight;

    public double CargoWeight { get; set; }

    public Container(double cargoWeight)
    {
        CargoWeight = cargoWeight;
    }

    public void Unload()
    {
        throw new NotImplementedException();
    }

    public virtual void Load(double cargoWeight)
    {
        Console.WriteLine("Container");
        CargoWeight = cargoWeight;
        // throw new OverkillException();
    }
}
