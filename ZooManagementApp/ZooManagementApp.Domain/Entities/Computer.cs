using ZooManagementApp.ZooManagementApp.Domain.Abstractions;

namespace ZooManagementApp.ZooManagementApp.Domain.Entities;

public class Computer: Thing
{
    public Computer(int number) : base(number, "Computer")
    {
    }
}