using ZooManagementApp.Domain.Abstractions;

namespace ZooManagementApp.Domain.Entities;

public class ZooFactory: IZooFactory
{
    private readonly HashSet<int> _ids = new(); // here i store id for items
    public Thing CreateThing(string type, int number)
    {
        if (_ids.Contains(number))
        {
            throw new ArgumentException("Item with this number already exists");
        }
        _ids.Add(number);
        // depends on user inout creat animal
        return type switch
        {
            "D1" => new Table(number),
            "D2" => new Computer(number),
            _ => throw new ArgumentException("Unknown item")
        };
    }

    public Animal CreateAnimal(string type, int food, int number, string name, int kindness = 0)
    {
        if (_ids.Contains(number))
        {
            throw new ArgumentException("Item with this number already exists");
        }
        _ids.Add(number);
        // depends on user input creat animal
        return type switch
        {
            "D1" => new Monkey(food, number, name, kindness),
            "D2" => new Rabbit(food, number, name, kindness),
            "D3" => new Tiger(food, number, name),
            "D4" => new Wolf(food, number, name),
            _ => throw new ArgumentException("Unknown item")
        };
    }
}