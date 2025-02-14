using ZooManagementApp.Domain.Abstractions;

namespace ZooManagementApp.Domain.Entities;

public class Table: Thing
{
    public Table(int number) : base(number, "Table")
    {
    }
}