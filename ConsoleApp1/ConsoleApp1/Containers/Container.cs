using ConsoleApp1.Exceptions;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public class Container : IContainer , IHazardNotifer
{
    private int _serialNumber;
    private double _cargoWeight;
    private double _height;
    private double _selfWeight;
    private double _depth;
    private LoadType _loadType; 
    public enum LoadType
    {
        DANGEROUS,
        NORMAL
        
    }
    
    

    public double CargoWeight { get; set; }
    
    
    
    

    

    public Container(int serialNumber, double height, double selfWeight, double depth, double cargoWeight,LoadType loadType)
    {
        List<int> numbers = [];
        _serialNumber = serialNumber;
        _height = height;
        _selfWeight = selfWeight;
        _depth = depth;
        CargoWeight = cargoWeight;
        SerialNumberGenerator(serialNumber,numbers);
        _loadType = loadType;
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
            if (numbers.Count>=2 && serialNumber==numbers[i])
            {
                throw new SameSerialNumberException();
            }
        }
    }

    public void SendHazardNotification(string message)
    {
        if (_loadType==LoadType.DANGEROUS)
        {
            Console.WriteLine("Attention! \n" +
                              "DANGEROUS LOAD DETECTED\n" +
                              "POSIBILITY OF EXPLODING!\n" +
                              "CONTAINER: "+ _serialNumber);
        }
    }
}
