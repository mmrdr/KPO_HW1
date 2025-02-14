namespace ZooManagementApp.Domain.Abstractions;

public interface IZooLogic
{
    void AddAnimal(Animal animal);

    void AddInventory(IInventory item);

    void Report();
}