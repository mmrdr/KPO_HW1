using ZooManagementApp.Domain.Abstractions;

namespace ZooManagementApp.Domain.Entities;

public class Tiger: Predator
{
    public Tiger(int food, int number, string name) : base(food, number, name)
    {
    }
}