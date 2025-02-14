using ZooManagementApp.ZooManagementApp.Domain.Abstractions;

namespace ZooManagementApp.ZooManagementApp.Domain.Entities;

public class VeterinaryClinic: IVeterinaryClinic
{
    public bool CheckHealth(Animal animal)
    {
        return true; // all animals are are healthy
    }
}