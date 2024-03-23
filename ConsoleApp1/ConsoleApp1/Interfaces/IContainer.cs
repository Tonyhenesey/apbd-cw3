namespace ConsoleApp1.Interfaces;

public interface IContainer
{
    void Unload(double undoCargoWeight);
    void Load(double cargoWeight);
}