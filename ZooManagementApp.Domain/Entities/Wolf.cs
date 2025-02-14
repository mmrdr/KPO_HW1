using ZooManagementApp.ZooManagementApp.Domain.Abstractions;

namespace ZooManagementApp.ZooManagementApp.Domain.Entities;

public class Wolf: Predator
{
    public Wolf(int food, int number, string name) : base(food, number, name)
    {
    }
}