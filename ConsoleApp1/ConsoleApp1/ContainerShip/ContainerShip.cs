using ConsoleApp1.Containers;

namespace ConsoleApp1.ContainerShip;

public class ContainerShip : Container
{
    private List<Container> _containers;
    private double _maxvelocity;
    private double _maxShipweight;
    private int _maxContainerCount;
    

    public ContainerShip(List<Container> containers, double maxvelocity, double maxShipweight, int maxContainerCount) : base()
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
                int serialNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj ciśnienie:");
                double pressure = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj wysokość:");
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj własną masę:");
                double selfWeight = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj głębokość:");
                double depth = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj masę ładunku:");
                double cargoWeight = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj typ ładunku (0 - DANGEROUS, 1 - NORMAL):");
                LoadType loadType = (LoadType)int.Parse(Console.ReadLine());

                container = new GasContainer(serialNumber, pressure, height, selfWeight, depth, cargoWeight, loadType);
                break;

            case "2":
                container = new LiquidContainer();
                break;
            case "3":
                container = new CoolerContainer();
                break;
            default:
                Console.WriteLine("Niepoprawny wybór. Proszę wybrać numer od 1 do 3.");
                return; // Wyjście z metody, jeśli wybór jest niepoprawny
        }

        Console.WriteLine($"Utworzono kontener typu: {container.GetType().Name}");
    }
}