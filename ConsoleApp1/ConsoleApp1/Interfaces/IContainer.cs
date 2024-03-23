namespace ConsoleApp1.Interfaces;

public interface IContainer
{
    void Unload(double undoCargoWeight);
    void Load(double cargoWeight);
    void SerialNumberGenerator(int serialNumber,List<int> numbers);
}