using ConsoleApp1.Exceptions;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public class GasContainer : Container, IHazardNotifer
{
    private double pressure;
    private GasContainer _gasContainer;
    private LoadType _loadType;
    private int _serialNumber;
    private double _cargoWeight;


    public GasContainer(int serialNumber, double pressure, double height, double selfWeight, double depth,
        double cargoWeight, LoadType loadType) : base(serialNumber, height, selfWeight, depth, cargoWeight, loadType)
    {
        _loadType = loadType;
        _serialNumber = serialNumber;
        _cargoWeight = cargoWeight;
        if (_cargoWeight > selfWeight) throw new OverFillException("There is not enough place for gas.");
    }

    public void SendHazardNotification(string message)
    {
        if (_loadType == LoadType.DANGEROUS)
        {
            Console.WriteLine("Attention! \n" +
                              "DANGEROUS LOAD DETECTED\n" +
                              "POSIBILITY OF EXPLODING!\n" +
                              "CONTAINER: " + _serialNumber);
        }
    }

    public override void Unload(double undoCargoWeight)
    {
        undoCargoWeight = 0.95 * _cargoWeight;
        base.Unload(undoCargoWeight);
    }
}