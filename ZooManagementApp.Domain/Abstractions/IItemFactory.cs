namespace ZooManagementApp.Domain.Abstractions;

public interface IItemFactory
{
    public Thing CreateThing(string type, int number);
}