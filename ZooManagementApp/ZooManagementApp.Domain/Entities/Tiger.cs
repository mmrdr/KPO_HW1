using ZooManagementApp.ZooManagementApp.Domain.Abstractions;

namespace ZooManagementApp.ZooManagementApp.Domain.Entities;

public class Tiger: Predator
{
    public Tiger(int number) : base(8, number, "Tiger")
    {
    }
}