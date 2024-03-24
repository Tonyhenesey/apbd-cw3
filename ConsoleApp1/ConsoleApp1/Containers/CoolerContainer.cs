namespace ConsoleApp1.Containers;

public class CoolerContainer : Container
{
    private PossibleProducts _possibleProducts;
    private double _temperature;

    public CoolerContainer(int serialNumber, double height, double selfWeight, double depth, double cargoWeight, LoadType loadType, PossibleProducts possibleProducts, double temperature) : base(serialNumber, height, selfWeight, depth, cargoWeight, loadType)
    {
        _possibleProducts = possibleProducts;
        _temperature = temperature;
    }
}