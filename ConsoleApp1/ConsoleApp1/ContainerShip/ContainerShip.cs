using ConsoleApp1.Containers;

namespace ConsoleApp1.ContainerShip;

public class ContainerShip : Container
{
    private List<Container> _containers;
    private double _maxVelocity;
    private double _maxShipWeight;
    private int _maxContainerCount;
    int _serialNumber;
    double _pressure;
    double _height;
    double _selfWeight;
    double _depth;
    double _cargoWeight;
    LoadType _loadType;
    private double _temperature;

    public ContainerShip(double maxvelocity, double maxShipweight, int maxContainerCount)
    {
        _containers = new List<Container>();
        _maxVelocity = maxvelocity;
        _maxShipWeight = maxShipweight;
        _maxContainerCount = maxContainerCount;
    }

    public double MaxVelocity
    {
        get => _maxVelocity;
        set => _maxVelocity = value;
    }

    public double MaxShipWeight
    {
        get => _maxShipWeight;
        set => _maxShipWeight = value;
    }

    public int MaxContainerCount
    {
        get => _maxContainerCount;
        set => _maxContainerCount = value;
    }

    public void CreateContainer()
    {
        Container container = null;
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
    public void LoadContainer(Container container)
    {
        if (_containers.Count < _maxContainerCount)
        {
            _containers.Add(container);
            Console.WriteLine("Kontener został załadowany na statek.");
        }
        else
        {
            Console.WriteLine("Nie można załadować kontenera: statek ma już maksymalną liczbę kontenerów.");
        }
    }
    public void UnloadContainer(Container container)
    {
        if (_containers.Remove(container))
        {
            Console.WriteLine("Kontener został usunięty ze statku.");
        }
        else
        {
            Console.WriteLine("Nie znaleziono kontenera na statku.");
        }
    }
    public void PrintContainerInfo(Container container)
    {
        
        Console.WriteLine(container.ToString());
    }
    public void PrintShipInfo()
    {
        Console.WriteLine($"Statek: Maksymalna prędkość: {_maxVelocity}, Maksymalna waga: {_maxShipWeight}, Maksymalna liczba kontenerów: {_maxContainerCount}");
        Console.WriteLine("Ładunek na statku:");
        foreach (var container in _containers)
        {
            Console.WriteLine(container.ToString());
        }
    }
    public override string ToString()
    {
        return $"Serial Number: {_serialNumber}, " +
               $"Cargo Weight: {_cargoWeight} kilograms, " +
               $"Height: {_height} meters, " +
               $"Self Weight: {_selfWeight} kilograms, " +
               $"Depth: {_depth} meters, " +
               $"Load Type: {_loadType}";
    }
}