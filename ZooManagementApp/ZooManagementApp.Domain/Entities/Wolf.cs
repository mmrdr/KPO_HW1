using ZooManagementApp.ZooManagementApp.Domain.Abstractions;

namespace ZooManagementApp.ZooManagementApp.Domain.Entities;

public class Wolf: Predator
{
    public Wolf(int number) : base(7, number, "Wolf")
    {
    }
}