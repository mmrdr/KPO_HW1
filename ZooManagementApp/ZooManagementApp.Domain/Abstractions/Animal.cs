namespace ZooManagementApp.ZooManagementApp.Domain.Abstractions;

public abstract class Animal: IAlive, IInventory
{
    public int Food {get;}
    public int Number {get;}
    public string Name {get;}

    protected Animal(int food, int number, string name)
    {
        Food = food;
        Number = number;
        Name = name;
    }
}