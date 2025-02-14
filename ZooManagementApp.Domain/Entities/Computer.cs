using ZooManagementApp.Domain.Abstractions;

namespace ZooManagementApp.Domain.Entities;

public class Computer: Thing
{
    public Computer(int number) : base(number, "Computer")
    {
    }
}