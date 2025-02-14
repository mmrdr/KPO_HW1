using ZooManagementApp.Domain.Abstractions;

namespace ZooManagementApp.Domain.Entities;

public class Monkey: Herbo
{
    public Monkey(int food, int number, string name, int kindnessLevel) 
        : base(food, number, name, kindnessLevel)
    {
    }
}