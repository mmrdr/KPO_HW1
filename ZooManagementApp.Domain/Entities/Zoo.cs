using System.Threading.Channels;
using ZooManagementApp.Domain.Abstractions;

namespace ZooManagementApp.Domain.Entities;

public class Zoo: IZooLogic
{
    private readonly List<Animal> _animals = new();
    private readonly List<IInventory> _inventory = new();
    private readonly IVeterinaryClinic _veterinaryClinic;

    public Zoo(IVeterinaryClinic veterinaryClinic)
    {
        _veterinaryClinic = veterinaryClinic;
    }


    public void AddAnimal(Animal animal)
    {
        if (_veterinaryClinic.CheckHealth(animal))
        {
            _animals.Add(animal);
            _inventory.Add(animal);
            Console.WriteLine($"Animal {animal.Name} added");
        }
        else
        {
            Console.WriteLine($"Animal {animal.Name} is sick");
        }
    }

    public void AddInventory(Thing item)
    {
        _inventory.Add(item);
    }

    public void Report()
    {
        Console.WriteLine("Summary about the zoo");
        Console.WriteLine("---------------------");
        Console.WriteLine($"Total animal count: {_animals.Count}");
        Console.WriteLine($"Total food needed: {_animals.Sum(a => a.Food)} kg");
        Console.WriteLine($"Total inventory count: {_inventory.Count}");
        Console.WriteLine("Animals for contact zoo:");
        _animals.OfType<Herbo>().
            Where(a => a.IsContactZooable).
            ToList().ForEach(h => Console.WriteLine($"{h.Name} is kind, kids can play with it"));
        Console.WriteLine("Inventory:");
        _inventory.ForEach(i => Console.WriteLine($"Item: {i.GetType().Name}\t ItemID: {i.Number}"));
        Console.WriteLine("---------------------");
    }
}