using ZooManagementApp.ZooManagementApp.Domain.Abstractions;

namespace ZooManagementApp.ZooManagementApp.Domain.Entities;

public class Monkey: Herbo
{
    public Monkey(int number, int kindnessLevel) 
        : base(3, number, "Monkey", kindnessLevel)
    {
    }
}