using ZooManagementApp.Domain.Abstractions;

namespace ZooManagementApp.Domain.Entities;

public class Rabbit: Herbo
{
    public Rabbit(int food, int number, string name, int kindnessLevel) 
        : base(food, number, name, kindnessLevel)
    {
    }
}