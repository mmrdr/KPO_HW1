using ZooManagementApp.ZooManagementApp.Domain.Abstractions;

namespace ZooManagementApp.ZooManagementApp.Domain.Entities;

public class Rabbit: Herbo
{
    public Rabbit(int number, int kindnessLevel) 
        : base(2, number, "Rabbit", kindnessLevel)
    {
    }
}