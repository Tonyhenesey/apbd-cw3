using ConsoleApp1.Exceptions;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public class Container : IContainer
{
    private int _serialNumber;
    private double _cargoWeight;
    private double _height;
    private double _selfWeight;
    private double _depth;
    

    public double CargoWeight { get; set; }

    // public Container(double cargoWeight)
    // {
    //     CargoWeight = cargoWeight;
    // }

    public Container(int serialNumber, double height, double selfWeight, double depth, double cargoWeight)
    {
        List<int> numbers = [];
        _serialNumber = serialNumber;
        _height = height;
        _selfWeight = selfWeight;
        _depth = depth;
        CargoWeight = cargoWeight;
        SerialNumberGenerator(serialNumber,numbers);
    }

  


    public void Unload(double undoCargoWeight)
    {
        Console.WriteLine("Weight after unload: ");
        CargoWeight = CargoWeight - undoCargoWeight;
    }

    public virtual void Load(double cargoWeight)
    {
        Console.WriteLine("Weight after load: ");
        CargoWeight = CargoWeight+cargoWeight;
        if (CargoWeight>30)
        {
            throw new OverFillException();
        }
        
    }
    
    public void SerialNumberGenerator(int serialNumber,List<int> numbers)
    {
        string number = "KON-L-" + serialNumber;
        numbers.Add(serialNumber);
        for (int i = 0; i < numbers.Count; i++)
        {
            if (serialNumber==numbers[i])
            {
                throw new SameSerialNumberException();
            }
        }
    }
}
