using Microsoft.Extensions.DependencyInjection;
using ZooManagementApp.Domain.Entities;
using ZooManagementApp.Domain.Abstractions;
namespace ZooManagementApp;

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddSingleton<IVeterinaryClinic, VeterinaryClinic>();
        services.AddSingleton<IZooLogic, ZooLogic>();
        var provider = services.BuildServiceProvider();
        var zoo = provider.GetService<IZooLogic>();
        
    }
}