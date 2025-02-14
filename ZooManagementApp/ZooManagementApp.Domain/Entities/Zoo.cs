using System.Threading.Channels;
using ZooManagementApp.ZooManagementApp.Domain.Abstractions;

namespace ZooManagementApp.ZooManagementApp.Domain.Entities;

public class Zoo
{
    private readonly List<Animal> _animals = new();
    private readonly List<IInventory> _inventory = new();
    private readonly IVeterinaryClinic _veterinaryClinic;

    public Zoo(IVeterinaryClinic veterinaryClinic)
    {
        _veterinaryClinic = veterinaryClinic;
    }

    void AddAnimal(Animal animal)
    {
        if (_veterinaryClinic.CheckHealth(animal))
        {
            _animals.Add(animal);
            Console.WriteLine($"Animal {animal.Name} added");
        }
        else
        {
            Console.WriteLine($"Animal {animal.Name} is sick");
        }
    }

    void AddInventary(IInventory item)
    {
        _inventory.Add(item);
    }

    public void Report()
    {
        Console.WriteLine($"Summary about the zoo");
        Console.WriteLine($"---------------------");
        Console.WriteLine($"Total count: {_animals.Count}");
        Console.WriteLine($"Total inventory count: {_inventory.Count}");
        Console.WriteLine("Animals for contact zoo:");
        _animals.OfType<Herbo>().
            Where(a => a.IsContactZooable).
            ToList().ForEach(h => Console.WriteLine($"{h.Name} is {h.IsContactZooable}"));
    }
}