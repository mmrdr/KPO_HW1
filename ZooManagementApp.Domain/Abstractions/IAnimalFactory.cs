namespace ZooManagementApp.Domain.Abstractions;

public interface IAnimalFactory
{
    public Animal CreateAnimal(string type, int food, int number, string name, int kindness = 0);
}