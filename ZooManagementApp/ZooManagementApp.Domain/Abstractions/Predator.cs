namespace ZooManagementApp.ZooManagementApp.Domain.Abstractions;

public abstract class Predator: Animal
{
    protected Predator(int food, int number, string name) : base(food, number, name)
    {
        // hello world!
    }
}