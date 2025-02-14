namespace ZooManagementApp.Domain.Abstractions;

public interface IZooLogic
{
    void AddAnimal(Animal animal);

    void AddInventory(Thing item);

    void Report();
}