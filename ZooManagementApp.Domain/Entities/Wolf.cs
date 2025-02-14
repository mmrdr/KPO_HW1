using ZooManagementApp.Domain.Abstractions;

namespace ZooManagementApp.Domain.Entities;

public class Wolf: Predator
{
    public Wolf(int food, int number, string name) : base(food, number, name)
    {
    }
}