using ConsoleApp1.Containers;

namespace ConsoleApp1.ContainerShip;

public class ContainerShip : Container
{
    private List<Container> _containers;
    private double _maxvelocity;
    private double _maxShipweight;
    private int _maxContainerCount;
    int _serialNumber;
    double _pressure;
    double _height;
    double _selfWeight;
    double _depth;
    double _cargoWeight;
    LoadType _loadType;
    private double _temperature;

    public ContainerShip(List<Container> containers, double maxvelocity, double maxShipweight, int maxContainerCount)
    {
        _containers = containers;
        _maxvelocity = maxvelocity;
        _maxShipweight = maxShipweight;
        _maxContainerCount = maxContainerCount;
    }

    public ContainerShip(int serialNumber, double height, double selfWeight, double depth, double cargoWeight, LoadType loadType, List<Container> containers, double maxvelocity, double maxShipweight, int maxContainerCount) : base(serialNumber, height, selfWeight, depth, cargoWeight, loadType)
    {
        _containers = containers;
        _maxvelocity = maxvelocity;
        _maxShipweight = maxShipweight;
        _maxContainerCount = maxContainerCount;
    }

    public void CreateContainer(Container container)
    {
        container = null;
        Console.WriteLine("Wybierz rodzaj kontenera:\n" +
                          "1. GasContainer\n" +
                          "2. LiquidContainer\n" +
                          "3. CoolerContainer");

        string userInput = Console.ReadLine();

        
        switch (userInput)
        {
            case "1":
                Console.WriteLine("Podaj numer seryjny:");
                _serialNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj ciśnienie:");
               _pressure = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj wysokość:");
                _height = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj własną masę:");
                _selfWeight = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj głębokość:");
                _depth = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj masę ładunku:");
                _cargoWeight= double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj typ ładunku (0 - DANGEROUS, 1 - NORMAL):");
                _loadType = (LoadType)int.Parse(Console.ReadLine());

                container = new GasContainer(_serialNumber,_pressure,_height,_selfWeight,_depth,_cargoWeight,_loadType);
                break;

            case "2":
                Console.WriteLine("Podaj numer seryjny:");
                _serialNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj wysokość:");
                _height = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj własną masę:");
                _selfWeight = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj głębokość:");
                _depth = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj masę ładunku:");
                _cargoWeight = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj typ ładunku (0 - DANGEROUS, 1 - NORMAL):");
                _loadType = (LoadType)int.Parse(Console.ReadLine());

                container = new LiquidContainer(_serialNumber, _height, _selfWeight, _depth, _cargoWeight, _loadType);
                break;


            case "3":
                Console.WriteLine("Podaj numer seryjny:");
                _serialNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj wysokość:");
                _height = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj własną masę:");
                _selfWeight = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj głębokość:");
                _depth = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj masę ładunku:");
                _cargoWeight = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj typ ładunku (0 - DANGEROUS, 1 - NORMAL):");
                _loadType = (LoadType)int.Parse(Console.ReadLine());

                Console.WriteLine("Wybierz możliwe produkty (podaj liczby odzielone przecinkami):\n0. Banana\n1. Chocolate\n2. Fish\n3. Meat\n4. Ice_Cream\n5. Frozen_Pizza\n6. Cheese\n7. Sausages\n8. Butter\n9. Eggs");
                PossibleProducts _possibleProducts = (PossibleProducts)int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj temperaturę:");
                _temperature = double.Parse(Console.ReadLine());

                container = new CoolerContainer(_serialNumber, _height, _selfWeight, _depth, _cargoWeight, _loadType, _possibleProducts, _temperature);
                break;

            default:
                Console.WriteLine("Niepoprawny wybór. Proszę wybrać numer od 1 do 3.");
                return; 
        }

        Console.WriteLine($"Utworzono kontener typu: {container.GetType().Name}");
    }
}