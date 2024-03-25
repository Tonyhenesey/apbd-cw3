using ConsoleApp1.Containers;
using ConsoleApp1.ContainerShip;
using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
    {
        List<Container> containers = new List<Container>();
        ContainerShip containerShip = new ContainerShip( 20, 10000, 100);

        while (true)
        {
            Console.WriteLine("Wybierz operację:\n" +
                              "1. Dodaj kontenerowiec\n" +
                              "2. Załaduj kontener na statek\n" +
                              "3. Usuń kontener ze statku\n" +
                              "4. Wyświetl informacje o statku\n" +
                              "5. Wyjście");
            
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "1":
                    Console.WriteLine("Wprowadź dane nowego statku kontenerowego:");

                    Console.Write("Maksymalna prędkość: ");
                    double maxVelocity = double.Parse(Console.ReadLine());

                    Console.Write("Maksymalna waga statku: ");
                    double maxShipWeight = double.Parse(Console.ReadLine());

                    Console.Write("Maksymalna liczba kontenerów: ");
                    int maxContainerCount = int.Parse(Console.ReadLine());

                    
                    containerShip = new ContainerShip(maxVelocity, maxShipWeight, maxContainerCount);

                    Console.WriteLine("Nowy statek kontenerowy został stworzony.");
                    break;

                case "2":
                    containerShip.CreateContainer();
                    if(containerShip != null)
                    {
                        containerShip.LoadContainer(containerShip);
                    }
                    break;

                case "3":
                    containerShip.UnloadContainer(containerShip);
                    break;

                case "4":
                    containerShip.PrintShipInfo();
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Nieprawidłowa operacja.");
                    break;
            }
        }
    }
}