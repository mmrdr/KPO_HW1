namespace ZooManagementApp.Domain.Abstractions;

public abstract class Thing: IInventory
{
    public int Number { get; }
    public string Name { get; }

    public Thing(int number, string name)
    {
        Number = number; 
        Name = name;
    }
}