using ZooManagementApp.ZooManagementApp.Domain.Abstractions;

namespace ZooManagementApp.ZooManagementApp.Domain.Entities;

public class Table: Thing
{
    public Table(int number) : base(number, "Table")
    {
    }
}